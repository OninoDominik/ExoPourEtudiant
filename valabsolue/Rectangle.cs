using System;
using System.Collections.Generic;
using System.Text;

namespace valabsolue
{
    class Rectangle : Forme
    {
        private double cote1;
        private double cote2;

        public Rectangle(double cote1, double cote2, Coordonnes coord):base(coord)
        {
            this.Cote1 = cote1;
            this.Cote2 = cote2;
        }

        public double Cote1
        {
            get { return cote1; }
            set { cote1 = value;  }
        }
        public double Cote2
        {
            get { return cote2; }
            set { cote2 = value; }
        }

        public override double Area()
        {
            return Cote1 * Cote2;
        }
        public override double Perimeter()
        {
            return Cote1*Cote2;
        }
    }
}
