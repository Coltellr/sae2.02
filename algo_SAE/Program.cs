using Newtonsoft.Json;
using System.Security.Cryptography;

namespace algo_SAE
{
    internal class Program
    {
        static int NOMBRE_MACHINES_MAXIMUM = 35;
        static MatierePremiere porc, poulet, canard, bobineFer, bobinePlastique;
        static ProduitFini cuisseDePoulet, trancheDeJambon, pateDePorc, terrineDeVolaile, mousseDeCanard;
        static List<Machine> machines;
        static List<Employe> employeList;
        static Banque banque;
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
                    CalculProduction();
                    break;
                case 2:
                    //A FAIRE 1: Afficher les commandes + possibilité de voir le détail
                    break;
            }
        }

        public static void CalculProduction()
        {
            Dictionary<string, double> marchandises = new Dictionary<string, double> {
                { "Mousse Canard", 0 }, { "Terrine de vollaile", 0 }, { "Cuisse de poulet", 0 }, { "Paté de porc", 0 }, { "Jambon", 0 },
                { "Poitrail",0 }, {"Chair Canard",0}, {"Cuisse", 0}, {"Chair de poulet", 0}, {"Chair de porc",0} ,{"Muscle",0},
                {"Canard",0 }, {"Poulet",0}, {"Porc",0}, {"Bobine de Fer",0}, {"Bobine de Plastique",0}
            };
            Console.WriteLine("Entrez le nombre de mousses");
            marchandises["Mousse Canard"] = SaisieInt(0, 0);
            double temp = marchandises["Mousse Canard"] * 
            Console.WriteLine(""
        }

        public static void ChargeMatieresPremieres()
        {
            double prix = SaisieDouble("porc");
            porc = new MatierePremiere("porc", 100, new Dictionary<string, double> { { "muscles", 15 }, { "chair porc", 62 } }, prix);
            prix = SaisieDouble("poulet");
            poulet = new MatierePremiere("poulet", 2, new Dictionary<string, double> { { "cuisse", 0.64 }, { "chair poulet", 0.62 } }, prix);
            prix = SaisieDouble("canard");
            canard = new MatierePremiere("canard", 3, new Dictionary<string, double> { { "poitrail", 0.42 }, { "chair canard", 1.62 } }, prix);
            prix = SaisieDouble("bobine de fer");
            bobineFer = new MatierePremiere("bobine de fer", 60, new Dictionary<string, double> { { "fer", 60 } }, prix);
            prix = SaisieDouble("plastique");
            bobinePlastique = new MatierePremiere("plastique", 50, new Dictionary<string, double> { { "plastique", 50 } }, prix);
        }
        public static void ChargeProduitFini()
        {

            cuisseDePoulet = new ProduitFini("Cuisse De Poulet", 0.512, 5.30, new Dictionary<string, double> { { "cuisse", 0.512 }, { "plastique", 0.064 } });
            trancheDeJambon = new ProduitFini("Tranches de Jambon", 0.180, 3.90, new Dictionary<string, double> { { "muscle", 0.180 }, { "plastique", 0.073 } });
            pateDePorc = new ProduitFini("Paté de porc", 0.098, 2.10, new Dictionary<string, double> { { "chair de porc", 0.94 }, { "fer", 0.30 } });
            terrineDeVolaile = new ProduitFini("Terrine de volaille", 0.156, 3.20, new Dictionary<string, double> { { "chair de porc", 0.101 }, { "chair de poulet", 0.30 }, { "chair de canard", 0.20 }, { "fer", 0.080 } });
            mousseDeCanard = new ProduitFini("Mousse de canard", 0.180, 4.35, new Dictionary<string, double> { { "chair de porc", 0.080 }, { "poitrail de canard", 0.045 }, { "chair de canard", 0.040 }, { "plastique", 0.056 } });
        }
        public static void ChargeMachines()
        {
            machines = new List<Machine>();

            machines.Add(new Machine("Découpe", 10, 275000, 4000, new Dictionary<string, double> { { "porc", 60000 }, { "poulet", 45000 }, { "canard", 45000 } }, 2));
            machines.Add(new Machine("Broyage/Mixage", 5, 295000, 3000, new Dictionary<string, double> { { " pate de porc", 75000 }, { "terrine de volaille", 75000 }, { "mousse de canard", 75000 } }, 1));
            machines.Add(new Machine("Cuisson", 5, 335000, 8000, new Dictionary<string, double> { { "tranches de jambon", 32750 }, { "pate de porc", 54000 }, { "terrine de volaille", 45000 }, { "mousse de canard", 100000 } }, 1));
            machines.Add(new Machine("Emballage", 5, 505000, 7500, new Dictionary<string, double> { { "cuisses de poulet", 40000 }, { "tranches de jambon", 40000 }, { "pate de porc", 40000 }, { "terrine de volaille", 40000 }, { "mousse de canard", 40000 } }, 1));
        }

        public static void ChargeEmployes()
        {
             employeList = new List<Employe>();

            employeList.Add(new Employe("AgentMaitrise", 10, 2100.00));
            employeList.Add(new Employe("CadreMoyen", 5, 3600.00));
            employeList.Add(new Employe("Commercial", 5, 1000.00));
            employeList.Add(new Employe("Employe", 5, 1800.00));
            employeList.Add(new Employe("Ouvrier", 50, 1600.00));
            employeList.Add(new Employe("AssistantCommercial", 1, 1700.00));
            employeList.Add(new Employe("Dirigeant", 1, 18000.00));
        }

        public static void ChargeBanque()
        {
            banque = new Banque(new Dette(125000.00), new Disponibilites(5374382.32, 50250.31, 579400.00, 78340.17));
        }
        public static void ChargeEntreprise()
        {
            ChargeMatieresPremieres();
            ChargeProduitFini();
            ChargeMachines();
            ChargeEmployes();
            ChargeBanque();
        }

        private static int SaisieInt(int min, int max)
        {
            int nb = 0; bool ok;
            if (max>0)
            {
                Console.WriteLine($"Choisissez un nombre entre {min} et {max}");
            }
            string choix = Console.ReadLine();
            do
            {
                ok = true;
                if (!(int.TryParse(choix, out nb) && nb >= min && (nb <= max || max==0)))
                {
                    if(max>0)
                    {
                        Console.WriteLine($"Erreur- Choix entre {min} et {max} :");
                    }
                    else
                    {
                        Console.WriteLine("Saisir un entier");
                    }
                    choix = Console.ReadLine();
                    ok = false;
                }
            } while (!ok);
            return nb;
        }
        private static double SaisieDouble()
        {
            double nb = 0 ; bool ok;
            Console.WriteLine("Veuillez rentrer un double");
            ok=double.TryParse(Console.ReadLine(), out nb);
            while (!ok)
            {
                Console.WriteLine("Erreur! Veuillez rentrer un double");
                ok = double.TryParse(Console.ReadLine(), out nb);
            }
            return nb;
        }
        private static double SaisieDouble(String matiere)
        {
            double nb = 0; bool ok;
            Console.WriteLine($"Veuillez rentrer le prix des {matiere}");
            ok = double.TryParse(Console.ReadLine(), out nb);
            while (!ok)
            {
                Console.WriteLine($"Erreur! Veuillez rentrer le prix des {matiere}");
                ok = double.TryParse(Console.ReadLine(), out nb);
            }
            return nb;
        }
    }   
}
