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
            Filiere F1 = new Filiere("GINF", "genie informatique");
            Filiere F2 = new Filiere("GSTR", "genie systemes reseaux et telecommunication");
            Filiere F3 = new Filiere("GINF", "genie informatique");
            Filiere F4 = new Filiere("GINF", "genie informatique");
            Filiere F5 = new Filiere("GINF", "genie informatique");

            /*F1.save();
            F2.save();
            F3.save();
            F4.save();
            F5.save();*/

            /*Filiere F = F1.find();
            F1 = Filiere.find<Filiere>(2);
            F2 = F;*/

            List<dynamic> ListeFilieres = F1.All();

            foreach(dynamic item in ListeFilieres)
                Console.WriteLine(item+"\n");
        }
    }
}
