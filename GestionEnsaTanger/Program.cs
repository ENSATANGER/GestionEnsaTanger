using System;
using System.Collections.Generic;
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

            Eleve eleve = new Eleve();
            eleve.id = 25;
            /*eleve.Rechercher();*/
            /*Console.WriteLine(eleve.ToString());*/
            if (eleve.Supprimer())
            {
                Console.WriteLine("added");
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();  
        }
    }
}
