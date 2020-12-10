using System;

namespace valabsolue
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Personne toto = new Personne();
            Personne dom = new Personne("grob", "Dom", 38, "1 rue truc", "0606060505");
            Portefeuille portefeuilleDeDom = new Portefeuille(dom, 999);
            Personne michel = new Personne("michel", "michel", 10, "1 rue michel", "0606060505");
            Portefeuille portefeuilleDeMichel = new Portefeuille(michel, 500);
            portefeuilleDeDom.TransacCredit(portefeuilleDeMichel, 500);
            */
            /*
            Point tutu = new Point(5, 5);
            Cercle tutuCercle = new Cercle(tutu, 5);
            Point origine = new Point(0, 0);
            Console.WriteLine(tutuCercle.Appartient(origine));
            Console.WriteLine(tutuCercle.getPerimeter());
            Console.WriteLine(tutuCercle.getSurface());
            Console.WriteLine(tutuCercle.Afficher());
            Console.WriteLine(tutuCercle.Centre.Afficher());
            */
            Coordonnes tata = new Coordonnes(5, 5);
            Forme FormeTest = new Forme(tata);
            Cercle2 cercle2Test = new Cercle2(5, tata);
            Console.WriteLine(cercle2Test.Perimeter());
            Console.WriteLine(cercle2Test.Area());
            Rectangle Rectangle2Test = new Rectangle(3,4, tata);
            Forme FormeRectangleTest= new Rectangle(10, 12, tata);
            Console.WriteLine(Rectangle2Test.Area());
            Console.WriteLine(FormeRectangleTest.Area());
        }
    }
}
