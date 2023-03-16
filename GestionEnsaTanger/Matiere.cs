using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace GestionEnsaTanger
{
    internal class Matiere : Model
    {
        string Code, Designation, Code_module;
        Double vh;

        public Matiere() { }
        
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

        public string code_module
        {
            get { return Code_module; }
            set { Code_module = value; }
        }

        public Double VH
        {
            get { return vh; }
            set{ vh = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "code: " + code;
        }

    }
}
