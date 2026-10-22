using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Deber1
{
    public partial class Estrella : Form
    {
        // Encapsulamiento
        private float x;
        private float y;
        private float ancho;
        private float alto;
        private Color colorLinea = Color.Black;
        private float grosorLinea = 1.6f;
        private Color colorNegro = Color.Black;
        private Color colorBlanco = Color.White;

        public Estrella() : this(0, 0, 200, 200) { }

        public Estrella(float x, float y, float ancho, float alto)
        {
            InitializeComponent();
            this.x = x;
            this.y = y;
            this.ancho = ancho;
            this.alto = alto;
            this.ClientSize = new Size((int)ancho, (int)alto);
            this.BackColor = Color.White;
        }

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public float Ancho { get => ancho; set => ancho = value; }
        public float Alto { get => alto; set => alto = value; }
        public Color ColorLinea { get => colorLinea; set => colorLinea = value; }
        public float GrosorLinea { get => grosorLinea; set => grosorLinea = value; }

        // Polimorfismo
        public virtual int CantidadPuntas => 4;
        public virtual float ProporcionRadioInterior => 0.25f;
        public virtual float ObtenerRadioExterior() => Math.Min(ancho, alto) / 2f;
        public virtual PointF ObtenerCentro() => new PointF(x + ancho / 2f, y + alto / 2f);

        protected void DibujarLinea(Graphics g, PointF p1, PointF p2)
        {
            using (Pen pen = new Pen(colorLinea, grosorLinea) { LineJoin = LineJoin.Miter })
                g.DrawLine(pen, p1, p2);
        }

        protected void RellenarRegion(Graphics g, PointF[] puntos, Color color)
        {
            using (SolidBrush brush = new SolidBrush(color))
                g.FillPolygon(brush, puntos);
        }

        // Cálculo trigonométrico de puntas 
        public (PointF[] Puntas, PointF[] Valles) CalcularPuntos()
        {
            int n = CantidadPuntas;
            PointF centro = ObtenerCentro();
            float radioExt = ObtenerRadioExterior();
            float radioInt = radioExt * ProporcionRadioInterior;

            PointF[] puntas = new PointF[n];
            PointF[] valles = new PointF[n];

            double paso = (2.0 * Math.PI) / n;
            double medioPaso = paso / 2.0;
            double anguloInicial = -Math.PI / 2.0;

            for (int i = 0; i < n; i++)
            {
                double aPunta = anguloInicial + i * paso;
                double aValle = aPunta + medioPaso;

                puntas[i] = new PointF(
                    (float)(centro.X + radioExt * Math.Cos(aPunta)),
                    (float)(centro.Y + radioExt * Math.Sin(aPunta)));

                valles[i] = new PointF(
                    (float)(centro.X + radioInt * Math.Cos(aValle)),
                    (float)(centro.Y + radioInt * Math.Sin(aValle)));
            }

            return (puntas, valles);
        }

        protected void DibujarEstrellaBase(Graphics g)
        {
            int n = CantidadPuntas;
            PointF centro = ObtenerCentro();
            var (puntas, valles) = CalcularPuntos();

            // Efecto 3D
            for (int i = 0; i < n; i++)
            {
                PointF valleAnt = (i == 0) ? valles[n - 1] : valles[i - 1];
                PointF punta = puntas[i];
                PointF valleSig = valles[i];

                RellenarRegion(g, new PointF[] { centro, valleAnt, punta }, colorBlanco);
                RellenarRegion(g, new PointF[] { centro, punta, valleSig }, colorNegro);
            }

            // Divisiones internas y contornos 
            for (int i = 0; i < n; i++)
            {
                PointF valleAnt = (i == 0) ? valles[n - 1] : valles[i - 1];
                PointF punta = puntas[i];
                PointF valleSig = valles[i];

                DibujarLinea(g, centro, punta);
                DibujarLinea(g, centro, valleSig);

                DibujarLinea(g, valleAnt, punta);
                DibujarLinea(g, punta, valleSig);
            }
        }

        public virtual void Dibujar(Graphics g)
        {
            DibujarEstrellaBase(g);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Dibujar(e.Graphics);
        }
    }
}
