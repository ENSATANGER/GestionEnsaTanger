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
            //new MDI().ShowDialog();
            Eleve eleve = new Eleve("AAA");
            Dictionary<string,object> map = new Dictionary<string,object>();
            map.Add("code", eleve.code);
           /* List<Eleve> list = Model.select(map);*/
            foreach(dynamic item in list)
            {
                Eleve el = (Eleve)item;
                Console.WriteLine(item.code);
            }
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
