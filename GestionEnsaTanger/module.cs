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

        public override string ToString()
        {
            return $"{Code} - {Designation} {Niveau} - {Semestre} - {Code_fil}";
        }

        ///
        //works fine
        public void Create()
        {
            int i = save();
            if (i == -1) MessageBox.Show("ERROR");
            if (i == -2) MessageBox.Show("EXCEPTION");
            if (i==0) MessageBox.Show("Created Successfully");
        }

        //
        //working fine, needs an id to update if not it will work just like create
        public void Update(string code, string designation, string niveau, string semestre, string code_fil)
        {

                Module m = new Module
                {
                    Code = code
                };
                List<object> module = Select(ObjectToDictionary<object>(m));
                if (module.Count > 0)
                {
                    id = ((Module)module[0]).id;
                    Code = code;
                    Designation = designation;
                    Niveau = niveau;
                    Code_fil = code_fil;
                }

            int i = save();
            if (i==0) MessageBox.Show("UPDATED SUCCESSFULLY");
            if (i == -1) MessageBox.Show("ERROR");
            if (i == -2) MessageBox.Show("EXCEPTION");
        }

        //
        //reads a list of modules
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

        //
        //working fine, needs an id to delete if not it will raise error
        public void Delete(string code)
        {

            Module m = new Module
            {
                Code = code
            };
            List<object> module = Select(ObjectToDictionary<object>(m));
            if (module.Count > 0)
            {
                id = ((Module)module[0]).id;
            }

            int i = delete();
            if (i != 0 && i != -1) MessageBox.Show("DELETED  Successfully");
            if (i == 0) MessageBox.Show("No Line Deleted");
            if (i == -1) MessageBox.Show("Exception");
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
