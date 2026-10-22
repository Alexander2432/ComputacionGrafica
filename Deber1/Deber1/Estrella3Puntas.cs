using System;
using System.Drawing;

namespace Deber1
{
    // Estrella de 3 puntas: 200x200 
    public partial class Estrella3Puntas : Estrella
    {
        public Estrella3Puntas() : this(0, 0) { }

        public Estrella3Puntas(float x, float y) : base(x, y, 200, 200)
        {
            InitializeComponent();
        }

        public override int CantidadPuntas => 3;
        public override float ProporcionRadioInterior => 0.14f;

        public override float ObtenerRadioExterior() => (float)(Ancho / Math.Sqrt(3.0));

        public override PointF ObtenerCentro()
        {
            float r = ObtenerRadioExterior();
            float altoReal = 1.5f * r;
            return new PointF(X + Ancho / 2f, Y + (Alto - altoReal) / 2f + r);
        }

        public override void Dibujar(Graphics g)
        {
            DibujarEstrellaBase(g);
        }
    }
}
