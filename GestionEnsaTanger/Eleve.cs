using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace GestionEnsaTanger
{
    class Eleve : DB.Model
    {
        public string code, nom, prenom, niveau, code_Fil;
        public Eleve()
        {
            code = "e7";
            nom = "boulouqat";
            prenom = "jawad";
            niveau = "2";
            code_Fil = "F1";
        }
        public void Create()
        {
            if (save() != -1)
                Console.WriteLine("added");
            else
                Console.WriteLine("error");
        }
        public void show()
        {
            if (find() != null)
                Console.WriteLine("found");
            else
                Console.WriteLine("error");
        }
    }
}
