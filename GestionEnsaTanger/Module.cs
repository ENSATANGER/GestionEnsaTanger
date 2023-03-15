using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace GestionEnsaTanger
{
    internal class Module : Model
    {
        private string Code, Designation, Niveau, Semestre, Code_fil;

        public Module() { }
        
        public string code
        {
            get { return code; }
            set { code = value; }
        }

        public string designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public string niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }

        public string semestre
        {
            get { return semestre;}
            set { semestre = value; }
        }

        public string code_fil
        {
            get { return code_fil; }
            set { code_fil = value; }
        }
    }
}
