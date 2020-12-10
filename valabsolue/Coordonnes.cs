using System;
using System.Collections.Generic;
using System.Text;

namespace valabsolue
{
    class Coordonnes
    {
        private int x;
        private int y;
        public Coordonnes(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Coordonnes()
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
    }
}
