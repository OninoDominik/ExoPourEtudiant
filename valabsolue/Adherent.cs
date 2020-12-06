using System;
using System.Collections.Generic;
using System.Text;

namespace valabsolue
{
    class Adherent
    {
        private static int numMaxClient=0;
        private int numClient;
        private string nom;
        private double cotisation;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public double Cotisation
        {
            get { return cotisation; }
            set { cotisation = value; }
        }

        public double Modifie2
        {
            set { cotisation = value; }
        }

        public Adherent()
        {
            numMaxClient++;
            numClient = numMaxClient;
            cotisation = 10;
            nom = "anonyme";
        }

        public Adherent(string nom, double cotisation)
        {
            numMaxClient++;
            numClient = numMaxClient;
            this.cotisation = cotisation;
            this.nom = nom;
        }

        public void Modifie(double cotisation)
        {
            this.cotisation = cotisation;
        }

        public string EnString()
        {
            string resultat = "nom : " + nom + " num client : " + numClient +" la cotisation est de: " + cotisation ;
            return resultat;
        }
    }
}
