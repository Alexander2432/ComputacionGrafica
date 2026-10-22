using System;
using System.Drawing;

namespace Deber1
{
    // Estrella de 4 puntas: 200x200 
    public partial class Estrella4Puntas : Estrella
    {
        public Estrella4Puntas() : this(0, 0) { }

        public Estrella4Puntas(float x, float y) : base(x, y, 200, 200)
        {
            InitializeComponent();
        }

        public override int CantidadPuntas => 4;
        public override float ProporcionRadioInterior => 0.26f;

        public override float ObtenerRadioExterior() => Math.Min(Ancho, Alto) / 2f;

        public override void Dibujar(Graphics g)
        {
            DibujarEstrellaBase(g);
        }
    }
}
