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
        private Dictionary<string, double> lesMP = new Dictionary<string, double>();
        private double poidsNet;
        private double prixVente;

        public ProduitFini(string nom, double poidsNet, double prixVente, Dictionary<string, double> lesMP)
        {
            this.Nom = nom;
            this.PoidsNet = poidsNet;
            this.PrixVente = prixVente;
            this.LesMP = lesMP;
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
                return this.PrixVente;
            }

            set
            {
                this.PrixVente = value;
            }
        }

        public Dictionary<string, double> LesMP
        {
            get
            {
                return this.lesMP;
            }

            set
            {
                this.lesMP = value;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is ProduitFini fini &&
                   this.Nom == fini.Nom;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Nom);
        }

        public override string? ToString()
        {
            return base.ToString();
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
