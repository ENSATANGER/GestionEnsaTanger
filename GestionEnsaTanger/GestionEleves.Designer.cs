namespace GestionEnsaTanger
{
    partial class GestionEleves
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
            this.buttonGestionAbsence = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.filiereLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.filiere = new System.Windows.Forms.ComboBox();
            this.ElevesTable = new System.Windows.Forms.DataGridView();
            this.buttonNouveau = new System.Windows.Forms.Button();
            this.niveau = new System.Windows.Forms.ComboBox();
            this.niveauLabel = new System.Windows.Forms.Label();
            this.checkBoxCode = new System.Windows.Forms.CheckBox();
            this.checkBoxNiveau = new System.Windows.Forms.CheckBox();
            this.checkBoxFiliere = new System.Windows.Forms.CheckBox();
            this.checkBoxPrenom = new System.Windows.Forms.CheckBox();
            this.checkBoxNom = new System.Windows.Forms.CheckBox();
            this.ElevesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElevesNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElevesPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElevesGroupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableCode_Fil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ElevesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGestionAbsence
            // 
            this.buttonGestionAbsence.Location = new System.Drawing.Point(496, 172);
            this.buttonGestionAbsence.Name = "buttonGestionAbsence";
            this.buttonGestionAbsence.Size = new System.Drawing.Size(141, 21);
            this.buttonGestionAbsence.TabIndex = 26;
            this.buttonGestionAbsence.Text = "Gestion d\'absence";
            this.buttonGestionAbsence.UseVisualStyleBackColor = true;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(496, 145);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(141, 21);
            this.buttonRechercher.TabIndex = 25;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(496, 116);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(141, 23);
            this.buttonSupprimer.TabIndex = 24;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(496, 87);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(141, 23);
            this.buttonModifier.TabIndex = 23;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(496, 56);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(141, 25);
            this.buttonAjouter.TabIndex = 22;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(276, 67);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(162, 20);
            this.nom.TabIndex = 21;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(276, 96);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(162, 20);
            this.prenom.TabIndex = 20;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(276, 34);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(162, 20);
            this.code.TabIndex = 18;
            // 
            // filiereLabel
            // 
            this.filiereLabel.AutoSize = true;
            this.filiereLabel.Location = new System.Drawing.Point(179, 130);
            this.filiereLabel.Name = "filiereLabel";
            this.filiereLabel.Size = new System.Drawing.Size(34, 13);
            this.filiereLabel.TabIndex = 17;
            this.filiereLabel.Text = "Filiere";
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Location = new System.Drawing.Point(179, 99);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(54, 13);
            this.prenomLabel.TabIndex = 16;
            this.prenomLabel.Text = "PRENOM";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(179, 70);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(32, 13);
            this.nomLabel.TabIndex = 15;
            this.nomLabel.Text = "NOM";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(179, 37);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(32, 13);
            this.codeLabel.TabIndex = 14;
            this.codeLabel.Text = "Code";
            // 
            // filiere
            // 
            this.filiere.FormattingEnabled = true;
            this.filiere.Location = new System.Drawing.Point(276, 127);
            this.filiere.Name = "filiere";
            this.filiere.Size = new System.Drawing.Size(162, 21);
            this.filiere.TabIndex = 28;
            // 
            // ElevesTable
            // 
            this.ElevesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ElevesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ElevesID,
            this.ElevesNom,
            this.ElevesPrenom,
            this.ElevesGroupe,
            this.TableCode_Fil});
            this.ElevesTable.Location = new System.Drawing.Point(145, 217);
            this.ElevesTable.Name = "ElevesTable";
            this.ElevesTable.Size = new System.Drawing.Size(543, 150);
            this.ElevesTable.TabIndex = 27;
            // 
            // buttonNouveau
            // 
            this.buttonNouveau.Location = new System.Drawing.Point(496, 27);
            this.buttonNouveau.Name = "buttonNouveau";
            this.buttonNouveau.Size = new System.Drawing.Size(141, 23);
            this.buttonNouveau.TabIndex = 29;
            this.buttonNouveau.Text = "Nouveau";
            this.buttonNouveau.UseVisualStyleBackColor = true;
            // 
            // niveau
            // 
            this.niveau.FormattingEnabled = true;
            this.niveau.Location = new System.Drawing.Point(276, 162);
            this.niveau.Name = "niveau";
            this.niveau.Size = new System.Drawing.Size(162, 21);
            this.niveau.TabIndex = 31;
            // 
            // niveauLabel
            // 
            this.niveauLabel.AutoSize = true;
            this.niveauLabel.Location = new System.Drawing.Point(179, 165);
            this.niveauLabel.Name = "niveauLabel";
            this.niveauLabel.Size = new System.Drawing.Size(41, 13);
            this.niveauLabel.TabIndex = 30;
            this.niveauLabel.Text = "Niveau";
            // 
            // checkBoxCode
            // 
            this.checkBoxCode.AutoSize = true;
            this.checkBoxCode.Location = new System.Drawing.Point(444, 37);
            this.checkBoxCode.Name = "checkBoxCode";
            this.checkBoxCode.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCode.TabIndex = 32;
            this.checkBoxCode.UseVisualStyleBackColor = true;
            // 
            // checkBoxNiveau
            // 
            this.checkBoxNiveau.AutoSize = true;
            this.checkBoxNiveau.Location = new System.Drawing.Point(444, 164);
            this.checkBoxNiveau.Name = "checkBoxNiveau";
            this.checkBoxNiveau.Size = new System.Drawing.Size(15, 14);
            this.checkBoxNiveau.TabIndex = 33;
            this.checkBoxNiveau.UseVisualStyleBackColor = true;
            // 
            // checkBoxFiliere
            // 
            this.checkBoxFiliere.AutoSize = true;
            this.checkBoxFiliere.Location = new System.Drawing.Point(444, 130);
            this.checkBoxFiliere.Name = "checkBoxFiliere";
            this.checkBoxFiliere.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFiliere.TabIndex = 34;
            this.checkBoxFiliere.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrenom
            // 
            this.checkBoxPrenom.AutoSize = true;
            this.checkBoxPrenom.Location = new System.Drawing.Point(444, 99);
            this.checkBoxPrenom.Name = "checkBoxPrenom";
            this.checkBoxPrenom.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPrenom.TabIndex = 35;
            this.checkBoxPrenom.UseVisualStyleBackColor = true;
            // 
            // checkBoxNom
            // 
            this.checkBoxNom.AutoSize = true;
            this.checkBoxNom.Location = new System.Drawing.Point(444, 70);
            this.checkBoxNom.Name = "checkBoxNom";
            this.checkBoxNom.Size = new System.Drawing.Size(15, 14);
            this.checkBoxNom.TabIndex = 36;
            this.checkBoxNom.UseVisualStyleBackColor = true;
            // 
            // ElevesID
            // 
            this.ElevesID.DataPropertyName = "TableCode";
            this.ElevesID.HeaderText = "CodeElev";
            this.ElevesID.Name = "ElevesID";
            // 
            // ElevesNom
            // 
            this.ElevesNom.DataPropertyName = "TableNom";
            this.ElevesNom.HeaderText = "Nom";
            this.ElevesNom.Name = "ElevesNom";
            // 
            // ElevesPrenom
            // 
            this.ElevesPrenom.DataPropertyName = "TablePrenom";
            this.ElevesPrenom.HeaderText = "Prenom";
            this.ElevesPrenom.Name = "ElevesPrenom";
            // 
            // ElevesGroupe
            // 
            this.ElevesGroupe.DataPropertyName = "TableNiveau";
            this.ElevesGroupe.HeaderText = "Niveau";
            this.ElevesGroupe.Name = "ElevesGroupe";
            // 
            // TableCode_Fil
            // 
            this.TableCode_Fil.HeaderText = "code_Fil";
            this.TableCode_Fil.Name = "TableCode_Fil";
            // 
            // GestionEleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 448);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxNom);
            this.Controls.Add(this.checkBoxPrenom);
            this.Controls.Add(this.checkBoxFiliere);
            this.Controls.Add(this.checkBoxNiveau);
            this.Controls.Add(this.checkBoxCode);
            this.Controls.Add(this.niveau);
            this.Controls.Add(this.niveauLabel);
            this.Controls.Add(this.buttonNouveau);
            this.Controls.Add(this.filiere);
            this.Controls.Add(this.ElevesTable);
            this.Controls.Add(this.buttonGestionAbsence);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.code);
            this.Controls.Add(this.filiereLabel);
            this.Controls.Add(this.prenomLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.codeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionEleves";
            this.Text = "GestionEleves";
            ((System.ComponentModel.ISupportInitialize)(this.ElevesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGestionAbsence;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label filiereLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.ComboBox filiere;
        private System.Windows.Forms.DataGridView ElevesTable;
        private System.Windows.Forms.Button buttonNouveau;
        private System.Windows.Forms.ComboBox niveau;
        private System.Windows.Forms.Label niveauLabel;
        private System.Windows.Forms.CheckBox checkBoxCode;
        private System.Windows.Forms.CheckBox checkBoxNiveau;
        private System.Windows.Forms.CheckBox checkBoxFiliere;
        private System.Windows.Forms.CheckBox checkBoxPrenom;
        private System.Windows.Forms.CheckBox checkBoxNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevesNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevesPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevesGroupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableCode_Fil;
    }
}