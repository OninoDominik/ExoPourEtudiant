using System;
using System.Collections.Generic;
using System.Text;

namespace valabsolue
{
    class Forme
    {
        private Coordonnes pointDeBase;
        
        public Forme()
        { }

        public Forme(Coordonnes pointDeBase)
        {
            PointDeBase = pointDeBase;
        }

        public Coordonnes PointDeBase
        {
            get { return pointDeBase; }
            set { pointDeBase = value; }
        }
        public string EnString()
        {
            return "la forme a son point de base en x: " + PointDeBase.X + " y: " + PointDeBase.Y;
        }
        public virtual double Area() 
        { return 1; }
        public virtual double Perimeter()
        { return 1; }

    }
}
