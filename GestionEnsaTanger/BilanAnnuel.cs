using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            ListFilieres();

        }


        private void filiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            Niveau();
            etudiant.SelectedIndex= -1;
            dataGridView1.Rows.Clear();
        }

        private void niveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            elevlist();
            dataGridView1.Rows.Clear();

        }

        private void etudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            try { 
            string codeEleve = etudiant.SelectedItem.ToString(); 
            FillDataGridView(codeEleve);
            calcMoy();
            }
            catch{MessageBox.Show("ESSAYER DE CHOISIR UN ETUDIANT"); }
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
        private void Niveau()
        {
            niveau.Items.Clear();

            if (filiere.Text == "AP")
            {
                niveau.Items.Add(filiere.Text + "1");
                niveau.Items.Add(filiere.Text + "2");
            }
            if (filiere.Text == "GINF" || filiere.Text == "GSTR" || filiere.Text == "GIL" || filiere.Text == "GSEA" || filiere.Text == "G3EI")
            {
                niveau.Items.Add(filiere.Text + "1");
                niveau.Items.Add(filiere.Text + "2");
                niveau.Items.Add(filiere.Text + "3");
            }
        }
        private void ListFilieres()
        {
            List<string> filieres = new List<string>();

            List<object> fil = Filiere.all<Filiere>();
            foreach (object item in fil)
                filieres.Add(((Filiere)item).code);

            filiere.Items.Clear();
            foreach (string item in filieres)
                filiere.Items.Add(item);
            Niveau();
        }
        private void fillist()
        {
            filiere.Refresh();
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
            Eleve eleve = new Eleve();
            eleve.niveau = niveau.SelectedItem.ToString();
            eleve.code_fil = filiere.SelectedItem.ToString();
            List<Object> eleves = eleve.Rechercher();
            
            foreach (Eleve e1 in eleves)
            {
                etudiant.Items.Add(e1.code);
                
            }
        }

        private void calcMoy()
        {
            double sum = 0;
            int count = 0;
            if (dataGridView1.Rows.Count == 12)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow && row.Cells["note"].Value != null)
                    {
                        double note = Convert.ToDouble(row.Cells["note"].Value);
                        sum += note;
                        count++;
                    }
                }
                double moy = count == 0 ? 0 : sum / count;
                moyenne.Text = moy.ToString();
            }
            else MessageBox.Show("PLEASE CHECK IF ALL NOTES ARE ENTERED TO DISPLAY MOYENNE");


    }

    private void FillDataGridView(string codeEleve)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=ENSA_TANGER;Integrated Security=True"))
            {
                connection.Open();

                // create a command to select notes for the specified code_eleve
                using (SqlCommand command = new SqlCommand("SELECT * FROM Notes WHERE code_eleve = @codeEleve", connection))
                {
                    command.Parameters.AddWithValue("@codeEleve", codeEleve);

                    // create a data adapter to fill a data set with the results
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        // loop through each note and retrieve the corresponding matiere and semestre
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            string codeMat = row["code_mat"].ToString();
                            double note = double.Parse(row["note"].ToString());

                            // create a command to select the designation of the matiere
                            using (SqlCommand command2 = new SqlCommand("SELECT designation FROM Matiere WHERE code = @codeMat", connection))
                            {
                                command2.Parameters.AddWithValue("@codeMat", codeMat);
                                string designation = command2.ExecuteScalar().ToString();

                                // create a command to select the semestre of the matiere
                                using (SqlCommand command3 = new SqlCommand("SELECT semestre FROM Module WHERE code_fil IN (SELECT code_fil FROM Eleve WHERE code = @codeEleve)", connection))
                                {
                                    command3.Parameters.AddWithValue("@codeEleve", codeEleve);
                                    string semestre = command3.ExecuteScalar().ToString();

                                    // add a row to the DataGridView with the retrieved values
                                    dataGridView1.Rows.Add(codeMat, designation, semestre, note);
                                }
                            }
                        }
                    }
                }
            }
        }



    }
}
