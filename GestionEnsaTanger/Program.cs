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

            Module m = new Module("c6", "d2", "n2", "s1","c1");
            m.id= 24;
            m.Delete();
            Console.ReadKey();  
        }
    }
}
