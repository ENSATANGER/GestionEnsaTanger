namespace GestionEnsaTanger
{
    partial class GestionEtudiants
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filieresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matieresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListNiveau = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListFiliere = new System.Windows.Forms.ComboBox();
            this.buttonNouveau = new System.Windows.Forms.Button();
            this.buttonGestionAbsence = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textCode = new System.Windows.Forms.TextBox();
            this.filiere = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.gestionToolStripMenuItem,
            this.affichageToolStripMenuItem,
            this.bilanToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filieresToolStripMenuItem,
            this.matieresToolStripMenuItem,
            this.etudiantsToolStripMenuItem,
            this.notesToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // filieresToolStripMenuItem
            // 
            this.filieresToolStripMenuItem.Name = "filieresToolStripMenuItem";
            this.filieresToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.filieresToolStripMenuItem.Text = "Filieres";
            // 
            // matieresToolStripMenuItem
            // 
            this.matieresToolStripMenuItem.Name = "matieresToolStripMenuItem";
            this.matieresToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.matieresToolStripMenuItem.Text = "Matieres";
            // 
            // etudiantsToolStripMenuItem
            // 
            this.etudiantsToolStripMenuItem.Name = "etudiantsToolStripMenuItem";
            this.etudiantsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.etudiantsToolStripMenuItem.Text = "Etudiants";
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.notesToolStripMenuItem.Text = "Notes";
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // bilanToolStripMenuItem
            // 
            this.bilanToolStripMenuItem.Name = "bilanToolStripMenuItem";
            this.bilanToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.bilanToolStripMenuItem.Text = "Bilan";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // ListNiveau
            // 
            this.ListNiveau.FormattingEnabled = true;
            this.ListNiveau.Location = new System.Drawing.Point(259, 185);
            this.ListNiveau.Name = "ListNiveau";
            this.ListNiveau.Size = new System.Drawing.Size(162, 21);
            this.ListNiveau.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Niveau";
            // 
            // ListFiliere
            // 
            this.ListFiliere.FormattingEnabled = true;
            this.ListFiliere.Location = new System.Drawing.Point(259, 152);
            this.ListFiliere.Name = "ListFiliere";
            this.ListFiliere.Size = new System.Drawing.Size(162, 21);
            this.ListFiliere.TabIndex = 46;
            // 
            // buttonNouveau
            // 
            this.buttonNouveau.Location = new System.Drawing.Point(472, 42);
            this.buttonNouveau.Name = "buttonNouveau";
            this.buttonNouveau.Size = new System.Drawing.Size(141, 22);
            this.buttonNouveau.TabIndex = 45;
            this.buttonNouveau.Text = "Nouveau";
            this.buttonNouveau.UseVisualStyleBackColor = true;
            // 
            // buttonGestionAbsence
            // 
            this.buttonGestionAbsence.Location = new System.Drawing.Point(472, 185);
            this.buttonGestionAbsence.Name = "buttonGestionAbsence";
            this.buttonGestionAbsence.Size = new System.Drawing.Size(141, 24);
            this.buttonGestionAbsence.TabIndex = 43;
            this.buttonGestionAbsence.Text = "Gestion d\'absence";
            this.buttonGestionAbsence.UseVisualStyleBackColor = true;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(472, 158);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(141, 21);
            this.buttonRechercher.TabIndex = 42;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(472, 127);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(141, 25);
            this.buttonSupprimer.TabIndex = 41;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(472, 99);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(141, 22);
            this.buttonModifier.TabIndex = 40;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(472, 70);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(141, 23);
            this.buttonAjouter.TabIndex = 39;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(259, 83);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(162, 20);
            this.textNom.TabIndex = 38;
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(259, 117);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(162, 20);
            this.textPrenom.TabIndex = 37;
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(259, 48);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(162, 20);
            this.textCode.TabIndex = 36;
            // 
            // filiere
            // 
            this.filiere.AutoSize = true;
            this.filiere.Location = new System.Drawing.Point(192, 155);
            this.filiere.Name = "filiere";
            this.filiere.Size = new System.Drawing.Size(34, 13);
            this.filiere.TabIndex = 35;
            this.filiere.Text = "Filière";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(192, 120);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(54, 13);
            this.prenom.TabIndex = 34;
            this.prenom.Text = "PRENOM";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(192, 86);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(32, 13);
            this.nom.TabIndex = 33;
            this.nom.Text = "NOM";
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Location = new System.Drawing.Point(192, 48);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(32, 13);
            this.code.TabIndex = 32;
            this.code.Text = "Code";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(141, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 206);
            this.dataGridView1.TabIndex = 50;
            // 
            // GestionEtudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ListNiveau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListFiliere);
            this.Controls.Add(this.buttonNouveau);
            this.Controls.Add(this.buttonGestionAbsence);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.filiere);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.code);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestionEtudiants";
            this.Text = "Gestion des étudiants";
            this.Load += new System.EventHandler(this.GestionEtudiants_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filieresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matieresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ComboBox ListNiveau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListFiliere;
        private System.Windows.Forms.Button buttonNouveau;
        private System.Windows.Forms.Button buttonGestionAbsence;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Label filiere;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}