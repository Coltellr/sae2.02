using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_SAE
{

    public class Entreprise
    {

        private List<Employe> employes;

        public Entreprise(List<Employe> employes)
        {
            this.Employes = employes;
        }

        public List<Employe> Employes
        {
            get
            {
                return this.employes;
            }

            set
            {
                this.employes = value;
            }
        }

        public override string? ToString()
        {
            return this.employes.ToString();
        }
    }
}
