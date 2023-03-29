using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEnsaTanger
{
    public partial class RestorationEleves : Form
    {
        public RestorationEleves(MDI mdi)
        {
            InitializeComponent();
            MdiParent = mdi;
            TopLevel = false;
            Dock = DockStyle.Fill;
        }

        private void ResorationEleves_Load(object sender, EventArgs e)
        {

        }
        private void RemplireElevesTable(Eleve eleve)
        {
            message.Text = "";
            ElevesTable.Rows.Clear();

            var row = new DataGridViewRow();
            row.CreateCells(ElevesTable);
            row.Cells[0].Value = eleve.code;
            row.Cells[1].Value = eleve.nom;
            row.Cells[2].Value = eleve.prenom;
            row.Cells[3].Value = eleve.niveau;
            row.Cells[4].Value = eleve.code_fil;
            ElevesTable.Rows.Add(row);
        }
        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            Eleve el = Eleve.RechercheXML(code.Text);
            if (el != null)
            {
                RemplireElevesTable(el);
            }
            else
            {
                message.Text = "l'éleve n'existe pas dans le fichier de restoration";
            }
        }

        private void buttonRestorer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(code.Text))
            {
                MessageBox.Show("Inserer le code");
            }
            else
            {
                DialogResult result = MessageBox.Show("vous voulez restorer l'eleve " + code.Text + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if(Eleve.Resotrer(code.Text))
                        message.Text = "l'éleve est bien restorer";
                    else
                        message.Text = "l'éleve n'existe pas dans le fichier de restoration";
                }
                ElevesTable.Rows.Clear();
            }
        }
    }
}
