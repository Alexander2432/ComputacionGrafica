using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;

namespace tareaClase
{
    public partial class FrmProyeccion : Form
    {
        private ProyeccionSegmento proyeccion;

        public FrmProyeccion()
        {
            InitializeComponent();
            DoubleBuffered = true;
            CalcularYGraficar();
        }

        private bool ParseFloat(string texto, out float valor)
        {
            string normalizado = texto.Trim().Replace(',', '.');
            return float.TryParse(normalizado, NumberStyles.Float, CultureInfo.InvariantCulture, out valor);
        }

        private void CalcularYGraficar()
        {
            if (!ParseFloat(txtAx.Text, out float ax) ||
                !ParseFloat(txtAy.Text, out float ay) ||
                !ParseFloat(txtBx.Text, out float bx) ||
                !ParseFloat(txtBy.Text, out float by) ||
                !ParseFloat(txtPx.Text, out float px) ||
                !ParseFloat(txtPy.Text, out float py))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para todos los puntos.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Punto2D a = new Punto2D(ax, ay);
            Punto2D b = new Punto2D(bx, by);
            Punto2D p = new Punto2D(px, py);

            proyeccion = new ProyeccionSegmento(a, b, p);
            proyeccion.Calcular();

            lblQ.Text = $"Q = {proyeccion.Q}";
            lblDistancia.Text = $"{proyeccion.Distancia:F4}";
            lblMensaje.Text = proyeccion.Mensaje;

            picGrafica.Invalidate();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularYGraficar();
        }

        private void picGrafica_Resize(object sender, EventArgs e)
        {
            picGrafica.Invalidate();
        }

        private void picGrafica_Paint(object sender, PaintEventArgs e)
        {
            if (proyeccion == null || proyeccion.Q == null) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int W = picGrafica.ClientSize.Width;
            int H = picGrafica.ClientSize.Height;
            if (W <= 0 || H <= 0) return;

            float minX = Math.Min(0, Math.Min(proyeccion.A.X, Math.Min(proyeccion.B.X, Math.Min(proyeccion.P.X, proyeccion.Q.X)))) - 1.5f;
            float maxX = Math.Max(10, Math.Max(proyeccion.A.X, Math.Max(proyeccion.B.X, Math.Max(proyeccion.P.X, proyeccion.Q.X)))) + 1.5f;
            float minY = Math.Min(0, Math.Min(proyeccion.A.Y, Math.Min(proyeccion.B.Y, Math.Min(proyeccion.P.Y, proyeccion.Q.Y)))) - 1.5f;
            float maxY = Math.Max(8, Math.Max(proyeccion.A.Y, Math.Max(proyeccion.B.Y, Math.Max(proyeccion.P.Y, proyeccion.Q.Y)))) + 1.5f;

            int pad = 40;
            float escala = Math.Min((W - 2 * pad) / (maxX - minX), (H - 2 * pad) / (maxY - minY));

            PointF ToPix(float x, float y)
            {
                float px = pad + (x - minX) * escala;
                float py = H - pad - (y - minY) * escala;
                return new PointF(px, py);
            }

            // Cuadrícula secundaria
            using (Pen penGrid = new Pen(Color.FromArgb(235, 235, 235), 1))
            {
                for (int x = (int)Math.Floor(minX); x <= (int)Math.Ceiling(maxX); x++)
                    g.DrawLine(penGrid, ToPix(x, minY), ToPix(x, maxY));

                for (int y = (int)Math.Floor(minY); y <= (int)Math.Ceiling(maxY); y++)
                    g.DrawLine(penGrid, ToPix(minX, y), ToPix(maxX, y));
            }

            // Ejes X e Y
            using (Pen penEje = new Pen(Color.Silver, 1))
            using (Font fontEje = new Font("Arial", 8f))
            {
                if (minX <= 0 && maxX >= 0)
                    g.DrawLine(penEje, ToPix(0, minY), ToPix(0, maxY));

                if (minY <= 0 && maxY >= 0)
                    g.DrawLine(penEje, ToPix(minX, 0), ToPix(maxX, 0));

                for (int x = (int)Math.Floor(minX); x <= (int)Math.Ceiling(maxX); x += 2)
                    g.DrawString(x.ToString(), fontEje, Brushes.Gray, ToPix(x, 0).X - 6, ToPix(x, 0).Y + 3);

                for (int y = (int)Math.Floor(minY); y <= (int)Math.Ceiling(maxY); y += 2)
                    if (y != 0)
                        g.DrawString(y.ToString(), fontEje, Brushes.Gray, ToPix(0, y).X + 4, ToPix(0, y).Y - 6);
            }

            PointF pixA = ToPix(proyeccion.A.X, proyeccion.A.Y);
            PointF pixB = ToPix(proyeccion.B.X, proyeccion.B.Y);
            PointF pixP = ToPix(proyeccion.P.X, proyeccion.P.Y);
            PointF pixQ = ToPix(proyeccion.Q.X, proyeccion.Q.Y);

            // Segmento AB
            using (Pen penAB = new Pen(Color.RoyalBlue, 3))
            {
                g.DrawLine(penAB, pixA, pixB);
            }

            // Línea perpendicular PQ
            using (Pen penPQ = new Pen(Color.Crimson, 2) { DashStyle = DashStyle.Dash })
            {
                g.DrawLine(penPQ, pixP, pixQ);
            }

            // Puntos
            DibujarPunto(g, pixA, Brushes.RoyalBlue, 5);
            DibujarPunto(g, pixB, Brushes.RoyalBlue, 5);
            DibujarPunto(g, pixP, Brushes.DarkOrange, 6);
            DibujarPunto(g, pixQ, Brushes.ForestGreen, 6);

            // Rótulos con nombres y coordenadas
            using (Font fontLabel = new Font("Arial", 8.5f, FontStyle.Bold))
            {
                g.DrawString($"A {proyeccion.A}", fontLabel, Brushes.RoyalBlue, pixA.X + 8, pixA.Y - 15);
                g.DrawString($"B {proyeccion.B}", fontLabel, Brushes.RoyalBlue, pixB.X + 8, pixB.Y - 15);
                g.DrawString($"P {proyeccion.P}", fontLabel, Brushes.DarkOrange, pixP.X + 8, pixP.Y - 15);
                g.DrawString($"Q {proyeccion.Q}", fontLabel, Brushes.ForestGreen, pixQ.X + 8, pixQ.Y + 8);
            }
        }

        private void DibujarPunto(Graphics g, PointF p, Brush b, float r)
        {
            g.FillEllipse(b, p.X - r, p.Y - r, r * 2, r * 2);
            g.DrawEllipse(Pens.Black, p.X - r, p.Y - r, r * 2, r * 2);
        }
    }
}
