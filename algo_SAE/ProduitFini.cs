using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_SAE
{
    public class ProduitFini
    {
        private string nom;
        private Dictionary<string, double> composition = new Dictionary<string, double>();
        private double poidsNet;
        private double prixVente;

        public ProduitFini(string nom, double poidsNet, double prixVente, Dictionary<string, double> composition)
        {
            this.Nom = nom;
            this.PoidsNet = poidsNet;
            this.PrixVente = prixVente;
            this.Composition = composition;
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

        public double PoidsNet
        {
            get
            {
                return this.poidsNet;
            }

            set
            {
                this.poidsNet = value;
            }
        }

        public double PrixVente
        {
            get
            {
                return this.prixVente;
            }

            set
            {
                this.prixVente = value;
            }
        }

        public Dictionary<string, double> Composition
        {
            get
            {
                return this.composition;
            }

            set
            {
                this.composition = value;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is ProduitFini fini &&
                   this.Nom == fini.Nom;
        }

        public static bool operator ==(ProduitFini? left, ProduitFini? right)
        {
            return EqualityComparer<ProduitFini>.Default.Equals(left, right);
        }

        public static bool operator !=(ProduitFini? left, ProduitFini? right)
        {
            return !(left == right);
        }
    }
}
