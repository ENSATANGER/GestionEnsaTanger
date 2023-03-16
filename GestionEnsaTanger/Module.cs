using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEnsaTanger
{
    internal class Module: Model
    {
        private string Code, Designation, Niveau, Semestre, Code_filiere;

        public string code
        {
            get { return Code; }
            set { Code = value; }
        }
        public string designation
        {
            get { return Designation; }
            set { Designation = value; }
        }

        public string niveau
        {
            get { return Niveau; }
            set { Niveau = value; }
        }
        public string semestre
        {
            get { return Semestre; }
            set { Semestre = value; }
        }

        public string code_filiere
        {
            get { return Code_filiere; }
            set { Code_filiere = value; }
        }
    }
}
