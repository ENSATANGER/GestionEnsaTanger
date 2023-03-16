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
            List<dynamic> L = loadFilieres();
            foreach (Filiere item in L)
                FiliereBox.Items.Add(item.code);

            if( FiliereBox.Items.Contains("GINF"))
            {
                NiveauBox.Items.Add("GINF1");
                NiveauBox.Items.Add("GINF2");
                NiveauBox.Items.Add("GINF3");
            }else if(FiliereBox.Items.Contains("GSTR"))
            {
                NiveauBox.Items.Add("GSTR1");
                NiveauBox.Items.Add("GSTR2");
                NiveauBox.Items.Add("GSTR3");
            }
            else if(FiliereBox.Items.Contains("GSTR"))
            {
                NiveauBox.Items.Add("GIL1");
                NiveauBox.Items.Add("GIL2");
                NiveauBox.Items.Add("GIL3");
            }else
            {
                NiveauBox.Items.Add("AP1");
                NiveauBox.Items.Add("AP2");
            }
            if(NiveauBox.SelectedItem!=null)
            {
                string Niveau = NiveauBox.SelectedItem.ToString();
                Dictionary<string, object> dict = new Dictionary<string, object>();
                dict.Add("Niveau", Niveau);
                List<dynamic> Matieres = Model.select<Matiere>(dict);
                foreach (dynamic mat in Matieres)
                {
                    Matiere Mat = mat as Matiere;
                    MatiereBox.Items.Add(Mat.designation);
                }
            }
        }

        private List<dynamic> loadFilieres()
        {
            List<dynamic> L = Filiere.all<Filiere>();
            return L;
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
            if (NiveauBox.SelectedItem != null)
            {
                Dictionary<string, object> dict = new Dictionary<string, object>();

                List<dynamic> Matieres = Model.select<Matiere>(dict);

                Matiere M = Matieres.Find(x => x.designation == MatiereBox.SelectedItem.ToString());
                string req = "SELECT Eleve.code, Eleve.nom, Eleve.prenom, Note.notes FROM Notes where code_mat = " + M.code +
                    " JOIN Eleve ON Notes.code_eleve=Eleve.code where Notes.code_mat=" + M.code + " and Eleve.niveau=" + NiveauLabel;
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
