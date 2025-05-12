using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_SAE
{
    public class Employe
    {
        private string emploi;
        private int nombre;
        private double salaire;

        public Employe(string emploi, int nombre, double salaire)
        {
            this.Emploi = emploi;
            this.Nombre = nombre;
            this.Salaire = salaire;
        }

        public string Emploi
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
            return obj is Employe employe &&
                   this.Emploi == employe.Emploi &&
                   this.Nombre == employe.Nombre &&
                   this.Salaire == employe.Salaire;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Emploi, this.Nombre, this.Salaire);
        }

        public override string? ToString()
        {
            return $"Emploi : {this.emploi}\nNombre {this.nombre}\nSalaire {this.salaire}";
        }

        public static bool operator ==(Employe? left, Employe? right)
        {
            return EqualityComparer<Employe>.Default.Equals(left, right);
        }

        public static bool operator !=(Employe? left, Employe? right)
        {
            return !(left == right);
        }
    }
}
