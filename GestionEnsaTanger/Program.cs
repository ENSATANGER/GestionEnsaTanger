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
            eleve.code = "BBB";
            Dictionary<string,object> map = new Dictionary<string,object>();
            map.Add("code", eleve.code);
            List<object> list = eleve.Select(map);
            if (list.Count == 0)
                Console.WriteLine("vide");
            foreach(object item in list)
            {
                
                Console.WriteLine(item.ToString());
            }*/
            /*if (eleve.find() == null)
            {
                Console.WriteLine("AAA");
                
            }*/
            /*Eleve e1 = new Eleve("Hachguer", "Mohamed", "GINF2", "GI2");
            Notes n = new Notes("AAA", "GINF41", 14);
            n.Ajouter();*/
            //e1.save();

        }
    }
}
