using Newtonsoft.Json;
using System.Security.Cryptography;

namespace algo_SAE
{
    internal class Program
    {
        private static readonly string pathMachines = AppDomain.CurrentDomain.BaseDirectory + "\\data\\Machines.csv";
        private static readonly string pathEmployes = AppDomain.CurrentDomain.BaseDirectory + "\\data\\Employes.csv";
        private static readonly string pathBanque = AppDomain.CurrentDomain.BaseDirectory + "\\data\\Banque.csv";
        


        static void Main(string[] args)
        {

            // Lire tout le contenu du fichier CSV
            List<Machine> machines = new List<Machine>();
            List<Employe> employes = new List<Employe>();
            List<Banque> Banque = new List<Banque>();

            try
            {
                // Lire chaque ligne du fichier CSV
                List<String[]> lesLignes = new List<String[]>();
                lesLignes.Append(File.ReadAllLines(pathMachines));
                lesLignes.Append(File.ReadAllLines(pathEmployes));
                lesLignes.Append(File.ReadAllLines(pathBanque));

                // Sauter la première ligne qui contient les en-têtes
                    for (int i = 1; i < lesLignes[0].Length; i++)
                    {
                        String line = lesLignes[0][i];

                        // Séparer chaque ligne par la virgule
                        String[] values = line.Split(';');

                        // Créer un nouvel objet Machine et l'ajouter à la liste
                        Machine machine = new Machine
                        {
                            Nom = values[0],
                            Qte = int.Parse(values[1]),
                            Cout = double.Parse(values[2])
                        };

                        machines.Add(machine);
                    }
                    for (int i = 1; i < lesLignes[1].Length; i++)
                    {
                        String line = lesLignes[1][i];

                        // Séparer chaque ligne par la virgule
                        String[] values = line.Split(';');

                    // Créer un nouvel objet Machine et l'ajouter à la liste
                    Employe employe = new Employe(values[0], int.Parse(values[1]), double.Parse(values[2]));

                        employes.Add(employe);
                    }
                    for (int i = 1; i < lesLignes[2].Length; i++)
                    {
                        String line = lesLignes[2][i];

                        // Séparer chaque ligne par la virgule
                        String[] values = line.Split(';');

                        // Créer un nouvel objet Machine et l'ajouter à la liste
                        Banque banque = new Banque()

                        Banque.Add(banque);
                    }

                // Afficher les données extraites
                foreach (var machine in machines)
                {
                    Console.WriteLine($"Nom: {machine.Nom}, Qte: {machine.Qte}, Cout: {machine.Cout}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la lecture du fichier : {ex.Message}");
            }

        }
        
        //AfficheMenu();





        public static List<String> extractCSVfile(String pathdata)
        {
            List<String> maListe = new List<String>();
            try
            {
                StreamReader reader = new StreamReader(pathdata);
                // ou StreamReader reader = new StreamReader(pathData, System.Text.Encoding.UTF8);
                while (!reader.EndOfStream) // reader.EndOfStream == false
                {
                    String? unElement = reader.ReadLine();
                    if (!String.IsNullOrWhiteSpace(unElement))
                        maListe.Add(unElement);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Probleme avec le fichier \n" + e);
                Environment.Exit(2);
            }
            return maListe;
        }

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
