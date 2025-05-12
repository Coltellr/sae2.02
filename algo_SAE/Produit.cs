using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_SAE
{
    public enum TypeCommande
    {
        Express,
        Normale
    }
    public class Produit
    {
        private string nom;
        private TypeCommande type;
        private DateTime datePaiement;
        private int quantite;

        public Produit(string nom, TypeCommande type,DateTime datePaiement, int quantite)
        {
            this.Nom = nom;
            this.Type = type;
            this.DatePaiement = datePaiement;
            this.Quantite = quantite;
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }

            set
            {
                this.nom = value;
            }
        }

        public TypeCommande Type
        {
            get
            {
                return this.type;
            }
            set
            { 
                this.type = value;
            }
        }
        public DateTime DatePaiement
        {
            get
            {
                return this.datePaiement;
            }

            set
            {
                this.datePaiement = value;
            }
        }

        public int Quantite
        {
            get
            {
                return this.quantite;
            }

            set
            {
                this.quantite = value;
            }
        }

        public double Prix
        {
            get
            {
                return 0; // A FAIRE, PROPRIETE CALCULEE
            }
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override string? ToString()
        {
            return $"Nom produit : {this.Nom}\nType de commande : {this.type}\nDate de paiement : {this.DatePaiement}\nQuantite : {this.Quantite}\nPrix : {this.Prix}";
        }
    }
}
