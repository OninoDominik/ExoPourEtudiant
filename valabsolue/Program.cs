using System;

namespace valabsolue
{
    class Program
    {
        static void Main(string[] args)
        { 

            Personne toto = new Personne();
            Personne dom = new Personne("grob", "Dom", 38, "1 rue truc", "0606060505");
            Portefeuille portefeuilleDeDom = new Portefeuille(dom, 999);
            Personne michel = new Personne("michel", "michel", 10, "1 rue michel", "0606060505");
            Portefeuille portefeuilleDeMichel = new Portefeuille(michel, 500);
            portefeuilleDeDom.TransacCredit(portefeuilleDeMichel, 500);


        }
    }
}
