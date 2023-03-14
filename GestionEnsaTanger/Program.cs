using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace GestionEnsaTanger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new MDI().ShowDialog();

            IDataReader data = Connexion.Select("select * from eleve");
            int i = 0;
            while (data.Read())
            {
                Console.Write(data.GetName(i) + ": " + data.GetValue(i) + "; ");
                i++;
            }
            /*Eleve eleve = new Eleve();
            eleve.code = "m2";
            eleve.nom = "hachguer";
            eleve.prenom = "mohamed";
            eleve.niveau = "3";
            eleve.code_Fil = "F1";
            if (eleve.Create())
            {
                Console.WriteLine("added");
            }
            else
            {
                Console.WriteLine("error");
            }*/

        }
    }
}
