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
        private MatierePremiere matiere;
        private TypeCommande type;
        private DateTime datePaiement;
        private int quantite;
    
        public Produit(MatierePremiere matiere, TypeCommande type,DateTime datePaiement, int quantite)
        {
            this.matiere = matiere;
            this.Type = type;
            this.DatePaiement = datePaiement;
            this.Quantite = quantite;
        }

        public MatierePremiere Matiere
        {
            get
            {
                return this.matiere;
            }

            set
            {
                this.matiere = value;
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
                double prix = this.matiere.Prix*this.Matiere.PoidsTotal;
                if (this.type == TypeCommande.Normale)
                {
                    
                }
                return prix; 
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Produit produit &&
                   this.Matiere == produit.Matiere;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Matiere);
        }

        public override string? ToString()
        {
            return $"Nom produit : {this.Matiere}\nType de commande : {this.type}\nDate de paiement : {this.DatePaiement}\nQuantite : {this.Quantite}\nPrix : {this.Prix}";
        }

        public static bool operator ==(Produit? left, Produit? right)
        {
            return EqualityComparer<Produit>.Default.Equals(left, right);
        }

        public static bool operator !=(Produit? left, Produit? right)
        {
            return !(left == right);
        }
    }
}
