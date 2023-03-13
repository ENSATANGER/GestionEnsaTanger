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
        /*private string code, nom, prenom, niveau, code_Fil;*/
        private string Code, Nom, Prenom, Niveau, Code_Fil;
        public Eleve() { }
        public string code
        {
            get { return Code; }
            set { Code = value; }
        }
        public string nom
        {
            get { return Nom; }
            set { Nom = value; }
        }
        public string prenom
        {
            get { return Prenom; }
            set { Prenom = value; }
        }
        public string niveau
        {
            get { return Niveau; }
            set
            {
                Niveau = value;
            }
        }
        public string code_Fil
        {
            get { return Code_Fil; }
            set
            {
                Code_Fil = value;
            }
        }
        /*public string Code
        {
            get { return code; }
        }
        public string Nom
        {
            get { return nom; }
        }
        public string Prenom
        {
            get { return prenom; }
        }
        public string Niveau
        {
            get { return niveau; }
        }
        public string Code_Fil
        {
            get { return code_Fil; }
        }*/

        public Boolean Create()
        {
            if (save() != -1)
                return true;
            return false;
        }
        public void show()
        {
            find();
        }

        public override string ToString()
        {
            return "id: "+id+" nom: "+Nom+" code: "+Code;
        }
    }
}
