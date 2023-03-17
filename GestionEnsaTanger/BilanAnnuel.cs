using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            elevlist();
        }

        private void niveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            filiere.Items.Clear(); // Clear existing items in filiere combobox

            if (niveau.SelectedItem != null && niveau.SelectedItem.ToString() != "AP1" && niveau.SelectedItem.ToString() != "AP2")
            {
                fillist();
            }
            else
            {
                filiere.Items.Clear();
                filiere.Text= "باقي صغير";
            }
            elevlist();
            
        }

        private void etudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            // Get the selected student from the etudiant combobox
            string selectedStudent = etudiant.SelectedItem.ToString();

            //still working on it
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
        private void fillist()
        {
            filiere.Text = "filiere";
            Filiere fil = new Filiere();
            List<dynamic> filList = fil.All();
            System.Object[] itemObjects = new System.Object[filList.Count];
            int i = 0;
            foreach (Filiere f1 in filList)
            {
                itemObjects[i] = f1.code;
                i++;
            }
            filiere.Items.AddRange(itemObjects);
        }
        private void elevlist()
        {
            etudiant.Items.Clear();
            Eleve el = new Eleve();
            List<dynamic> elevelist = el.All();
/*            elevelist = elevelist.Where(e => e.niveau == niveau.Text && e.filiere == filiere.Text).ToList();
*/            System.Object[] itemObjects2 = new System.Object[elevelist.Count];
            int j = 0;
            foreach (Eleve e1 in elevelist)
            {
                itemObjects2[j] = e1.nom;
                j++;
            }
            etudiant.Items.AddRange(itemObjects2);
        }
    }
}
