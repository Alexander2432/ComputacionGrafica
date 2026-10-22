using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Deber1
{
    public partial class Home : Form
    {
        // Lista polimórfica 
        private readonly List<Estrella> estrellas = new List<Estrella>();

        private Estrella5Puntas est5;
        private Estrella8Puntas est8;
        private Estrella3Puntas est3;
        private Estrella4Puntas est4;

        public Home()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            est5 = new Estrella5Puntas();
            est8 = new Estrella8Puntas();
            est3 = new Estrella3Puntas();
            est4 = new Estrella4Puntas();

            estrellas.Add(est5);
            estrellas.Add(est8);
            estrellas.Add(est3);
            estrellas.Add(est4);

            AlinearEstrellas();
        }

        // Centrado de la cuadrícula 2x2
        private void AlinearEstrellas()
        {
            if (est5 == null || est8 == null || est3 == null || est4 == null)
                return;

            float totalAncho = 200 + 90 + 250;
            float totalAlto = 250 + 70 + 200;

            float inicioX = Math.Max(40, (this.ClientSize.Width - totalAncho) / 2f);
            float inicioY = Math.Max(25, (this.ClientSize.Height - totalAlto) / 2f);

            est5.X = inicioX;
            est5.Y = inicioY + 25;
            est8.X = inicioX + 290;
            est8.Y = inicioY;

            est3.X = inicioX;
            est3.Y = inicioY + 320;
            est4.X = inicioX + 290 + 25;
            est4.Y = inicioY + 320;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AlinearEstrellas();
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Polimorfismo
            foreach (Estrella estrella in estrellas)
            {
                estrella.Dibujar(e.Graphics);
            }
        }
    }
}
