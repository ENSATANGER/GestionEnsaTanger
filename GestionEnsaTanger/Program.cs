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

            /* Eleve eleve = new Eleve();
             eleve.code_fil = "F1";*/
            /*foreach (var item in Eleve.all<Eleve>())
                Console.WriteLine(item);*/

            Eleve e = new Eleve();
            e.Ajouter("c1","n1","p1","n1","F1");

            List<Eleve> list = e.Rechercher();
            foreach (Eleve eleve in list)
            {
                Console.WriteLine(eleve.id);
            }


            Console.ReadKey();
        }
    }
}
