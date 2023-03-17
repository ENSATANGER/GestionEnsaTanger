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
            /*formEleves.Show();*/
            GestionEleves newMDIChild = new GestionEleves(this);
            // Set the Parent Form of the Child window.
            //newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultationNotes().ShowDialog();
        }
    }
}
