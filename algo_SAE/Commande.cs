using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_SAE
{
    public class Commande
    {
        private string moisDeCommande;
        private List<Produit> lesProduits;

        public Commande(string moisDeCommande, List<Produit> lesProduits)
        {
            this.MoisDeCommande = moisDeCommande;
            this.LesProduits = lesProduits;
        }

        public List<Produit> LesProduits
        {
            get
            {
                return this.lesProduits;
            }

            set
            {
                this.lesProduits = value;
            }
        }

        public string MoisDeCommande
        {
            get
            {
                return this.moisDeCommande;
            }

            set
            {
                this.moisDeCommande = value;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Commande commande &&
                   this.MoisDeCommande == commande.MoisDeCommande;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.MoisDeCommande);
        }

        public override string? ToString()
        {
            string result = $"Commande du mois : {this.MoisDeCommande}\n";
            foreach (Produit produit in this.LesProduits)
            {
                result += produit + "\n";
            }
            return result;
        }

        public static bool operator ==(Commande? left, Commande? right)
        {
            return EqualityComparer<Commande>.Default.Equals(left, right);
        }

        public static bool operator !=(Commande? left, Commande? right)
        {
            return !(left == right);
        }
    }
}
