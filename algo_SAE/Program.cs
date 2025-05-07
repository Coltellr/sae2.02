namespace algo_SAE
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public void AfficheMenu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("BIENVENUE SUR LE SIMULATEUR DE COMMANDE");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("0. Quitter");
            Console.WriteLine("1. Passer une commande");
            Console.WriteLine("2. Voir anciennes commandes");
        }

        private static int SaisieInt(int min, int max)
        {
            int nb = 0; bool ok;
            String choix = Console.ReadLine();
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
