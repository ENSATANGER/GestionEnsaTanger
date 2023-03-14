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
            set {Code = value;}
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

        public Boolean Ajouter(string code, string nom, string pernom, string niveau, string code_Fil)
        {
            Code = code;
            Nom = nom;
            Prenom = pernom;
            Niveau = niveau;
            Code_Fil = code_Fil;
            int i = save();
            if (i != -1 && i !=-2)
                return true;
            return false;
        }

        public Boolean Modifier(string code, string nom, string pernom, string niveau, string code_Fil)
        {

            Code = code;
            Nom = nom;
            Prenom = pernom;
            Niveau = niveau;
            Code_Fil = code_Fil;
            int i = save();
            if (i != -1 && i != -2)
                return true;
            return false;
        }
        public Boolean Supprimer()
        {
            if (delete() != 0)
                return true;
            return false;
        }
        public void Rechercher()
        {
            /*Initialize(find());*/
            Dictionary<string, object> dico = ObjectToDictionary<object>(this);
            List<object> eleves = Select(dico);
            foreach (var item in eleves)
            {
                Console.WriteLine(item.ToString());
            }
        }
        private void Initialize(Eleve eleve)
        {
            Code = eleve.Code;
            Nom = eleve.Nom;
            Prenom = eleve.Prenom;
            Niveau = eleve.Niveau;
            Code_Fil = eleve.Code_Fil;
        }
        public override string ToString()
        {
            return base.ToString()+" nom: "+Nom+" code: "+Code;
        }
    }
}
