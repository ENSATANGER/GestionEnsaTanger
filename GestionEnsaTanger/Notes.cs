using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace GestionEnsaTanger
{
    internal class Notes : Model
    {
        private string Code_eleve;
        private string Code_mat;
        private float Note;

        public Notes(string ce,string cm, float n)
        {
            Code_eleve = ce;
            Code_mat = cm;
            Note = n;
        }

        public string code_eleve
        {
            get { return Code_eleve; }
            set { Code_eleve = value; }
        }

        public string code_mat
        {
            get { return Code_mat; }
            set { Code_mat = value; }
        }

        public float note
        {
            get { return Note; }
            set { Note = value; }
        }

        public void Ajouter()
        {
             save();
        }
    }
}
