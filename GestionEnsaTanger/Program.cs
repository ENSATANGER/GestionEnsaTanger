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
            /*Module module= new Module("cc","d1","n1","s1","c1");
            module.Create();*/
            Matiere m = new Matiere("code matiere", "designation m", 10, "cc")
            {
                id = 4,
                Designation = "ddm"
            };
            m.Delete();
            Console.ReadKey();  
        }
    }
}
