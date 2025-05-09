using Newtonsoft.Json;

namespace algo_SAE
{
    internal class Program
    {
        private static readonly string pathMachines = AppDomain.CurrentDomain.BaseDirectory + "\\data\\Machines.json";
        static void Main(string[] args)
        {
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

        public class ChargeJson
        {
            public static Dictionary<T, double> ChargeDictionary<T>(String pathName)
            {
                Dictionary<T, double> liste = null;
                try
                {
                    String contenuFichier = File.ReadAllText(pathName);
                    liste = JsonConvert.DeserializeObject<Dictionary<T, double>>(contenuFichier);
                }
                catch (Exception) { throw; }
                return liste;
            }
            public static List<T> ChargeList<T>(String pathName)
            {
                List<T> liste = null;
                try
                {
                    String contenuFichier = File.ReadAllText(pathName);
                    liste = JsonConvert.DeserializeObject<List<T>>(contenuFichier);
                }
                catch (Exception) { throw; }
                return liste;
            }
            public static void SauvegardeList<T>(List<T> liste, String pathName)
            {
                try
                {
                    string result = JsonConvert.SerializeObject(liste, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(pathName, result);
                }
                catch (Exception) { throw; }
            }
        }

        public void CoutMensuelFix()
        {
            
        }

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
}
