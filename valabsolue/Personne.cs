using System;
using System.Collections.Generic;
using System.Text;

namespace valabsolue
{
    class Personne
    {
        private string nom;
        private string prenom;
        private int age;
        private string adresse;
        private string numDeTel;

        public string Nom { 
            get { return nom; } 
            set { nom = value; } 
        }
        public string Prenom { 
            get { return prenom; }
            set { prenom = value; }
        }
        public int Age {
            get { return age; }
            set { age = value; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public string NumDeTel
        {
            get { return numDeTel; }
            set { numDeTel = value; }
        }

        public Personne(string nom, string prenom, int age, string adresse, string numDeTel)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Adresse = adresse;
            NumDeTel = numDeTel;
        }

        public Personne()
        {
            Nom = "toto";
            Prenom = "turlututu";
            Age = 25;
            Adresse = "2 rue bla";
            NumDeTel = "0606060606";
        }
    }
}
