using Newtonsoft.Json;
using System.Security.Cryptography;

namespace algo_SAE
{
    internal class Program
    {
        private static readonly string pathMachines = AppDomain.CurrentDomain.BaseDirectory + "\\data\\Machines.csv";
        private static readonly string pathEmployes = AppDomain.CurrentDomain.BaseDirectory + "\\data\\Employes.json";
        private static readonly string pathBanque = AppDomain.CurrentDomain.BaseDirectory + "\\data\\Banque.json";
        


        static void Main(string[] args)
        {

            // Lire tout le contenu du fichier CSV
            List<Machine> machines = new List<Machine>();

            try
            {
                // Lire chaque ligne du fichier CSV
                var lines = File.ReadAllLines(pathMachines);

                // Sauter la première ligne qui contient les en-têtes
                for (int i = 1; i < lines.Length; i++)
                {
                    var line = lines[i];

                    // Séparer chaque ligne par la virgule
                    var values = line.Split(';');

                    // Créer un nouvel objet Machine et l'ajouter à la liste
                    Machine machine = new Machine
                    {
                        Nom = values[0],
                        Qte = int.Parse(values[1]),
                        Cout = double.Parse(values[2])
                    };

                    machines.Add(machine);
                }

                // Afficher les données extraites
                foreach (Machine machine in machines)
                {
                    Console.WriteLine($"Nom: {machine.Nom}, Qte: {machine.Qte}, Cout: {machine.Cout}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la lecture du fichier : {ex.Message}");
            }
        }
        /*List<Employe> employes = ChargeJson.ChargeList<Employe>(pathEmployes);
        Entreprise e25 = new Entreprise(employes);
            Console.WriteLine(e25);*/
            //AfficheMenu();
            
        }

       /* public static void AfficheMenu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("BIENVENUE SUR LE SIMULATEUR DE COMMANDE");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("0. Quitter");
            Console.WriteLine("1. Passer une commande");
            Console.WriteLine("2. Voir anciennes commandes");
            int choix = SaisieInt(0, 2);
            switch(choix)
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
            
        }*/

        /*
        public int CalculeNbBDecoupeuses()
        {
        }
        */

        /*
        public int CalculeNbBroyeuses() 
        { 
        }
        */

        /*
        public int CalculeNbEmballeuses()
        {
        }
        */

        /*
        public int CalculeNbCuiseurs()
        {
        }
        */
}
