using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_SAE
{
    public class Disponibilites
    {
        private double banque;
        private double vmp;
        private double budgetPublicite;
        private double budgetAssurance;

        public Disponibilites(double banque, double vmp, double budgetPublicité, double budgetAssurance)
        {
            this.Banque = banque;
            this.Vmp = vmp;
            this.BudgetPublicite = budgetPublicité;
            this.BudgetAssurance = budgetAssurance;
        }

        public double Banque
        {
            get
            {
                return banque;
            }

            set
            {
                banque = value;
            }
        }

        public double Vmp
        {
            get
            {
                return vmp;
            }

            set
            {
                vmp = value;
            }
        }

        public double BudgetPublicite
        {
            get
            {
                return budgetPublicite;
            }

            set
            {
                budgetPublicite = value;
            }
        }

        public double BudgetAssurance
        {
            get
            {
                return this.budgetAssurance;
            }

            set
            {
                this.budgetAssurance = value;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Disponibilites disponibilites &&
                   this.Banque == disponibilites.Banque &&
                   this.Vmp == disponibilites.Vmp &&
                   this.BudgetPublicite == disponibilites.BudgetPublicite &&
                   this.BudgetAssurance == disponibilites.BudgetAssurance;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Banque, this.Vmp, this.BudgetPublicite, this.BudgetAssurance);
        }

        public override string? ToString()
        {
            return $"Banque : {this.banque}\nVmp : {this.vmp}\nBudget Publicité : {this.budgetPublicite}\nBudget Assurance : {this.budgetAssurance}";
        }

        public static bool operator ==(Disponibilites? left, Disponibilites? right)
        {
            return EqualityComparer<Disponibilites>.Default.Equals(left, right);
        }

        public static bool operator !=(Disponibilites? left, Disponibilites? right)
        {
            return !(left == right);
        }
    }
}
