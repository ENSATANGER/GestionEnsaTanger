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

            Module m = new Module("c5", "d2", "n2", "s1","c1");
/*            Module.Create(m);
*/            
            /*List<Module> modules = Module.Read();
                foreach (Module module in modules)
                {
                    Console.WriteLine(module.code);
                }*/

            Module.Update(m);
/*            Module.Delete(m.code);
*/
            Console.ReadKey();  
        }
    }
}
