using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2pontos
{
    class triangulo
    {
        public ponto P1 = new ponto();
        public ponto P2 = new ponto();
        public ponto P3 = new ponto();

        public double perimetro => P1.Distancia(P2) + P2.Distancia(P3) + P3.Distancia(P1);


        public double Area
        {
            get
            {
                double s = this.perimetro / 2;
                double a = P1.Distancia(P2);
                double b = P2.Distancia(P3);
                double c = P3.Distancia(P1);
                double T = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                return 0;
            }
        }
    }
}
