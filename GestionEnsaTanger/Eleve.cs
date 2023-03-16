using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace GestionEnsaTanger
{
    class Eleve : Model
    {
        private string Code, Nom, Prenom, Niveau, Code_fil;
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
        public string code_fil
        {
            get { return Code_fil; }
            set
            {
                Code_fil = value;
            }
        }

        public Boolean Ajouter(string code, string nom, string prenom, string niveau, string code_Fil)
        {
            Code = code;
            Nom = nom;
            Prenom = prenom;
            Niveau = niveau;
            Code_fil = code_Fil;
            int i = save();
            if (i != -1 && i !=-2)
                return true;
            return false;
        }

        // can't modify the code
        public Boolean Modifier(string code, string nom, string prenom, string niveau, string code_Fil)
        {
            Eleve e = new Eleve
            {
                Code = code
            };
            List<object> eleve = Select(ObjectToDictionary<object>(e));
            if(eleve.Count > 0)
            {
                id = ((Eleve)eleve[0]).id;
                Code = code;
                Nom = nom;
                Prenom = prenom;
                Niveau = niveau;
                Code_fil = code_Fil;
            }
            int i = save();
            if (i != -1 && i != -2)
                return true;
            return false;
        }
        public Boolean Supprimer(string code)
        {
            Eleve e = new Eleve
            {
                Code = code
            };
            List<object> eleve = Select(ObjectToDictionary<object>(e));
            if (eleve.Count > 0)
            {
                id = ((Eleve)eleve[0]).id;
            }
            int i = delete();
            if (i != 0 && i != -1)
                return true;
            return false;
        }

        // remplissage des attributes ce fait dans GestionEleve
        public List<Eleve> Rechercher()
        {
            List<Eleve> eleves = new List<Eleve>();
            Dictionary<string, object> dico = ObjectToDictionary<object>(this);
            List<object> data = Select(dico);
            foreach (var item in data)
            {
                eleves.Add((Eleve)item);
            }
            return eleves;
        }
        private void Initialize(Eleve eleve)
        {
            Code = eleve.Code;
            Nom = eleve.Nom;
            Prenom = eleve.Prenom;
            Niveau = eleve.Niveau;
            Code_fil = eleve.Code_fil;
        }
        public override string ToString()
        {
            return base.ToString()+" nom: "+Nom+" code: "+Code+" Filiere : "+Code_fil;
        }
    }
}
