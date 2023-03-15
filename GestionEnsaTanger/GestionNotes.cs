using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEnsaTanger
{
    public partial class GestionNotes : Form
    {
        public GestionNotes()
        {
            InitializeComponent();
        }

        private void b_Ajouter_Click(object sender, EventArgs e)
        {
            //Notes note = new Notes(t_CodeEleve.Text, t_Matiere.Text, (float)Double.Parse(t_Note.Text));
            //note.save();
        }

        private void GestionNotes_Load(object sender, EventArgs e)
        {
            t_CodeEleve.Text = GestionEleves.code_eleve;
            Eleve eleve = new Eleve();
            eleve.code = GestionEleves.code_eleve;
            Dictionary<string, object> map = new Dictionary<string, object>();
            map.Add("code", eleve.code);
            List<object> list = eleve.Select(map);
            if (list.Count == 0)
            {
                Console.WriteLine("AAA");
                error.Text = "erreur! Aucun eleve ne correspond a ce code";
            }
                

        }

        
    }
}
