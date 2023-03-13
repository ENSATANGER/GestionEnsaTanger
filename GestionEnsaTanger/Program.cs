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
            /*new MDI().ShowDialog();*/

            /*IDataReader data = Connexion.Select("select * from eleve");
            int i = 0;
            while (data.Read())
            {
                Console.Write(data.GetName(i)+": "+data.GetValue(i)+ "; ");
                i++;
            }*/
            Eleve eleve = new Eleve();
            eleve.id = 1;
            eleve.show();
            Console.WriteLine(eleve);
                Console.ReadKey();
        }
    }
}
