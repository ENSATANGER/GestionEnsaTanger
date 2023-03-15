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
            m.Create();
            m.show();
            Console.WriteLine(m.code);
            Console.ReadKey();
        }
    }
}
