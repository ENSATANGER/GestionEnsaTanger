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
            new MDI().ShowDialog();
            /*Eleve eleve = new Eleve();
            eleve.code = "F1524";
            eleve.RemplireXML(eleve);*/
            Console.ReadKey();
        }
    }
}
