﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DB;

namespace GestionEnsaTanger
{
    class Eleve : Model
    {
        private string Code, Nom, Prenom, Niveau, Code_fil;
        public Eleve() { }

        public string code
        {
            get { return Code; }
            set { Code = value; }
        }
        public string nom
        {
            get { return Nom; }
            set { Nom = value; }
        }
        public string prenom
        {
            get { return Prenom; }
            set { Prenom = value; }
        }
        public string niveau
        {
            get { return Niveau; }
            set
            {
                Niveau = value;
            }
        }
        public string code_fil
        {
            get { return Code_fil; }
            set
            {
                Code_fil = value;
            }
        }

        public Boolean Ajouter(string code, string nom, string prenom, string niveau, string code_Fil)
        {
            Code = code;
            Nom = nom;
            Prenom = prenom;
            Niveau = niveau;
            Code_fil = code_Fil;
            int i = save();
            if (i != -1 && i != -2)
                return true;
            return false;
        }

        // can't modify the code
        public Boolean Modifier(string code, string nom, string prenom, string niveau, string code_Fil)
        {
            Eleve e = new Eleve
            {
                Code = code
            };
            List<object> eleve = Select(ObjectToDictionary<object>(e));
            if (eleve.Count > 0)
            {
                id = ((Eleve)eleve[0]).id;
                Code = code;
                Nom = nom;
                Prenom = prenom;
                Niveau = niveau;
                Code_fil = code_Fil;
            }
            int i = save();
            if (i != -1 && i != -2)
                return true;
            return false;
        }
        public Boolean Supprimer(string code)
        {
            Eleve e = new Eleve
            {
                Code = code
            };
            List<object> eleve = Select(ObjectToDictionary<object>(e));
            if (eleve.Count > 0)
            {
                id = ((Eleve)eleve[0]).id;

                Notes n = new Notes();
                n.code_eleve = ((Eleve)eleve[0]).code;

                Moyennes m = new Moyennes();
                m.code_eleve = ((Eleve)eleve[0]).code;

                List<object> notes = n.Select(n.ObjectToDictionary<object>(n));
                List<object> moyennes = m.Select(m.ObjectToDictionary<object>(m));

                //Remplissage du xml d'abord
                RemplireXML((Eleve)eleve[0],notes, moyennes);

                if (notes.Count > 0)
                {
                    foreach(Notes note in notes)
                    {
                        note.id = note.id;
                        note.delete();
                    }
                }

                if (moyennes.Count > 0)
                {
                    foreach (Moyennes moy in moyennes)
                    {
                        moy.id = moy.id;
                        moy.delete();
                    }
                }
            }
            int i = delete();
            if (i != 0 && i != -1)
                return true;
            return false;
        }
        public void RemplireXML(Eleve eleve,List<object> notes, List<object> moyennes)
        {
            XDocument XENSATANER = XDocument.Load("../../xml_files/ENSA_TANGER.xml");

            // Recherche de filiere <=> eleve.Code_fil
            XElement XRoot = XENSATANER.Root;
            var XFiliere = XRoot.Elements("Filiere");

            var reqFiliere = (from fr in XFiliere
                              where fr.Attribute("code").Value == eleve.Code_fil
                              select fr).FirstOrDefault();

            // Recherche de niveau <=> eleve.niveau
            var XNiveau = reqFiliere.Elements("Niveau");
            var reqNiveau = (from nv in XNiveau
                             where nv.Attribute("code").Value == eleve.Niveau
                             select nv).FirstOrDefault();

            XElement E = new XElement("Eleve");
            E.SetAttributeValue("id", eleve.id);
            E.SetAttributeValue("code", eleve.code);
            E.SetAttributeValue("nom", eleve.nom);
            E.SetAttributeValue("prenom", eleve.prenom);
            E.SetAttributeValue("niveau", eleve.niveau);
            E.SetAttributeValue("code_fil", eleve.code_fil);

            if (notes.Count > 0)
            {
                XElement XNotes = new XElement("Notes");

                foreach (Notes note in notes)
                {
                    XNotes.Add(
                        new XElement("Note",
                        new XElement("note", note.note),
                        new XAttribute("id", note.id),
                        new XAttribute("code_mat", note.code_mat),
                        new XAttribute("code_eleve", note.code_eleve)
                        ));
                }

                E.Add(XNotes);
                if (moyennes.Count > 0)
                {
                    foreach (Moyennes moy in moyennes)
                    {
                        E.Add(
                            new XElement("Moyenne",
                            new XElement("niveau", moy.niveau),
                            new XElement("moyenne", moy.moyenne),
                            new XAttribute("id", moy.id),
                            new XAttribute("code_eleve", moy.code_eleve),
                            new XAttribute("code_fil", moy.code_fil)
                            ));
                    }
                }
            }
            

            reqNiveau.Add(E);

            XENSATANER.Save("../../xml_files/ENSA_TANGER.xml");

            /*XDocument XNotes = XDocument.Load("../../xml_files/Notes.xml");
            XElement RootNotes = XNotes.Root;

            foreach(Notes item in notes)
            {
                XElement N = new XElement("Note");
                N.SetAttributeValue("id", item.id);
                N.SetAttributeValue("code_eleve", item.code_eleve);
                N.SetAttributeValue("code_mat", item.code_mat);
                N.Add(new XElement("note", item.note));
                RootEleve.Add(N);
            }*/

        }

        // remplissage des attributes ce fait dans GestionEleve
        public List<object> Rechercher()
        {
            List<object> eleves = new List<object>();
            Dictionary<string, object> dico = ObjectToDictionary<object>(this);
            List<object> data = Select(dico);
            foreach (var item in data)
            {
                eleves.Add((Eleve)item);
            }
            return eleves;
        }
        private void Initialize(Eleve eleve)
        {
            Code = eleve.Code;
            Nom = eleve.Nom;
            Prenom = eleve.Prenom;
            Niveau = eleve.Niveau;
            Code_fil = eleve.Code_fil;
        }
        public override string ToString()
        {
            return base.ToString() + " nom: " + Nom + " prenom: " + Prenom + " code: " + Code + " Filiere : " + Code_fil + " Niveau : " + Niveau;
        }
    }
}