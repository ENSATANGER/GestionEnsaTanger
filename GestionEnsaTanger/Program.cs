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
            new MDI().ShowDialog();

            /*Eleve eleve = new Eleve();
            eleve.code_fil = "F1";
            foreach (var item in eleve.Rechercher())
                Console.WriteLine(item); */
            Console.ReadKey();
        }
    }
}
