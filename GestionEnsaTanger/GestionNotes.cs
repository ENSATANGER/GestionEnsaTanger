using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;

namespace GestionEnsaTanger
{
    public partial class GestionNotes : Form
    {
        private static Eleve eleve = new Eleve();
        private static Module m = new Module();
        private static Matiere matiere = new Matiere();
        private static List<object> listM;
        private static List<object> list;
        public GestionNotes()
        {
            InitializeComponent();
        }

        private void b_Ajouter_Click(object sender, EventArgs e)
        {
            if (list.Count != 0)
            {

                Dictionary<string, object> map = new Dictionary<string, object>();
                Notes n = new Notes();
                n.code_eleve = eleve.code;
                foreach (object obj in listM)
                {
                    matiere = (Matiere)obj;
                    if (matiere.designation == c_Matiere.SelectedItem.ToString())
                    {
                        n.code_mat = matiere.code;
                    }

                }
                map.Add("code_eleve", n.code_eleve);
                map.Add("code_mat", n.code_mat);
                List<object> l = n.Select(map);
                if (l.Count == 0)
                {
                    DB.Connexion.Connect();
                    Connexion.Cmd.Connection = Connexion.Con;
                    Connexion.Cmd.CommandText = "Ajouter";
                    Connexion.Cmd.CommandType = CommandType.StoredProcedure;
                    var code_eleve = Connexion.Cmd.CreateParameter();
                    code_eleve.ParameterName = "@code_eleve";
                    code_eleve.Value = eleve.code;
                    Connexion.Cmd.Parameters.Add(code_eleve);
                    var code_mat = Connexion.Cmd.CreateParameter();
                    code_mat.ParameterName = "@code_mat";
                    foreach (object obj in listM)
                    {
                        matiere = (Matiere)obj;
                        if (matiere.designation == c_Matiere.SelectedItem.ToString())
                        {
                            code_mat.Value = matiere.code;
                            Connexion.Cmd.Parameters.Add(code_mat);
                        }

                    }
                    var note = Connexion.Cmd.CreateParameter();
                    note.ParameterName = "@note";
                    if (float.Parse(t_Note.Text.ToString(), CultureInfo.InvariantCulture.NumberFormat) <= 20 && float.Parse(t_Note.Text.ToString(), CultureInfo.InvariantCulture.NumberFormat) >= 0)
                    {
                        note.Value = float.Parse(t_Note.Text.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                        Connexion.Cmd.Parameters.Add(note);
                        //succes.Text = Connexion.Cmd.CommandText.ToString();
                        if (Connexion.Cmd.ExecuteNonQuery() == 1)
                        {
                            succes.Text = "Note Ajouter!";
                            error.Text = string.Empty;
                            c_Matiere.Items.Clear();
                            t_Note.Text = string.Empty;
                            Connexion.Con.Close();
                        }
                    }

                    else
                    {
                        error.Text = "Note invalide!";
                        succes.Text = string.Empty;
                        Connexion.Con.Close();
                    }
                }
                else
                {
                    error.Text = "Note existante!";
                    succes.Text = string.Empty;
                    Connexion.Con.Close();
                }

            }
            else
                error.Text = "Aucun etudiant ne correspond a ce code!";
        }

        private void GestionNotes_Load(object sender, EventArgs e)
        {

            t_CodeEleve.Text = GestionEleves.code_eleve;

            eleve.code = GestionEleves.code_eleve;
            Dictionary<string, object> map = new Dictionary<string, object>();
            map.Add("code", eleve.code);
            list = eleve.Select(map);
            if (list.Count == 0)
            {
                error.Text = "erreur! Aucun eleve ne correspond a ce code";
            }
            else
            {
                eleve = (Eleve)list.First();
                map.Clear();
                map.Add("code_fil", eleve.code_fil);
                map.Add("niveau", eleve.niveau);

                listM = m.Select(map);
                m = (Module)listM.First();
                map.Clear();
                map.Add("code_module", m.code);

                listM.Clear();
                listM = matiere.Select(map);
                foreach (object obj in listM)
                {
                    matiere = (Matiere)obj;
                    c_Matiere.Items.Add(matiere.designation);
                }
            }


        }

        private void b_Nouveau_Click(object sender, EventArgs e)
        {
            t_Note.Text = string.Empty;
            c_Matiere.Items.Clear();
            error.Text = string.Empty;
            succes.Text = string.Empty;
        }

        private void b_Modifier_Click(object sender, EventArgs e)
        {
            if (list.Count != 0)
            {

                Dictionary<string, object> map = new Dictionary<string, object>();
                Notes n = new Notes();
                n.code_eleve = eleve.code;
                foreach (object obj in listM)
                {
                    matiere = (Matiere)obj;
                    if (matiere.designation == c_Matiere.SelectedItem.ToString())
                    {
                        n.code_mat = matiere.code;
                    }

                }
                map.Add("code_eleve", n.code_eleve);
                map.Add("code_mat", n.code_mat);
                List<object> l = n.Select(map);
                if (l.Count == 1)
                {
                    DB.Connexion.Connect();
                    Connexion.Cmd.Connection = Connexion.Con;
                    Connexion.Cmd.CommandText = "Modifier";
                    Connexion.Cmd.CommandType = CommandType.StoredProcedure;
                    var code_eleve = Connexion.Cmd.CreateParameter();
                    code_eleve.ParameterName = "@code_eleve";
                    code_eleve.Value = eleve.code;
                    Connexion.Cmd.Parameters.Add(code_eleve);
                    var code_mat = Connexion.Cmd.CreateParameter();
                    code_mat.ParameterName = "@code_mat";
                    foreach (object obj in listM)
                    {
                        matiere = (Matiere)obj;
                        if (matiere.designation == c_Matiere.SelectedItem.ToString())
                        {
                            code_mat.Value = matiere.code;
                            Connexion.Cmd.Parameters.Add(code_mat);
                        }

                    }
                    var note = Connexion.Cmd.CreateParameter();
                    note.ParameterName = "@note";
                    if (float.Parse(t_Note.Text.ToString(), CultureInfo.InvariantCulture.NumberFormat) <= 20 && float.Parse(t_Note.Text.ToString(), CultureInfo.InvariantCulture.NumberFormat) >= 0)
                    {
                        note.Value = float.Parse(t_Note.Text.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                        Connexion.Cmd.Parameters.Add(note);
                        //succes.Text = Connexion.Cmd.CommandText.ToString();
                        if (Connexion.Cmd.ExecuteNonQuery() == 1)
                        {
                            succes.Text = "Note Modifier!";
                            error.Text = string.Empty;
                            c_Matiere.Items.Clear();
                            t_Note.Text = string.Empty;
                            Connexion.Con.Close();
                        }
                    }

                    else
                    {
                        error.Text = "Note invalide!";
                        succes.Text = string.Empty;
                        Connexion.Con.Close();
                    }
                }
                else
                {
                    error.Text = "Note inexistante!";
                    succes.Text = string.Empty;
                    Connexion.Con.Close();
                }

            }
            else
                error.Text = "Aucun etudiant ne correspond a ce code!";
        }

        private void b_Supprimer_Click(object sender, EventArgs e)
        {
            if (list.Count != 0)
            {
                Dictionary<string, object> map = new Dictionary<string, object>();
                Notes n = new Notes();
                n.code_eleve = eleve.code;
                foreach (object obj in listM)
                {
                    matiere = (Matiere)obj;
                    if (matiere.designation == c_Matiere.SelectedItem.ToString())
                    {
                        n.code_mat = matiere.code;
                    }

                }
                map.Add("code_eleve", n.code_eleve);
                map.Add("code_mat", n.code_mat);
                List<object> l = n.Select(map);
                DialogResult result = MessageBox.Show("vous voulez supprimer la note " + t_Note.Text + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (l.Count == 1)
                    {
                        DB.Connexion.Connect();
                        Connexion.Cmd.Connection = Connexion.Con;
                        Connexion.Cmd.CommandText = "Supprimer";
                        Connexion.Cmd.CommandType = CommandType.StoredProcedure;
                        var code_eleve = Connexion.Cmd.CreateParameter();
                        code_eleve.ParameterName = "@code_eleve";
                        code_eleve.Value = eleve.code;
                        Connexion.Cmd.Parameters.Add(code_eleve);
                        var code_mat = Connexion.Cmd.CreateParameter();
                        code_mat.ParameterName = "@code_mat";
                        foreach (object obj in listM)
                        {
                            matiere = (Matiere)obj;
                            if (matiere.designation == c_Matiere.SelectedItem.ToString())
                            {
                                code_mat.Value = matiere.code;
                                Connexion.Cmd.Parameters.Add(code_mat);
                            }

                        }
                        if (Connexion.Cmd.ExecuteNonQuery() == 1)
                        {
                            succes.Text = "Note Supprimer!";
                            error.Text = string.Empty;
                            c_Matiere.Items.Clear();
                            t_Note.Text = string.Empty;
                            Connexion.Con.Close();
                        }

                    }
                }

                else
                {
                    succes.Text = string.Empty;
                    error.Text = "Aucune note a supprimer!";
                }
                }

            }
         

        private void b_Rechercher_Click(object sender, EventArgs e)
        {
            if (list.Count != 0)
            {

                Dictionary<string, object> map = new Dictionary<string, object>();
                Notes n = new Notes();
                n.code_eleve = eleve.code;
                foreach (object obj in listM)
                {
                    matiere = (Matiere)obj;
                    if (matiere.designation == c_Matiere.SelectedItem.ToString())
                    {
                        n.code_mat = matiere.code;
                    }

                }
                map.Add("code_eleve", n.code_eleve);
                map.Add("code_mat", n.code_mat);
                List<object> l = n.Select(map);
                if (l.Count == 1)
                {
                    Notes note = (Notes)l.First();
                    t_Note.Text = note.note.ToString();
                }
                else
                {
                    error.Text = "Aucune Note trouve!";
                    succes.Text = string.Empty;
                }
            }
        }
    }
}
