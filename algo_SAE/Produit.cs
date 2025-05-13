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
        private static readonly Dictionary<string, (double prixVente, double coutMP, double coutMachine)> DonneesProduitUnites =
            new Dictionary<string, (double, double, double)>()
            {
                { "Cuisses de poulet", (8.5, 3.2, 1.5) },
                { "Tranches de jambon", (9.0, 3.5, 1.2) },
                { "Pâté de porc", (7.0, 2.8, 1.0) },
                { "Terrines de volaille", (8.0, 3.0, 1.3) },
                { "Mousse de canard", (8.8, 3.4, 1.4) }
            };
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
            return obj is Produit produit &&
                   this.Nom == produit.Nom;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Nom);
        }

        public override string? ToString()
        {
            return $"Nom produit : {this.Nom}\nType de commande : {this.type}\nDate de paiement : {this.DatePaiement}\nQuantite : {this.Quantite}\nPrix : {this.Prix}";
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
