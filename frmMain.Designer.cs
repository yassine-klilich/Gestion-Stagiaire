namespace Gestion_Stagiaires
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbChercherStagiaire = new System.Windows.Forms.TextBox();
            this.dgvStagiaires = new System.Windows.Forms.DataGridView();
            this.cmbModeSelection = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbGestionStagiaire = new System.Windows.Forms.GroupBox();
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.btnRetirer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.ckbAjouterSansFormation = new System.Windows.Forms.CheckBox();
            this.cmbFormation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGestionAffichage = new System.Windows.Forms.GroupBox();
            this.txbDescriptionFormation = new System.Windows.Forms.TextBox();
            this.lstvFormations = new System.Windows.Forms.ListView();
            this.IDFormation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnModifierFormation = new System.Windows.Forms.Button();
            this.btnSupprimerFormation = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAjouterFormation = new System.Windows.Forms.Button();
            this.lblHeure = new System.Windows.Forms.Label();
            this.tmrHeure = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStagiaires)).BeginInit();
            this.gbGestionStagiaire.SuspendLayout();
            this.gbOperations.SuspendLayout();
            this.gbGestionAffichage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbChercherStagiaire);
            this.groupBox1.Controls.Add(this.dgvStagiaires);
            this.groupBox1.Controls.Add(this.cmbModeSelection);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Afficher les stagiaires";
            // 
            // txbChercherStagiaire
            // 
            this.txbChercherStagiaire.Location = new System.Drawing.Point(528, 315);
            this.txbChercherStagiaire.Name = "txbChercherStagiaire";
            this.txbChercherStagiaire.Size = new System.Drawing.Size(160, 24);
            this.txbChercherStagiaire.TabIndex = 2;
            this.txbChercherStagiaire.TextChanged += new System.EventHandler(this.txbChercherStagiaire_TextChanged);
            // 
            // dgvStagiaires
            // 
            this.dgvStagiaires.AllowUserToResizeRows = false;
            this.dgvStagiaires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStagiaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStagiaires.Location = new System.Drawing.Point(6, 23);
            this.dgvStagiaires.MultiSelect = false;
            this.dgvStagiaires.Name = "dgvStagiaires";
            this.dgvStagiaires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStagiaires.Size = new System.Drawing.Size(741, 283);
            this.dgvStagiaires.TabIndex = 0;
            this.dgvStagiaires.TabStop = false;
            this.dgvStagiaires.SelectionChanged += new System.EventHandler(this.dgvStagiaires_SelectionChanged);
            // 
            // cmbModeSelection
            // 
            this.cmbModeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModeSelection.FormattingEnabled = true;
            this.cmbModeSelection.Location = new System.Drawing.Point(240, 314);
            this.cmbModeSelection.Name = "cmbModeSelection";
            this.cmbModeSelection.Size = new System.Drawing.Size(115, 26);
            this.cmbModeSelection.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Afficher stagiaire :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Afficher stagiaires par formation :";
            // 
            // gbGestionStagiaire
            // 
            this.gbGestionStagiaire.Controls.Add(this.gbOperations);
            this.gbGestionStagiaire.Controls.Add(this.ckbAjouterSansFormation);
            this.gbGestionStagiaire.Controls.Add(this.cmbFormation);
            this.gbGestionStagiaire.Controls.Add(this.label4);
            this.gbGestionStagiaire.Controls.Add(this.label3);
            this.gbGestionStagiaire.Controls.Add(this.label2);
            this.gbGestionStagiaire.Controls.Add(this.dtpDateNaissance);
            this.gbGestionStagiaire.Controls.Add(this.txbPrenom);
            this.gbGestionStagiaire.Controls.Add(this.txbNom);
            this.gbGestionStagiaire.Controls.Add(this.label1);
            this.gbGestionStagiaire.Location = new System.Drawing.Point(7, 361);
            this.gbGestionStagiaire.Name = "gbGestionStagiaire";
            this.gbGestionStagiaire.Size = new System.Drawing.Size(440, 258);
            this.gbGestionStagiaire.TabIndex = 1;
            this.gbGestionStagiaire.TabStop = false;
            this.gbGestionStagiaire.Text = "Gestion de stagiaires";
            // 
            // gbOperations
            // 
            this.gbOperations.Controls.Add(this.btnRetirer);
            this.gbOperations.Controls.Add(this.btnSupprimer);
            this.gbOperations.Controls.Add(this.btnModifier);
            this.gbOperations.Controls.Add(this.btnAjouter);
            this.gbOperations.Location = new System.Drawing.Point(13, 177);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(413, 71);
            this.gbOperations.TabIndex = 6;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "Operations";
            // 
            // btnRetirer
            // 
            this.btnRetirer.Location = new System.Drawing.Point(309, 26);
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.Size = new System.Drawing.Size(94, 34);
            this.btnRetirer.TabIndex = 9;
            this.btnRetirer.Text = "Retirer";
            this.btnRetirer.UseVisualStyleBackColor = true;
            this.btnRetirer.Click += new System.EventHandler(this.btnRetirer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(209, 26);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(94, 34);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(109, 26);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(94, 34);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(9, 26);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(94, 34);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // ckbAjouterSansFormation
            // 
            this.ckbAjouterSansFormation.AutoSize = true;
            this.ckbAjouterSansFormation.Location = new System.Drawing.Point(179, 149);
            this.ckbAjouterSansFormation.Name = "ckbAjouterSansFormation";
            this.ckbAjouterSansFormation.Size = new System.Drawing.Size(235, 22);
            this.ckbAjouterSansFormation.TabIndex = 5;
            this.ckbAjouterSansFormation.Text = "Ajouter stagiaire sans formation";
            this.ckbAjouterSansFormation.UseVisualStyleBackColor = true;
            this.ckbAjouterSansFormation.CheckedChanged += new System.EventHandler(this.ckbAjouter_CheckedChanged);
            // 
            // cmbFormation
            // 
            this.cmbFormation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormation.FormattingEnabled = true;
            this.cmbFormation.Location = new System.Drawing.Point(179, 117);
            this.cmbFormation.Name = "cmbFormation";
            this.cmbFormation.Size = new System.Drawing.Size(95, 26);
            this.cmbFormation.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Formation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date de naissance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenom";
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDateNaissance.Location = new System.Drawing.Point(179, 88);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(200, 23);
            this.dtpDateNaissance.TabIndex = 3;
            // 
            // txbPrenom
            // 
            this.txbPrenom.Location = new System.Drawing.Point(179, 58);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(200, 24);
            this.txbPrenom.TabIndex = 2;
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(179, 28);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(200, 24);
            this.txbNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // gbGestionAffichage
            // 
            this.gbGestionAffichage.Controls.Add(this.txbDescriptionFormation);
            this.gbGestionAffichage.Controls.Add(this.lstvFormations);
            this.gbGestionAffichage.Controls.Add(this.btnModifierFormation);
            this.gbGestionAffichage.Controls.Add(this.btnSupprimerFormation);
            this.gbGestionAffichage.Controls.Add(this.label7);
            this.gbGestionAffichage.Controls.Add(this.btnAjouterFormation);
            this.gbGestionAffichage.Location = new System.Drawing.Point(453, 361);
            this.gbGestionAffichage.Name = "gbGestionAffichage";
            this.gbGestionAffichage.Size = new System.Drawing.Size(307, 231);
            this.gbGestionAffichage.TabIndex = 7;
            this.gbGestionAffichage.TabStop = false;
            this.gbGestionAffichage.Text = "Gestion de formations";
            // 
            // txbDescriptionFormation
            // 
            this.txbDescriptionFormation.Location = new System.Drawing.Point(108, 152);
            this.txbDescriptionFormation.Name = "txbDescriptionFormation";
            this.txbDescriptionFormation.Size = new System.Drawing.Size(134, 24);
            this.txbDescriptionFormation.TabIndex = 12;
            // 
            // lstvFormations
            // 
            this.lstvFormations.BackColor = System.Drawing.SystemColors.Window;
            this.lstvFormations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstvFormations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDFormation,
            this.Description});
            this.lstvFormations.FullRowSelect = true;
            this.lstvFormations.GridLines = true;
            this.lstvFormations.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstvFormations.HideSelection = false;
            this.lstvFormations.Location = new System.Drawing.Point(10, 28);
            this.lstvFormations.MultiSelect = false;
            this.lstvFormations.Name = "lstvFormations";
            this.lstvFormations.Size = new System.Drawing.Size(288, 115);
            this.lstvFormations.TabIndex = 1;
            this.lstvFormations.TabStop = false;
            this.lstvFormations.UseCompatibleStateImageBehavior = false;
            this.lstvFormations.View = System.Windows.Forms.View.Details;
            this.lstvFormations.SelectedIndexChanged += new System.EventHandler(this.lstvFormations_SelectedIndexChanged);
            // 
            // IDFormation
            // 
            this.IDFormation.Text = "ID Formation";
            this.IDFormation.Width = 106;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 106;
            // 
            // btnModifierFormation
            // 
            this.btnModifierFormation.Location = new System.Drawing.Point(108, 185);
            this.btnModifierFormation.Name = "btnModifierFormation";
            this.btnModifierFormation.Size = new System.Drawing.Size(92, 34);
            this.btnModifierFormation.TabIndex = 14;
            this.btnModifierFormation.Text = "Modifier";
            this.btnModifierFormation.UseVisualStyleBackColor = true;
            this.btnModifierFormation.Click += new System.EventHandler(this.btnModifierFormation_Click);
            // 
            // btnSupprimerFormation
            // 
            this.btnSupprimerFormation.Location = new System.Drawing.Point(206, 185);
            this.btnSupprimerFormation.Name = "btnSupprimerFormation";
            this.btnSupprimerFormation.Size = new System.Drawing.Size(92, 34);
            this.btnSupprimerFormation.TabIndex = 15;
            this.btnSupprimerFormation.Text = "Supprimer";
            this.btnSupprimerFormation.UseVisualStyleBackColor = true;
            this.btnSupprimerFormation.Click += new System.EventHandler(this.btnSupprimerFormation_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Description :";
            // 
            // btnAjouterFormation
            // 
            this.btnAjouterFormation.Location = new System.Drawing.Point(10, 185);
            this.btnAjouterFormation.Name = "btnAjouterFormation";
            this.btnAjouterFormation.Size = new System.Drawing.Size(92, 34);
            this.btnAjouterFormation.TabIndex = 13;
            this.btnAjouterFormation.Text = "Ajouter";
            this.btnAjouterFormation.UseVisualStyleBackColor = true;
            this.btnAjouterFormation.Click += new System.EventHandler(this.btnAjouterFormation_Click);
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblHeure.Location = new System.Drawing.Point(679, 597);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(81, 22);
            this.lblHeure.TabIndex = 8;
            this.lblHeure.Text = "Heure ici";
            // 
            // tmrHeure
            // 
            this.tmrHeure.Tick += new System.EventHandler(this.tmrHeure_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 627);
            this.Controls.Add(this.lblHeure);
            this.Controls.Add(this.gbGestionStagiaire);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbGestionAffichage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Stagiaire";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStagiaires)).EndInit();
            this.gbGestionStagiaire.ResumeLayout(false);
            this.gbGestionStagiaire.PerformLayout();
            this.gbOperations.ResumeLayout(false);
            this.gbGestionAffichage.ResumeLayout(false);
            this.gbGestionAffichage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbGestionStagiaire;
        private System.Windows.Forms.DataGridView dgvStagiaires;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.TextBox txbPrenom;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox cmbFormation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbAjouterSansFormation;
        private System.Windows.Forms.GroupBox gbOperations;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnRetirer;
        private System.Windows.Forms.ComboBox cmbModeSelection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbGestionAffichage;
        private System.Windows.Forms.Button btnModifierFormation;
        private System.Windows.Forms.Button btnSupprimerFormation;
        private System.Windows.Forms.Button btnAjouterFormation;
        private System.Windows.Forms.TextBox txbChercherStagiaire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbDescriptionFormation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Timer tmrHeure;
        private System.Windows.Forms.ColumnHeader IDFormation;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ListView lstvFormations;
    }
}

