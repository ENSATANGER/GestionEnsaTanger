using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEnsaTanger
{
    internal class Matiere : Model
    {
        string code, designation, code_module;
        float VH;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

    }
}
