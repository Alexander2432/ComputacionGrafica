namespace tareaClase
{
    public class Punto2D
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Punto2D() { }

        public Punto2D(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X:F2}, {Y:F2})";
        }
    }
}
