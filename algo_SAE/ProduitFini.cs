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
        private List<MatierePremiere> lesMP = new List<MatierePremiere>();
        private double poidsNet;
        private double prixVente;

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

        public List<MatierePremiere> LesMP
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
