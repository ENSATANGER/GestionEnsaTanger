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
using System.Windows.Forms;

namespace GestionEnsaTanger
{
    class Module : DB.Model
    {
        private string Code, Designation, Niveau, Semestre,Code_fil;
        
        public Module() { }

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
        public string code_fil
        {
            get { return Code_fil; }
            set { Code_fil = value; }
        }
        
        public Module(string code, string designation, string niveau, string semestre, string code_fil)
        {
            this.Code=code;
            this.Designation = designation;
            this.Niveau = niveau;
            this.Semestre = semestre;
            this.Code_fil = code_fil;
        }

        ///
        ///
        ///
        ///

        public static void Create(Module module)
        {
            string req = $"INSERT INTO Module (Code, Designation, Niveau, Semestre, Code_fil) VALUES ('{module.Code}', '{module.Designation}','{module.Niveau}','{module.Semestre}','{module.Code_fil}')";
            int i = Connexion.IUD(req);
            if(i==1) MessageBox.Show("Created Successfully");
        }

        //
        //
        public static void Update(Module module)
        {
            string req = $"UPDATE Module SET Code = '{module.Code}', Designation = '{module.Designation}', Niveau = '{module.Niveau}', Semestre = '{module.Semestre}', Code_fil = '{module.Code_fil}' WHERE Code = {module.Code}";
            int i = Connexion.IUD(req);
            if (i == 1) MessageBox.Show("Updated Successfully");
        }

        //
        //
        public static List<Module> Read()
        {
            List<Module> modules = new List<Module>();
            string req = "SELECT * FROM Module";
            IDataReader reader = Connexion.Select(req);
            while (reader.Read())
            {
                Module module = new Module();
                module.Code = reader.GetString(1);
                module.Designation = reader.GetString(2);
                module.Niveau = reader.GetString(3);
                module.Semestre = reader.GetString(4);
                module.Code_fil = reader.GetString(5);
                modules.Add(module);
            }
            reader.Close();
            return modules;
        }


        public static void Delete(string moduleCode)
        {
            string req = $"DELETE FROM Module WHERE Code = {moduleCode}";
            int i = Connexion.IUD(req);
            if (i == 1) MessageBox.Show("Deleted Successfully");
        }


        /*if code exists already in the database then the return is false
         public bool CheckCode(string code)
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
