using System;
using System.Collections.Generic;
using System.Text;

namespace valabsolue
{
    class Cercle2 : Forme
    {
        private double rayon;

        public Cercle2(double rayon, Coordonnes coord) :base(coord)
        {
            Rayon = rayon;
        }

        public double Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }

        public override double Area()
        {
            return Math.PI * Rayon * Rayon;
        }

        public override double Perimeter()
        {
            return Math.PI * Rayon * 2;
        }

    }
}
