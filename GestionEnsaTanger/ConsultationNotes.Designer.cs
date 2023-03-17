namespace GestionEnsaTanger
{
    partial class ConsultationNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FiliereBox = new System.Windows.Forms.ComboBox();
            this.NiveauBox = new System.Windows.Forms.ComboBox();
            this.MatiereBox = new System.Windows.Forms.ComboBox();
            this.FiliereLabel = new System.Windows.Forms.Label();
            this.NiveauLabel = new System.Windows.Forms.Label();
            this.MatiereLabel = new System.Windows.Forms.Label();
            this.Rechercher = new System.Windows.Forms.Button();
            this.Notes_Eleves = new System.Windows.Forms.DataGridView();
            this.Moyenne_classe = new System.Windows.Forms.Label();
            this.Moyenne = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Notes_Eleves)).BeginInit();
            this.SuspendLayout();
            // 
            // FiliereBox
            // 
            this.FiliereBox.FormattingEnabled = true;
            this.FiliereBox.Location = new System.Drawing.Point(130, 38);
            this.FiliereBox.Name = "FiliereBox";
            this.FiliereBox.Size = new System.Drawing.Size(152, 28);
            this.FiliereBox.TabIndex = 0;
            this.FiliereBox.SelectedIndexChanged += new System.EventHandler(this.FiliereBox_SelectedIndexChanged_1);
            // 
            // NiveauBox
            // 
            this.NiveauBox.FormattingEnabled = true;
            this.NiveauBox.Location = new System.Drawing.Point(557, 38);
            this.NiveauBox.Name = "NiveauBox";
            this.NiveauBox.Size = new System.Drawing.Size(152, 28);
            this.NiveauBox.TabIndex = 1;
            this.NiveauBox.SelectedIndexChanged += new System.EventHandler(this.NiveauBox_SelectedIndexChanged_1);
            // 
            // MatiereBox
            // 
            this.MatiereBox.FormattingEnabled = true;
            this.MatiereBox.Location = new System.Drawing.Point(130, 87);
            this.MatiereBox.Name = "MatiereBox";
            this.MatiereBox.Size = new System.Drawing.Size(152, 28);
            this.MatiereBox.TabIndex = 2;
            // 
            // FiliereLabel
            // 
            this.FiliereLabel.AutoSize = true;
            this.FiliereLabel.Location = new System.Drawing.Point(23, 38);
            this.FiliereLabel.Name = "FiliereLabel";
            this.FiliereLabel.Size = new System.Drawing.Size(51, 20);
            this.FiliereLabel.TabIndex = 3;
            this.FiliereLabel.Text = "Filière";
            // 
            // NiveauLabel
            // 
            this.NiveauLabel.AutoSize = true;
            this.NiveauLabel.Location = new System.Drawing.Point(437, 41);
            this.NiveauLabel.Name = "NiveauLabel";
            this.NiveauLabel.Size = new System.Drawing.Size(57, 20);
            this.NiveauLabel.TabIndex = 4;
            this.NiveauLabel.Text = "Niveau";
            this.NiveauLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // MatiereLabel
            // 
            this.MatiereLabel.AutoSize = true;
            this.MatiereLabel.Location = new System.Drawing.Point(23, 90);
            this.MatiereLabel.Name = "MatiereLabel";
            this.MatiereLabel.Size = new System.Drawing.Size(62, 20);
            this.MatiereLabel.TabIndex = 5;
            this.MatiereLabel.Text = "Matière";
            // 
            // Rechercher
            // 
            this.Rechercher.Location = new System.Drawing.Point(519, 90);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(190, 34);
            this.Rechercher.TabIndex = 7;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.UseVisualStyleBackColor = true;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // Notes_Eleves
            // 
            this.Notes_Eleves.AllowUserToOrderColumns = true;
            this.Notes_Eleves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Notes_Eleves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.Nom,
            this.Prenom,
            this.note});
            this.Notes_Eleves.Location = new System.Drawing.Point(27, 146);
            this.Notes_Eleves.Name = "Notes_Eleves";
            this.Notes_Eleves.ReadOnly = true;
            this.Notes_Eleves.RowHeadersWidth = 62;
            this.Notes_Eleves.RowTemplate.Height = 28;
            this.Notes_Eleves.Size = new System.Drawing.Size(682, 239);
            this.Notes_Eleves.TabIndex = 9;
            // 
            // Moyenne_classe
            // 
            this.Moyenne_classe.AutoSize = true;
            this.Moyenne_classe.Location = new System.Drawing.Point(56, 409);
            this.Moyenne_classe.Name = "Moyenne_classe";
            this.Moyenne_classe.Size = new System.Drawing.Size(161, 20);
            this.Moyenne_classe.TabIndex = 6;
            this.Moyenne_classe.Text = "Moyenne de la classe";
            // 
            // Moyenne
            // 
            this.Moyenne.Location = new System.Drawing.Point(233, 403);
            this.Moyenne.Name = "Moyenne";
            this.Moyenne.ReadOnly = true;
            this.Moyenne.Size = new System.Drawing.Size(243, 26);
            this.Moyenne.TabIndex = 10;
            this.Moyenne.TextChanged += new System.EventHandler(this.Moyenne_TextChanged);
            // 
            // code
            // 
            this.code.DataPropertyName = "string";
            this.code.Frozen = true;
            this.code.HeaderText = "Code";
            this.code.MinimumWidth = 8;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 120;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "string";
            this.Nom.Frozen = true;
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 8;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 120;
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "string";
            this.Prenom.Frozen = true;
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.MinimumWidth = 8;
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            this.Prenom.Width = 120;
            // 
            // note
            // 
            this.note.DataPropertyName = "decimal";
            this.note.Frozen = true;
            this.note.HeaderText = "Note";
            this.note.MinimumWidth = 8;
            this.note.Name = "note";
            this.note.ReadOnly = true;
            this.note.Width = 120;
            // 
            // ConsultationNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.Moyenne);
            this.Controls.Add(this.Notes_Eleves);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.Moyenne_classe);
            this.Controls.Add(this.MatiereLabel);
            this.Controls.Add(this.NiveauLabel);
            this.Controls.Add(this.FiliereLabel);
            this.Controls.Add(this.MatiereBox);
            this.Controls.Add(this.NiveauBox);
            this.Controls.Add(this.FiliereBox);
            this.Name = "ConsultationNotes";
            this.Text = "ConsultationNotes";
            this.Load += new System.EventHandler(this.ConsultationNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notes_Eleves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FiliereBox;
        private System.Windows.Forms.ComboBox NiveauBox;
        private System.Windows.Forms.ComboBox MatiereBox;
        private System.Windows.Forms.Label FiliereLabel;
        private System.Windows.Forms.Label NiveauLabel;
        private System.Windows.Forms.Label MatiereLabel;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.DataGridView Notes_Eleves;
        private System.Windows.Forms.Label Moyenne_classe;
        private System.Windows.Forms.TextBox Moyenne;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
    }
}