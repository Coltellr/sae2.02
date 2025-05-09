using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_SAE
{
    public class Banque
    {
        private Dette dette;
        private Disponibilites disponibilites;

        public Banque(Dette dette, Disponibilites disponibilites)
        {
            this.Dette = dette;
            this.Disponibilites = disponibilites;
        }

        public Dette Dette
        {
            get
            {
                return this.dette;
            }

            set
            {
                this.dette = value;
            }
        }

        public Disponibilites Disponibilites
        {
            get
            {
                return this.disponibilites;
            }

            set
            {
                this.disponibilites = value;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Banque banque &&
                   EqualityComparer<Dette>.Default.Equals(this.Dette, banque.Dette) &&
                   EqualityComparer<Disponibilites>.Default.Equals(this.Disponibilites, banque.Disponibilites);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Dette, this.Disponibilites);
        }

        public override string? ToString()
        {
            return $"Disponibilité {this.disponibilites}\nDete {this.dette}";
        }

        public static bool operator ==(Banque? left, Banque? right)
        {
            return EqualityComparer<Banque>.Default.Equals(left, right);
        }

        public static bool operator !=(Banque? left, Banque? right)
        {
            return !(left == right);
        }
    }
}
