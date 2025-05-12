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
            return base.Equals(obj);
        }

        public override string? ToString()
        {
            string result = "";
            foreach (Produit produit in this.LesProduits)
            {
                result += produit.ToString();
            }
            return base.ToString();
        }
    }
}
