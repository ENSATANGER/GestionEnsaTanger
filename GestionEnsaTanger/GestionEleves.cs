using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            ListEleves();
        }
        private void Initializer()
        {
            nom.Text = "";
            prenom.Text = "";
            code.Text = "";
            code.Text = "";
            filiere.Text = "";
            niveau.Text = "";
        }
        private void ListEleves()
        {
            List<object> eleves = Eleve.all<Eleve>();
            eleves.Reverse();
            foreach (Eleve eleve in eleves)
            {
                var row = new DataGridViewRow();
                row.CreateCells(ElevesTable);
                row.Cells[0].Value = eleve.code;
                row.Cells[1].Value = eleve.nom;
                row.Cells[2].Value = eleve.prenom;
                row.Cells[3].Value = eleve.code_fil;
                row.Cells[4].Value = eleve.niveau;
                ElevesTable.Rows.Add(row);
            }
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
            Initializer();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(code.Text) || string.IsNullOrWhiteSpace(prenom.Text) || string.IsNullOrWhiteSpace(nom.Text) || string.IsNullOrWhiteSpace(filiere.Text) || string.IsNullOrWhiteSpace(niveau.Text))
            {
                MessageBox.Show("Error!! Inserer tous les champs");
            }
            else
            {
                if((new Eleve()).Ajouter(code.Text, prenom.Text, nom.Text, niveau.Text, filiere.Text))
                {
                    message.Text = "succès l'élève est bien inserer";
                    Initializer();
                    ListEleves();
                }
                else
                    message.Text = "erreur! code déja utilisé";
            }
        }

        private void ElevesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
