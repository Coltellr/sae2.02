using Newtonsoft.Json;
using System.Security.Cryptography;

namespace algo_SAE
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Employe> employeList=new List<Employe>();

            employeList.Add(new Employe("AgentMaitrise", 11, 2100.00));
            employeList.Add(new Employe("CadreMoyen", 11, 3600.00));
            employeList.Add(new Employe("Commercial", 11, 1000.00));
            employeList.Add(new Employe("Employe", 11, 1800.00));
            employeList.Add(new Employe("Ouvrier", 11, 1600.00));
            employeList.Add(new Employe("AssistantCommercial", 11, 1700.00));
            employeList.Add(new Employe("Dirigeant", 11, 18000.00));

            List<Machine> machines = new List<Machine>();

            machines.Add(new Machine("Decoupe",6,1650000.00));
            machines.Add(new Machine("Broyage",4,1180000.00));
            machines.Add(new Machine("Cuisson",6,2010000.00));
            machines.Add(new Machine("Emballage", 7, 3535000.00));

            Banque banque = new Banque(new Dette(125000.00), new Disponibilites(5374382.32, 50250.31, 579400.00, 78340.17));

            AfficheMenu();
        }


        public static void AfficheMenu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("BIENVENUE SUR LE SIMULATEUR DE COMMANDE");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("0. Quitter");
            Console.WriteLine("1. Passer une commande");
            Console.WriteLine("2. Voir anciennes commandes");
            int choix = SaisieInt(0, 2);
            switch (choix)
            {
                case 0:
                    break;
                case 1:
                    //A FAIRE 1: PASSAGE DE COMMANDE
                    break;
                case 2:
                    //A FAIRE 1: Afficher les commandes + possibilité de voir le détail
                    break;
            }
        }

        private static int SaisieInt(int min, int max)
        {
            int nb = 0; bool ok;
            Console.WriteLine($"Choisissez un nombre entre {min} et {max}");
            string choix = Console.ReadLine();
            do
            {
                ok = true;
                if (!(int.TryParse(choix, out nb) && nb >= min && nb <= max))
                {
                    Console.WriteLine($"Erreur- Choix entre {min} et {max} :");
                    choix = Console.ReadLine();
                    ok = false;
                }
            } while (!ok);
            return nb;
        }

        public void CoutMensuelFix()
        {

        }


        /*public int CalculeNbBDecoupeuses()
        {
        }



        public int CalculeNbBroyeuses()
        {
        }



        public int CalculeNbEmballeuses()
        {
        }



        public int CalculeNbCuiseurs()
        {
        }*/

    }   
}
