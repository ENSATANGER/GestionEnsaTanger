using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEnsaTanger
{
    class Matiere : DB.Model
    {
        public string Code { get; set; }
        public string Designation { get; set; }
        public float VH { get; set; }
        public string CodeModule { get; set; }

        public Matiere(string code, string designation, float vh, string codeModule)
        {
            Code = code;
            Designation = designation;
            VH = vh;
            CodeModule = codeModule;
        }

        public override string ToString()
        {
            return $"{Code} - {Designation} ({VH}h) - {CodeModule}";
        }

        //working fine
        public void Create()
        {
            Console.WriteLine("test");
            int i = save();
            Console.WriteLine(i);
            if (i == -2) MessageBox.Show("EXCEPTION");
            if (i == -1) MessageBox.Show("ERROR");
            if (i == 0) MessageBox.Show("Created Successfully");
        }
        public void Update()
        {
            int i = save();
            if (i == 0) MessageBox.Show("UPDATED SUCCESSFULLY");
            if (i == -1) MessageBox.Show("ERROR");
            if (i == -2) MessageBox.Show("EXCEPTION");
        }


        //working fine
        public void Delete()
        {
            int i = delete();
            if (i == 0) MessageBox.Show("Deleted Successfully");
            if (i == -2) MessageBox.Show("Exception");
            if (i == -1) MessageBox.Show("Error");
        }

    }
}
