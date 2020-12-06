using System;
using System.Collections.Generic;
using System.Text;

namespace valabsolue
{
    static class ValeurAbsolue
    {
        public static double Calculer (double valeur)
        {
            if (valeur < 0)
            {
                valeur = -valeur;
            }
            return valeur;
        }
    }
}
