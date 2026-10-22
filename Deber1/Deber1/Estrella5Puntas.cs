using System;
using System.Drawing;

namespace Deber1
{
    // Estrella de 5 puntas: 200x200 px 
    public partial class Estrella5Puntas : Estrella
    {
        public Estrella5Puntas() : this(0, 0) { }

        public Estrella5Puntas(float x, float y) : base(x, y, 200, 200)
        {
            InitializeComponent();
        }

        public override int CantidadPuntas => 5;
        public override float ProporcionRadioInterior => 0.382f;

        public override float ObtenerRadioExterior()
        {
            return (float)(Ancho / (2.0 * Math.Cos(18.0 * Math.PI / 180.0)));
        }

        public override PointF ObtenerCentro()
        {
            float r = ObtenerRadioExterior();
            float altoReal = (float)(r * (1.0 + Math.Cos(36.0 * Math.PI / 180.0)));
            return new PointF(X + Ancho / 2f, Y + (Alto - altoReal) / 2f + r);
        }

        public override void Dibujar(Graphics g)
        {
            DibujarEstrellaBase(g);
        }
    }
}
