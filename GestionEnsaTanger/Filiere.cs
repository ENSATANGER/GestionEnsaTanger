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
        private string Code, Designation;

        public string code {
            get { return Code; } 
            set { Code = value; } 
        }
        public string designation
        {
            get { return Designation; }
            set { Designation = value; }
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
