using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_SAE
{
    public class MatierePremiere
    {
        private string nom;
        private double poidsTotal;
        private Dictionary<string,double> sousProduits = new Dictionary<string, double>();

        public MatierePremiere(string nom, double poidsTotal, Dictionary<string, double> sousProduits)
        {
            this.Nom = nom;
            this.PoidsTotal = poidsTotal;
            this.SousProduits = sousProduits;
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public double PoidsTotal
        {
            get
            {
                return poidsTotal;
            }

            set
            {
                poidsTotal = value;
            }
        }

        public Dictionary<string, double> SousProduits
        {
            get
            {
                return this.sousProduits;
            }

            set
            {
                this.sousProduits = value;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is MatierePremiere premiere &&
                   this.Nom == premiere.Nom;
        }
    }
}
