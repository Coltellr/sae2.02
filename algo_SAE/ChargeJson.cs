using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_SAE
{
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
}
