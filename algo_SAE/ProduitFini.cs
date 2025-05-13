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

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
