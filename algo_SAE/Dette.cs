using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_SAE
{
    public class Dette
    {
        private double empruntBancaire;

        public Dette(double empruntBancaire)
        {
            this.EmpruntBancaire = empruntBancaire;
        }

        public double EmpruntBancaire
        {
            get
            {
                return this.empruntBancaire;
            }

            set
            {
                this.empruntBancaire = value;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Dette dette &&
                   this.EmpruntBancaire == dette.EmpruntBancaire;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.EmpruntBancaire);
        }

        public override string? ToString()
        {
            return $"Emprunt : {this.empruntBancaire}";
        }

        public static bool operator ==(Dette? left, Dette? right)
        {
            return EqualityComparer<Dette>.Default.Equals(left, right);
        }

        public static bool operator !=(Dette? left, Dette? right)
        {
            return !(left == right);
        }
    }
}
