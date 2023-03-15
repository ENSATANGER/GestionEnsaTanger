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
            eleve.code = "AAA";
            Dictionary<string, object> map = new Dictionary<string, object>();
            map.Add("code", eleve.code);
            List<object> list = eleve.Select(map);
            if (list.Count == 0)
                Console.WriteLine("vide");*/
            /*foreach (object item in list)
            {

                Console.WriteLine(item.ToString());
            }*/
           /* eleve = (Eleve)list.First();
            Dictionary<string, object> map2 = new Dictionary<string, object>();
            map2.Add("code_fil", eleve.code_fil);
            map2.Add("niveau", eleve.niveau);*/
            /*foreach(KeyValuePair<string,object> e in map2)
            {
                Console.WriteLine(e.Key+" "+e.Value);
            }*/
            /*Module m = new Module();
            List<object> list2 = m.Select(map2);
            m = (Module)list2.First();
            map.Clear();
            map.Add("code_module", m.code);
            Matiere matiere = new Matiere();
            list2.Clear();
            list2 = matiere.Select(map);
            foreach (object obj in list2)
            {
                matiere = (Matiere)obj;
                Console.WriteLine(matiere);
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
