﻿using System;
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

            Module m = new Module("c5", "d1", "n1", "s1","c1");
            Module.Create(m);
            List<Module> modules = Module.Read();
            foreach (Module module in modules)
            {
                Console.WriteLine(module.code);
            }

  
            /*Eleve eleve = new Eleve();
            eleve.id = 10;
            eleve.Rechercher();
            Console.WriteLine(eleve.ToString());
            if (eleve.Ajouter("m2", "hachguer", "mohamed", "3", "c1"))
            {
                Console.WriteLine("added");
            }
            else
            {
                Console.WriteLine("error");
            }*/
            
            Console.ReadKey();  
        }
    }
}
