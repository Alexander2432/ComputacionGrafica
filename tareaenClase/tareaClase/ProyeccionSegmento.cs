using System;

namespace tareaClase
{
    public class ProyeccionSegmento
    {
        public Punto2D A { get; set; }
        public Punto2D B { get; set; }
        public Punto2D P { get; set; }

        public Punto2D Q { get; private set; }
        public double Distancia { get; private set; }
        public double T { get; private set; }
        public string Mensaje { get; private set; }

        public ProyeccionSegmento(Punto2D a, Punto2D b, Punto2D p)
        {
            A = a;
            B = b;
            P = p;
        }

        public void Calcular()
        {
            // Vector AB y Vector AP
            float abX = B.X - A.X;
            float abY = B.Y - A.Y;

            float apX = P.X - A.X;
            float apY = P.Y - A.Y;

            // Magnitud al cuadrado de AB: |AB|^2
            float abCuadrado = abX * abX + abY * abY;

            // Caso especial: A y B son el mismo punto (longitud cero)
            if (abCuadrado == 0)
            {
                Q = new Punto2D(A.X, A.Y);
                float dx = P.X - A.X;
                float dy = P.Y - A.Y;
                Distancia = Math.Sqrt(dx * dx + dy * dy);
                T = 0;
                Mensaje = "Caso especial: A y B son iguales. El punto más cercano es A.";
                return;
            }

            // Producto punto entre AP y AB
            float productoPunto = apX * abX + apY * abY;

            // Proyección escalar t = (AP · AB) / |AB|^2
            T = (double)productoPunto / abCuadrado;

            // Restringir t al segmento [0, 1]
            double tClamped = Math.Max(0.0, Math.Min(1.0, T));

            // Punto Q sobre el segmento: Q = A + t * AB
            float qX = (float)(A.X + tClamped * abX);
            float qY = (float)(A.Y + tClamped * abY);
            Q = new Punto2D(qX, qY);

            // Distancia euclidiana entre P y Q: |P - Q|
            float pqX = P.X - qX;
            float pqY = P.Y - qY;
            Distancia = Math.Sqrt(pqX * pqX + pqY * pqY);

            // Estado de la proyección
            if (T < 0)
                Mensaje = "La proyección cae antes de A. Q se ubica en el extremo A.";
            else if (T > 1)
                Mensaje = "La proyección cae después de B. Q se ubica en el extremo B.";
            else
                Mensaje = "Proyección perpendicular directa sobre el segmento AB.";
        }
    }
}
