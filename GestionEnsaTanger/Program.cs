using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace GestionEnsaTanger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* new MDI().ShowDialog();*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create a new instance of your form
            BilanAnnuel form = new BilanAnnuel();

            // Run the form
            Application.Run(form);


            Console.ReadKey();  
        }
    }
}
