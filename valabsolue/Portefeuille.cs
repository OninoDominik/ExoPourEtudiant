using System;
using System.Collections.Generic;
using System.Text;

namespace valabsolue
{
    class Portefeuille
    {
        private Personne proprio;
        private decimal montant;

        public Personne Proprio
        {
            get { return proprio; }
            set { proprio = value; }
        }
        public decimal Montant
        {
            get { return montant; }
            set { montant = value; }
        }

        public void crediter (decimal valeur)
        {
            montant = montant + valeur;
        }

        public decimal crediterVotreVersion(decimal valeur)
        {
           return montant = montant + valeur;
        }
        public void debiter(decimal valeur)
        {
            montant = montant - valeur;
        }

        public Portefeuille(Personne proprio, decimal montant)
        {
            Proprio = proprio;
            Montant = montant;
        }
        public void Transac(Portefeuille autre, decimal valeur, TypeTransaction type)
        {
           if (type== TypeTransaction.credit)
            {
                TransacCredit(autre, valeur);
            }
            if (type == TypeTransaction.debit)
            {
                TransacDebit(autre, valeur);
            }
        }
        public void TransacDebit(Portefeuille autre, decimal valeur)
        {
            autre.crediter(valeur);
            this.debiter(valeur);
        }
        public void TransacCredit(Portefeuille autre, decimal valeur)
        {
            autre.debiter(valeur);
            this.crediter(valeur);
        }
    }
    public enum TypeTransaction
    {
        credit,
        debit
    }
}
