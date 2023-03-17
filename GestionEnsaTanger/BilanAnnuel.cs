using DB;
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
    public partial class BilanAnnuel : Form
    {
        public BilanAnnuel()
        {
            InitializeComponent();
        }

        private void filiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void niveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            filiere.Items.Clear(); // Clear existing items in filiere combobox

            if (niveau.SelectedItem != null && niveau.SelectedItem.ToString() != "AP1" && niveau.SelectedItem.ToString() != "AP2")
            {
                Filiere fil = new Filiere();
                List<dynamic> filList = fil.All();
                System.Object[] itemObjects = new System.Object[filList.Count];
                int i = 0;
                foreach (Filiere frow in filList)
                {
                    itemObjects[i] = frow.code;
                    i++;
                }
                filiere.Items.AddRange(itemObjects);
            }
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

        private void BilanAnnuel_Load_1(object sender, EventArgs e)
        {
            
        }

    }
}
