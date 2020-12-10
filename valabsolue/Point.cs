using System;
using System.Collections.Generic;
using System.Text;

namespace valabsolue
{
    class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point()
        { }

        public int X
            {
            get { return x; }
            set { x = value; }
            }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public string Afficher()
        {
            return " le point a les coordonnes x:" + X + " y:" + Y; 
        }

    }
}
