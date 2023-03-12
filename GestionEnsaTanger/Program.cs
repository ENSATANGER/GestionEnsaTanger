using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace GestionEnsaTanger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new MDI().ShowDialog();

            /*Etudiant e1 = new Etudiant("AA", "Hachguer", "Mohamed", "GINF2", "GI2");
            //e1.save();
            Dictionary<string, string> Champs;
            Champs = Connexion.getChamps_table("Eleve");
            foreach (KeyValuePair<string, string> kvp in Champs)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }*/
        }
    }
}
