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

            Eleve e1 = new Eleve("Hachguer", "Mohamed", "GINF2", "GI2");
            //e1.save();
            /*Dictionary<string, string> Champs = new Dictionary<string, string>();
            Champs.Add("nom", "Hachguer");
            Champs.Add("prenom", "Mohamed");
            Champs.Add("niveau", "GINF2");
            Champs.Add("code_Fil", "GI2");*/
            
            
        }
    }
}
