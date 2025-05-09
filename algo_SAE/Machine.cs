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
        private double cout;
        public Machine() 
        {  
        }

        public Machine(string nom, int qte, double cout)
        {
            this.Nom = nom;
            this.Qte = qte;
            this.Cout = cout;
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

        public double Cout
        {
            get
            {
                return this.cout;
            }

            set
            {
                this.cout = value;
            }
        }
        
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override string? ToString()
        {
            return $"Nom Machine : {this.Nom}\nQuantite de Machines : {this.Qte} unité(s)\nCout Achat Machine : {this.Cout}\n";
        }
    }
}
