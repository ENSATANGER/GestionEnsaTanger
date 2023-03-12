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
        public Eleve() { }
        public Eleve(string nom, string prenom, string niveau, string code_Fil)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.niveau = niveau;
            this.code_Fil = code_Fil;
        }
        public Boolean Create()
        {
            if (save() != -1)
                return true;
            return false;
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
