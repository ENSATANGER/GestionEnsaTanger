using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace GestionEnsaTanger
{
    internal class Etudiant : Model
    {
        public string Code, nom, prenom, niveau, code_Fil;

        public Etudiant(string code, string nom, string prenom, string niveau, string code_Fil)
        {
            Code = code;
            this.nom = nom;
            this.prenom = prenom;
            this.niveau = niveau;
            this.code_Fil = code_Fil;
        }
    }
}
