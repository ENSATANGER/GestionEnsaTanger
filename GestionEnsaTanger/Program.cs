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
            /*Module module= new Module("cc2","d1","n1","s1","c1");
            module.id= 27;
            module.Delete();*/
            Matiere m2 = new Matiere("code2", "dm", 99, "cc");
            m2.id= 25;
            m2.Delete(m2.code);
            Console.ReadKey();  
        }
    }
}
