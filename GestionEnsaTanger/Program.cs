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

            Module m = new Module("c1", "d1", "n1", "s1","f1");
            Console.WriteLine("4");
            m.delete();
            Console.WriteLine("done");

            Console.ReadKey();
        }
    }
}
