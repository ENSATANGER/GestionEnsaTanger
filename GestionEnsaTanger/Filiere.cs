using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace GestionEnsaTanger
{
    internal class Filiere : Model
    {
        string Code;
        string designation;

        public string code {
            get { return Code; } 
            set { Code = value; } 
        }

        public Filiere() { }
        public Filiere(string code, string designation)
        {
            id = 0;
            this.code = code;
            this.designation = designation;
        }

        public override string ToString()
        {
            return "ID: " + id + " Code: " + code + " Designation: " + designation;
        }
    }
}
