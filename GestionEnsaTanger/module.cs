using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GestionEnsaTanger
{
    class Module : DB.Model
    {
        public string code, designation, niveau, semestre,code_fil;
        
        public Module() { }

        public void setcode(string code)
        {
            this.code = code;
           /* if (CheckCode(code))
            {
                this.code = code;
                Console.WriteLine("done");
            }
            else Console.WriteLine("false");*/
        }
        public Module(string code, string designation, string niveau, string semestre, string code_fil)
        {
            this.setcode(code);
            this.designation = designation;
            this.niveau = niveau;
            this.semestre = semestre;
            this.code_fil = code_fil;
        }
        public Boolean Create()
        {
            if (save() != -1) {
                Console.WriteLine("true");
                return true;

            }
            return false;
        }


        public void show()
        {
            if (find() != null)
                Console.WriteLine("found");
            else
                Console.WriteLine("error");
        }

        //if code exists already in the database then the return is false
        /* public bool CheckCode(string code)
         {
             using (var conn = new SqlConnection("Data Source=localhost;Initial Catalog=ENSA_TANGER;Integrated Security=True"))
             {
                 conn.Open();
                 using (var cmd = new SqlCommand("SELECT COUNT(*) FROM module WHERE code = @code", conn))
                 {
                     cmd.Parameters.AddWithValue("@code", code);
                     int count = (int)cmd.ExecuteScalar();
                     return count == 0;
                 }
             }
         }*/



    }
}
