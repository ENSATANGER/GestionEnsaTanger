﻿using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEnsaTanger
{
    internal class Matiere : Model
    {
        private string Code, Designation, Code_module;
        private float VH;

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

        public float vh
        {
            get { return VH; }
            set { VH = value; }
        }

        public string code_module
        {
            get { return Code_module; }
            set { Code_module = value; }
        }

    }
}
