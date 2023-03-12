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

            Eleve eleve = new Eleve("boulouqat", "jawad", "2", "F1");
            eleve.show();
            Console.ReadKey();
        }
    }
}
