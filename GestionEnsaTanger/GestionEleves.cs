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
    public partial class GestionEleves : Form
    {
        public static string code_eleve;
        public GestionEleves(MDI mdi)
        {
            InitializeComponent();
            MdiParent = mdi;
            TopLevel = false;
            Dock = DockStyle.Fill;
        }

        private void buttonGestionNotes_Click(object sender, EventArgs e)
        {
            code_eleve = code.Text;
            GestionNotes newMDIChild = new GestionNotes();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this.MdiParent;
            // Display the new form.
            newMDIChild.Show();
        }

        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            nom.Text = "";
            prenom.Text = "";
            code.Text = "";
            code.Text = "";
            filiere.Text = "";
            niveau.Text = "";
        }
    }
}
