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
        private Dictionary<string,double> matieres = new Dictionary<string, double>();

        public MatierePremiere(string nom, double poidsTotal, Dictionary<string, double> matieres)
        {
            this.Nom = nom;
            this.PoidsTotal = poidsTotal;
            this.Matieres = matieres;
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

        public Dictionary<string, double> Matieres
        {
            get
            {
                return this.matieres;
            }

            set
            {
                this.matieres = value;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is MatierePremiere premiere &&
                   this.Nom == premiere.Nom;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Nom);
        }

        public override string? ToString()
        {
            return $"Nom : {this.nom}\nPoids Total {this.PoidsTotal}\nMatieres {this.Matieres}";
        }
    }
}
