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
    public partial class MDI : Form
    {
        GestionEleves formEleves;
        public MDI()
        {
            InitializeComponent();
            formEleves = new GestionEleves(this);
            formEleves.Show();
        }

        private void GestionEtudiants_Load(object sender, EventArgs e)
        {

        }

        private void etudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEleves.Show();
        }
    }
}
