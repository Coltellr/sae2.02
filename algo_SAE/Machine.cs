using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_SAE
{
    public class Machine
    {
        private string nom;
        private int qte;
        private double coutAchat;
        private double coutFonctionnement;
        private Dictionary<string, double> capacite = new Dictionary<string, double>();
        private int nbOuvriers;


        public Machine(string nom, int qte, double coutAchat, double coutFonctionnement, Dictionary<string, double> capacite, int nbOuvriers)
        {
            this.Nom = nom;
            this.Qte = qte;
            this.CoutAchat = coutAchat;
            this.CoutFonctionnement = coutFonctionnement;
            this.Capacite = capacite;
            this.NbOuvriers = nbOuvriers;
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

        public int Qte
        {
            get
            {
                return this.qte;
            }

            set
            {
                this.qte = value;
            }
        }

        public double CoutAchat
        {
            get
            {
                return this.coutAchat;
            }

            set
            {
                this.coutAchat = value;
            }
        }

        public double CoutFonctionnement
        {
            get
            {
                return this.coutFonctionnement;
            }

            set
            {
                this.coutFonctionnement = value;
            }
        }

        public Dictionary<string, double> Capacite
        {
            get
            {
                return this.capacite;
            }

            set
            {
                this.capacite = value;
            }
        }

        public int NbOuvriers
        {
            get
            {
                return this.nbOuvriers;
            }

            set
            {
                this.nbOuvriers = value;
            }
        }


        public static bool operator ==(Machine? left, Machine? right)
        {
            return EqualityComparer<Machine>.Default.Equals(left, right);
        }

        public static bool operator !=(Machine? left, Machine? right)
        {
            return !(left == right);
        }
    }
}
