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
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moyenne_classe = new System.Windows.Forms.Label();
            this.Moyenne = new System.Windows.Forms.TextBox();
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
            // 
            // NiveauBox
            // 
            this.NiveauBox.FormattingEnabled = true;
            this.NiveauBox.Location = new System.Drawing.Point(557, 38);
            this.NiveauBox.Name = "NiveauBox";
            this.NiveauBox.Size = new System.Drawing.Size(152, 28);
            this.NiveauBox.TabIndex = 1;
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
            this.Code,
            this.Nom,
            this.Prénom,
            this.Note});
            this.Notes_Eleves.Location = new System.Drawing.Point(27, 146);
            this.Notes_Eleves.Name = "Notes_Eleves";
            this.Notes_Eleves.ReadOnly = true;
            this.Notes_Eleves.RowHeadersWidth = 62;
            this.Notes_Eleves.RowTemplate.Height = 28;
            this.Notes_Eleves.Size = new System.Drawing.Size(682, 239);
            this.Notes_Eleves.TabIndex = 9;
            // 
            // Code
            // 
            this.Code.Frozen = true;
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 8;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 150;
            // 
            // Nom
            // 
            this.Nom.Frozen = true;
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 8;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 150;
            // 
            // Prénom
            // 
            this.Prénom.Frozen = true;
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.MinimumWidth = 8;
            this.Prénom.Name = "Prénom";
            this.Prénom.ReadOnly = true;
            this.Prénom.Width = 150;
            // 
            // Note
            // 
            this.Note.Frozen = true;
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 8;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 120;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}
