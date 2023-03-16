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
    public partial class BilanAnnuel : Form
    {
        public BilanAnnuel()
        {
            InitializeComponent();
        }

        private void filiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear any existing items in the ComboBox
            filiere.Items.Clear();
            Filiere fil = new Filiere();
            // Retrieve all Filiere objects from the database
            List<dynamic> filieres = fil.All();

            // Add the code of each Filiere object to the ComboBox
            foreach (Filiere f in filieres)
            {
                filiere.Items.Add(f.code);
            }

        }

        private void niveau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void etudiant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rechercher_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void moyenne_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
