using Newtonsoft.Json;
using System.Security.Cryptography;

namespace algo_SAE
{
    internal class Program
    {
        static int NOMBRE_MACHINE = 35;
        static void Main(string[] args)
        {
            ChargeEntreprise();
            AfficheMenu();
        }


        public static void AfficheMenu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("BIENVENUE SUR LE SIMULATEUR DE COMMANDE");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("0. Quitter");
            Console.WriteLine("1. Optimiser la production");
            Console.WriteLine("2. Voir anciennes commandes");
            int choix = SaisieInt(0, 2);
            switch (choix)
            {
                case 0:
                    break;
                case 1:

                    break;
                case 2:
                    //A FAIRE 1: Afficher les commandes + possibilité de voir le détail
                    break;
            }
        }

        public static void ChargeMatieresPremieres()
        {
            MatierePremiere porc = new MatierePremiere("porc", 100, new Dictionary<string, double> { { "muscles", 15 }, { "chair porc", 62 } });
            MatierePremiere poulet = new MatierePremiere("poulet", 2, new Dictionary<string, double> { { "cuisse", 0.64 }, { "chair poulet", 0.62 } });
            MatierePremiere canard = new MatierePremiere("canard", 3, new Dictionary<string, double> { { "poitrail", 0.42 }, { "chair canard", 1.62 } });
            MatierePremiere bobineFer = new MatierePremiere("bobine de fer", 60, new Dictionary<string, double> { { "fer", 60 } });
            MatierePremiere bobinePlastique = new MatierePremiere("plastique", 50, new Dictionary<string, double> { { "plastique", 50 } });
        }

        public static void ChargerMachines()
        {
            List<Machine> machines = new List<Machine>();

            machines.Add(new Machine("Découpe",10 ,275000, 4000, new Dictionary<string, double> { { "porc", 60000 }, { "poulet", 45000 }, { "canard", 45000 } }, 2));
            machines.Add(new Machine("Broyage/Mixage", 5, 295000, 3000, new Dictionary<string, double> { { " pate de porc", 75000 }, { "terrine de volaille", 75000 }, { "mousse de canard", 75000 } }, 1));
            machines.Add(new Machine("Cuisson", 5, 335000, 8000, new Dictionary<string, double> { {"tranches de jambon", 32750},{ "pate de porc", 54000 }, { "terrine de volaille", 45000 }, { "mousse de canard", 100000 } }, 1));
            machines.Add(new Machine("Emballage", 5, 505000, 7500, new Dictionary<string, double> { {"cuisses de poulet", 40000 }, {"tranches de jambon", 40000 },{ "pate de porc", 40000 }, { "terrine de volaille", 40000 }, { "mousse de canard", 40000 } }, 1));
        }

        public static void ChargeEntreprise()
        {
            List<Employe> employeList = new List<Employe>();

            employeList.Add(new Employe("AgentMaitrise", 10, 2100.00));
            employeList.Add(new Employe("CadreMoyen", 5, 3600.00));
            employeList.Add(new Employe("Commercial", 5, 1000.00));
            employeList.Add(new Employe("Employe", 5, 1800.00));
            employeList.Add(new Employe("Ouvrier", 50, 1600.00));
            employeList.Add(new Employe("AssistantCommercial", 1, 1700.00));
            employeList.Add(new Employe("Dirigeant", 1, 18000.00));

            

            Banque banque = new Banque(new Dette(125000.00), new Disponibilites(5374382.32, 50250.31, 579400.00, 78340.17));
        }

        public static void ChargeProduitFinit()
        {
            ProduitFini cuiseDePoulet = new ProduitFini("Cuise De Poulet",0.512,5.30,new Dictionary<string, double>{ { "cuisse", 0.512 }, { "plastique", 0.064} });
            ProduitFini trancheDeJambon = new ProduitFini("Tranches de Jambon", 0.180, 3.90,new Dictionary<string, double>{ { "muscle", 0.180 }, { "plastique", 0.073} });
            ProduitFini pateDePorc = new ProduitFini("Pâté de porc", 0.098, 2.10,new Dictionary<string, double>{ { "chair de porc", 0.94 }, { "fer", 0.30} });
            ProduitFini terineDeVolaile = new ProduitFini("Terrine de volaille", 0.156, 3.20,new Dictionary<string, double>{ { "chair de porc", 0.101 }, { "chair de poulet", 0.30 }, { "chair de canard", 0.20 }, { "fer", 0.080} });
            ProduitFini mouseDeCanard = new ProduitFini("Mousse de canard", 0.180, 4.35,new Dictionary<string, double> { { "chair de porc", 0.080 }, { "poitrail de canard", 0.045 }, { "chair de canard", 0.040}, { "plastique", 0.056} });
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

    }   
}
