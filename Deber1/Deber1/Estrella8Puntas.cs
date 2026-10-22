using System;
using System.Drawing;

namespace Deber1
{
    // Estrella de 8 puntas: 250x250 
    public partial class Estrella8Puntas : Estrella
    {
        public Estrella8Puntas() : this(0, 0) { }

        public Estrella8Puntas(float x, float y) : base(x, y, 250, 250)
        {
            InitializeComponent();
        }

        public override int CantidadPuntas => 8;
        public override float ProporcionRadioInterior => 0.285f;

        public override float ObtenerRadioExterior() => Math.Min(Ancho, Alto) / 2f;

        public override void Dibujar(Graphics g)
        {
            DibujarEstrellaBase(g);
        }
    }
}
