using System;
using System.Collections.Generic;
using System.Text;

namespace valabsolue
{
    class Cercle
    {
        private Point centre;
        private double rayon;

        public Cercle(Point centre, double rayon)
        {
            Centre = centre;
            Rayon = rayon;
        }

        public Point Centre
        {
            get { return centre; }
            set { centre = value; }
        }
        public double Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }

        public double getPerimeter()
        {
            return 2 * Math.PI * Rayon;
        }
        public double getSurface()
        {
            return Math.PI * Rayon * Rayon;
        }
        public bool Appartient(Point pointATester)
        {
            double dis = Math.Sqrt(Math.Pow(Centre.X - pointATester.X, 2) + Math.Pow(Centre.Y - pointATester.Y, 2));
            if (dis<Rayon)
            { return true; }
            else
            { return false; }
        }
        public string Afficher()
        {
            return "le centre du cercle a des coordonnées x: " + Centre.X + " y: " 
                   + Centre.Y + " est un rayon de " + Rayon; 

        }
    }
}
