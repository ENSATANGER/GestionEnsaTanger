using DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEnsaTanger
{
    class module : DB.Model
    {
        public string code, designation, niveau, semestre,code_fil;

        public module() { }

        public module(string code, string designation, string niveau, string semestre, string code_fil)
        {
            this.code = code;
            this.designation = designation;
            this.niveau = niveau;
            this.semestre = semestre;
            this.code_fil = code_fil;
        }

        //if code exists already in the database then the return is false
        public Boolean checkCode(string code)
        {
            int i = 0;
            using (var cmd = Connexion.Select("SELECT COUNT(*) FROM module WHERE code = @code"))
            {
                cmd.AddParameter("@code", code);
                while (cmd.Read())
                {
                    if((string)cmd.GetValue(i) == code) { return false; }
                    i++;
                }
            }
            return true;
        }
    }
}
