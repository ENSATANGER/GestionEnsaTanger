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
            Notes note = new Notes(t_CodeEleve.Text, t_Matiere.Text, (float)Double.Parse(t_Note.Text));
            note.save();
        }
    }
}
