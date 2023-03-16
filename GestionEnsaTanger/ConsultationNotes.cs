using DB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionEnsaTanger
{
    public partial class ConsultationNotes : Form
    {
        public ConsultationNotes()
        {
            InitializeComponent();
            loadFilieres();
            FiliereBox.SelectedIndexChanged += FiliereBox_SelectedIndexChanged;
        }

        private void FiliereBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNiveaux();
            NiveauBox.SelectedIndexChanged += NiveauBox_SelectedIndexChanged;

        }

        private void loadFilieres()
        {
            List<dynamic> L = Filiere.all<Filiere>();
            foreach (Filiere item in L)
                FiliereBox.Items.Add(item.code);
        }

        private void NiveauBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMatieres();
        }
        private void loadNiveaux()
        {
            if (FiliereBox.SelectedItem != null)
            {
                if (FiliereBox.SelectedItem.ToString() == "AP")
                {
                    NiveauBox.Items.Add(FiliereBox.SelectedItem.ToString() + "1");
                    NiveauBox.Items.Add(FiliereBox.SelectedItem.ToString() + "2");
                }
                else
                {
                    NiveauBox.Items.Add(FiliereBox.SelectedItem.ToString() + "1");
                    NiveauBox.Items.Add(FiliereBox.SelectedItem.ToString() + "2");
                    NiveauBox.Items.Add(FiliereBox.SelectedItem.ToString() + "3");
                }
            }
        }

        private void loadMatieres()
        {
            if (NiveauBox.SelectedItem != null)
            {
                string Niveau = NiveauBox.SelectedItem.ToString();
                Dictionary<string, object> dict = new Dictionary<string, object>();
                dict.Add("niveau", Niveau);
                List<dynamic> Modules = Module.select<Module>(dict);
                foreach (dynamic mod in Modules)
                {
                    Module module = (Module)mod;
                    dict = new Dictionary<string, object>();
                    dict.Add("code_module", module.code);
                    List<dynamic> Matieres = Matiere.select<Matiere>(dict);
                   foreach(dynamic mat in Matieres)
                        MatiereBox.Items.Add(mat.designation);
                }
            }
        }
        private void ConsultationNotes_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            string Mat = MatiereBox.SelectedItem.ToString();
            if ( Mat != null)
            {
                string req = "SELECT e1.code, e1.nom, e1.prenom, n.note "+
                    "FROM Notes n INNER JOIN Eleve e1 ON n.code_eleve = e1.code "+
                    "WHERE n.code_mat = 'GINF111';";

                IDataReader rd = Connexion.Select(req);
                DataTable dataTable = new DataTable();

                // load the data from the SqlDataReader into the DataTable
                dataTable.Load(rd);

                // set the DataTable as the data source of the DataGridView
                Notes_Eleves.DataSource = dataTable;
            }
        }
    }
}
