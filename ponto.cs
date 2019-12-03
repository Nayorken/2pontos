using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2pontos
{
    class ponto
    {
        private double _X;
        private double _Y;
        private double _Z;

        public double X {set => _X = value; get => _X;}
        public double Y {set => _Y = value; get => _Y;}
        public double Z { set => _Z = value; get => _Z; }
        public double Distancia(ponto P)
        {
            return Math.Sqrt(Math.Pow(P.X - _X, 2) + Math.Pow(P.Y - _Y, 2) + Math.Pow(P.Z - _Z, 2));
        }





        /*
        private double _x1, _x2, _y1, _y2;
        public string PontoX1 { set => _x1 = Convert.ToDouble(value); }
        public string PontoX2 { set => _x2 = Convert.ToDouble(value); }
        public string PontoY1 { set => _y1 = Convert.ToDouble(value); }
        public string PontoY2 { set => _y2 = Convert.ToDouble(value); }
        public string Pontos => (Math.Sqrt((_x2 - _x1) * (_x2 - _x1) + (_y2 - _y1) * (_y2 - _y1))).ToString();
    
    */
    }
}
