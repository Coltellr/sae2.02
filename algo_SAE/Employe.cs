using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_SAE
{
    public enum Emploi {AgentMaitrise , CadreMoyen, Commercial, Employe, Ouvrier, AssistantCommercial, Dirigeant }
    public class Employe
    {
        private Emploi emploi;
        private int nombre;
        private double salaire;

        public Employe(Emploi emploi, int nombre, double salaire)
        {
            this.Emploi = emploi;
            this.Nombre = nombre;
            this.Salaire = salaire;
        }

        public Emploi Emploi
        {
            get
            {
                return this.emploi;
            }

            set
            {
                this.emploi = value;
            }
        }

        public int Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }

        public double Salaire
        {
            get
            {
                return this.salaire;
            }

            set
            {
                this.salaire = value;
            }
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return $"Emploi : {Emploi}\nNombre {Nombre}\nSalaire {Salaire}";
        }
    }
}
