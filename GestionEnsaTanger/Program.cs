using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;

namespace GestionEnsaTanger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Filiere F1 = new Filiere("GINF", "genie informatique");
             Filiere F2 = new Filiere("GSTR", "genie systemes reseaux et telecommunication");
            *//* Filiere F3 = new Filiere("GIL", "genie Industriel et Logistique");
             Filiere F4 = new Filiere("GSEA", "genie Systemes electronique et automatiques");
             Filiere F5 = new Filiere("G3EI", "genie eco-energitique et envirennement industriel");
 */
            /*F1.save();
            F2.save();
            F3.save();
            F4.save();
            F5.save();*//*

            Filiere F = F1.find();
            F2 = Filiere.find<Filiere>(1);
            F1 = F;
            Dictionary<string, object> D = new Dictionary<string, object>();
            D.Add("code", "GINF");
            //List<dynamic> ListeFilieres = F1.Select(D);
            //List<dynamic> ListeFilieres = Filiere.select<Filiere>(D);
            List<dynamic> ListeFilieres = Filiere.all<Filiere>();
            //List<dynamic> ListeFilieres = F1.All();


            foreach (dynamic item in ListeFilieres)
            {
                Filiere Fil = item;
                Console.WriteLine(Fil + "\n");
            }
*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConsultationNotes());

        }
    }
}
