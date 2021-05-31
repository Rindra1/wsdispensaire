namespace Dispensaire
{
    partial class AccueilDocteur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btNouveau = new System.Windows.Forms.Button();
            this.dgvResultatRecherche = new System.Windows.Forms.DataGridView();
            this._personne_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._personne_adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._personne_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._personne_telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._allergie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._asthme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._hospitaliser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._chirurgie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._diabete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._hta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._allergie_medicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._diagnostique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dureeT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._traitement_anterieur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._drvdsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._personne_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._personne_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRechercherPatient = new System.Windows.Forms.Button();
            this.txtRecherchePrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRechercheNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btDetail = new System.Windows.Forms.Button();
            this.btOrdonnance = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDrvTdsp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTraitementAnt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDureeT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiagnostic = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAllergMed = new System.Windows.Forms.TextBox();
            this.chkHta = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkDiabete = new System.Windows.Forms.CheckBox();
            this.chkChirurgie = new System.Windows.Forms.CheckBox();
            this.chkHosp = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAdr = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.chkF = new System.Windows.Forms.CheckBox();
            this.chkM = new System.Windows.Forms.CheckBox();
            this.chkAllergie = new System.Windows.Forms.CheckBox();
            this.chkAsthme = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultatRecherche)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 80);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1102, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 520);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btNouveau);
            this.groupBox1.Controls.Add(this.dgvResultatRecherche);
            this.groupBox1.Controls.Add(this.btRechercherPatient);
            this.groupBox1.Controls.Add(this.txtRecherchePrenom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRechercheNom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 520);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultat Recherche";
            // 
            // btNouveau
            // 
            this.btNouveau.BackColor = System.Drawing.Color.Blue;
            this.btNouveau.ForeColor = System.Drawing.Color.White;
            this.btNouveau.Location = new System.Drawing.Point(469, 474);
            this.btNouveau.Name = "btNouveau";
            this.btNouveau.Size = new System.Drawing.Size(116, 34);
            this.btNouveau.TabIndex = 6;
            this.btNouveau.Text = "Nouveau";
            this.btNouveau.UseVisualStyleBackColor = false;
            this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
            // 
            // dgvResultatRecherche
            // 
            this.dgvResultatRecherche.AllowUserToAddRows = false;
            this.dgvResultatRecherche.AllowUserToDeleteRows = false;
            this.dgvResultatRecherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultatRecherche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._personne_id,
            this._personne_adresse,
            this._personne_age,
            this._personne_telephone,
            this._allergie,
            this._asthme,
            this._hospitaliser,
            this._chirurgie,
            this._diabete,
            this._hta,
            this._allergie_medicament,
            this._diagnostique,
            this._dureeT,
            this._traitement_anterieur,
            this._drvdsp,
            this._personne_nom,
            this._personne_prenom,
            this.sexe});
            this.dgvResultatRecherche.Location = new System.Drawing.Point(10, 155);
            this.dgvResultatRecherche.Name = "dgvResultatRecherche";
            this.dgvResultatRecherche.ReadOnly = true;
            this.dgvResultatRecherche.Size = new System.Drawing.Size(575, 305);
            this.dgvResultatRecherche.TabIndex = 5;
            this.dgvResultatRecherche.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultatRecherche_CellContentClick);
            // 
            // _personne_id
            // 
            this._personne_id.HeaderText = "ID";
            this._personne_id.Name = "_personne_id";
            this._personne_id.ReadOnly = true;
            this._personne_id.Visible = false;
            // 
            // _personne_adresse
            // 
            this._personne_adresse.HeaderText = "Adresse";
            this._personne_adresse.Name = "_personne_adresse";
            this._personne_adresse.ReadOnly = true;
            this._personne_adresse.Visible = false;
            // 
            // _personne_age
            // 
            this._personne_age.HeaderText = "Age";
            this._personne_age.Name = "_personne_age";
            this._personne_age.ReadOnly = true;
            this._personne_age.Visible = false;
            // 
            // _personne_telephone
            // 
            this._personne_telephone.HeaderText = "Telephone";
            this._personne_telephone.Name = "_personne_telephone";
            this._personne_telephone.ReadOnly = true;
            this._personne_telephone.Visible = false;
            // 
            // _allergie
            // 
            this._allergie.HeaderText = "Allergie";
            this._allergie.Name = "_allergie";
            this._allergie.ReadOnly = true;
            this._allergie.Visible = false;
            // 
            // _asthme
            // 
            this._asthme.HeaderText = "Asthme";
            this._asthme.Name = "_asthme";
            this._asthme.ReadOnly = true;
            this._asthme.Visible = false;
            // 
            // _hospitaliser
            // 
            this._hospitaliser.HeaderText = "Hospitaliser";
            this._hospitaliser.Name = "_hospitaliser";
            this._hospitaliser.ReadOnly = true;
            this._hospitaliser.Visible = false;
            // 
            // _chirurgie
            // 
            this._chirurgie.HeaderText = "Chirurgie";
            this._chirurgie.Name = "_chirurgie";
            this._chirurgie.ReadOnly = true;
            this._chirurgie.Visible = false;
            // 
            // _diabete
            // 
            this._diabete.HeaderText = "Diabete";
            this._diabete.Name = "_diabete";
            this._diabete.ReadOnly = true;
            this._diabete.Visible = false;
            // 
            // _hta
            // 
            this._hta.HeaderText = "HTA";
            this._hta.Name = "_hta";
            this._hta.ReadOnly = true;
            this._hta.Visible = false;
            // 
            // _allergie_medicament
            // 
            this._allergie_medicament.HeaderText = "Allergie Medicament";
            this._allergie_medicament.Name = "_allergie_medicament";
            this._allergie_medicament.ReadOnly = true;
            this._allergie_medicament.Visible = false;
            // 
            // _diagnostique
            // 
            this._diagnostique.HeaderText = "Diagnostic";
            this._diagnostique.Name = "_diagnostique";
            this._diagnostique.ReadOnly = true;
            this._diagnostique.Visible = false;
            // 
            // _dureeT
            // 
            this._dureeT.HeaderText = "Durée T3";
            this._dureeT.Name = "_dureeT";
            this._dureeT.ReadOnly = true;
            this._dureeT.Visible = false;
            // 
            // _traitement_anterieur
            // 
            this._traitement_anterieur.HeaderText = "Traitement Anterieur";
            this._traitement_anterieur.Name = "_traitement_anterieur";
            this._traitement_anterieur.ReadOnly = true;
            this._traitement_anterieur.Visible = false;
            // 
            // _drvdsp
            // 
            this._drvdsp.HeaderText = "DRVTDSP";
            this._drvdsp.Name = "_drvdsp";
            this._drvdsp.ReadOnly = true;
            this._drvdsp.Visible = false;
            // 
            // _personne_nom
            // 
            this._personne_nom.HeaderText = "Nom";
            this._personne_nom.Name = "_personne_nom";
            this._personne_nom.ReadOnly = true;
            this._personne_nom.Width = 300;
            // 
            // _personne_prenom
            // 
            this._personne_prenom.HeaderText = "Prenom";
            this._personne_prenom.Name = "_personne_prenom";
            this._personne_prenom.ReadOnly = true;
            this._personne_prenom.Width = 180;
            // 
            // sexe
            // 
            this.sexe.HeaderText = "Sexe";
            this.sexe.Name = "sexe";
            this.sexe.ReadOnly = true;
            this.sexe.Width = 50;
            // 
            // btRechercherPatient
            // 
            this.btRechercherPatient.BackColor = System.Drawing.Color.Green;
            this.btRechercherPatient.ForeColor = System.Drawing.Color.White;
            this.btRechercherPatient.Location = new System.Drawing.Point(469, 72);
            this.btRechercherPatient.Name = "btRechercherPatient";
            this.btRechercherPatient.Size = new System.Drawing.Size(116, 34);
            this.btRechercherPatient.TabIndex = 4;
            this.btRechercherPatient.Text = "Rechercher";
            this.btRechercherPatient.UseVisualStyleBackColor = false;
            this.btRechercherPatient.Click += new System.EventHandler(this.btRechercherPatient_Click);
            // 
            // txtRecherchePrenom
            // 
            this.txtRecherchePrenom.Location = new System.Drawing.Point(92, 73);
            this.txtRecherchePrenom.Name = "txtRecherchePrenom";
            this.txtRecherchePrenom.Size = new System.Drawing.Size(270, 26);
            this.txtRecherchePrenom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom :";
            // 
            // txtRechercheNom
            // 
            this.txtRechercheNom.Location = new System.Drawing.Point(92, 32);
            this.txtRechercheNom.Name = "txtRechercheNom";
            this.txtRechercheNom.Size = new System.Drawing.Size(270, 26);
            this.txtRechercheNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(600, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 520);
            this.panel3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btDetail);
            this.groupBox2.Controls.Add(this.btOrdonnance);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 520);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infos Patient";
            // 
            // btDetail
            // 
            this.btDetail.BackColor = System.Drawing.Color.Green;
            this.btDetail.ForeColor = System.Drawing.Color.White;
            this.btDetail.Location = new System.Drawing.Point(336, 474);
            this.btDetail.Name = "btDetail";
            this.btDetail.Size = new System.Drawing.Size(116, 34);
            this.btDetail.TabIndex = 8;
            this.btDetail.Text = "Détail";
            this.btDetail.UseVisualStyleBackColor = false;
            this.btDetail.Click += new System.EventHandler(this.btDetail_Click);
            // 
            // btOrdonnance
            // 
            this.btOrdonnance.BackColor = System.Drawing.Color.Blue;
            this.btOrdonnance.ForeColor = System.Drawing.Color.White;
            this.btOrdonnance.Location = new System.Drawing.Point(472, 474);
            this.btOrdonnance.Name = "btOrdonnance";
            this.btOrdonnance.Size = new System.Drawing.Size(116, 34);
            this.btOrdonnance.TabIndex = 8;
            this.btOrdonnance.Text = "Ordonnance";
            this.btOrdonnance.UseVisualStyleBackColor = false;
            this.btOrdonnance.Click += new System.EventHandler(this.btOrdonnance_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDrvTdsp);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtTraitementAnt);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtDureeT);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtDiagnostic);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtAllergMed);
            this.groupBox4.Controls.Add(this.chkHta);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.chkDiabete);
            this.groupBox4.Controls.Add(this.chkChirurgie);
            this.groupBox4.Controls.Add(this.chkHosp);
            this.groupBox4.Location = new System.Drawing.Point(6, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(582, 211);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Antecedent";
            // 
            // txtDrvTdsp
            // 
            this.txtDrvTdsp.Enabled = false;
            this.txtDrvTdsp.Location = new System.Drawing.Point(111, 175);
            this.txtDrvTdsp.Name = "txtDrvTdsp";
            this.txtDrvTdsp.Size = new System.Drawing.Size(209, 26);
            this.txtDrvTdsp.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "DRVTDSP :";
            // 
            // txtTraitementAnt
            // 
            this.txtTraitementAnt.Enabled = false;
            this.txtTraitementAnt.Location = new System.Drawing.Point(191, 139);
            this.txtTraitementAnt.Name = "txtTraitementAnt";
            this.txtTraitementAnt.Size = new System.Drawing.Size(380, 26);
            this.txtTraitementAnt.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Traitement antérieur :";
            // 
            // txtDureeT
            // 
            this.txtDureeT.Enabled = false;
            this.txtDureeT.Location = new System.Drawing.Point(425, 102);
            this.txtDureeT.Name = "txtDureeT";
            this.txtDureeT.Size = new System.Drawing.Size(146, 26);
            this.txtDureeT.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Durée T3 :";
            // 
            // txtDiagnostic
            // 
            this.txtDiagnostic.Enabled = false;
            this.txtDiagnostic.Location = new System.Drawing.Point(113, 102);
            this.txtDiagnostic.Name = "txtDiagnostic";
            this.txtDiagnostic.Size = new System.Drawing.Size(207, 26);
            this.txtDiagnostic.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Diagnostic :";
            // 
            // txtAllergMed
            // 
            this.txtAllergMed.Enabled = false;
            this.txtAllergMed.Location = new System.Drawing.Point(113, 66);
            this.txtAllergMed.Name = "txtAllergMed";
            this.txtAllergMed.Size = new System.Drawing.Size(458, 26);
            this.txtAllergMed.TabIndex = 15;
            // 
            // chkHta
            // 
            this.chkHta.AutoSize = true;
            this.chkHta.Enabled = false;
            this.chkHta.Location = new System.Drawing.Point(342, 34);
            this.chkHta.Name = "chkHta";
            this.chkHta.Size = new System.Drawing.Size(63, 24);
            this.chkHta.TabIndex = 10;
            this.chkHta.Text = "HTA";
            this.chkHta.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Allerg Méd :";
            // 
            // chkDiabete
            // 
            this.chkDiabete.AutoSize = true;
            this.chkDiabete.Enabled = false;
            this.chkDiabete.Location = new System.Drawing.Point(245, 34);
            this.chkDiabete.Name = "chkDiabete";
            this.chkDiabete.Size = new System.Drawing.Size(91, 24);
            this.chkDiabete.TabIndex = 9;
            this.chkDiabete.Text = "Diabete";
            this.chkDiabete.UseVisualStyleBackColor = true;
            // 
            // chkChirurgie
            // 
            this.chkChirurgie.AutoSize = true;
            this.chkChirurgie.Enabled = false;
            this.chkChirurgie.Location = new System.Drawing.Point(139, 34);
            this.chkChirurgie.Name = "chkChirurgie";
            this.chkChirurgie.Size = new System.Drawing.Size(100, 24);
            this.chkChirurgie.TabIndex = 8;
            this.chkChirurgie.Text = "Chirurgie";
            this.chkChirurgie.UseVisualStyleBackColor = true;
            // 
            // chkHosp
            // 
            this.chkHosp.AutoSize = true;
            this.chkHosp.Enabled = false;
            this.chkHosp.Location = new System.Drawing.Point(10, 34);
            this.chkHosp.Name = "chkHosp";
            this.chkHosp.Size = new System.Drawing.Size(123, 24);
            this.chkHosp.TabIndex = 7;
            this.chkHosp.Text = "Hospitaliser";
            this.chkHosp.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTel);
            this.groupBox3.Controls.Add(this.txtAge);
            this.groupBox3.Controls.Add(this.txtAdr);
            this.groupBox3.Controls.Add(this.txtPrenom);
            this.groupBox3.Controls.Add(this.txtNom);
            this.groupBox3.Controls.Add(this.chkF);
            this.groupBox3.Controls.Add(this.chkM);
            this.groupBox3.Controls.Add(this.chkAllergie);
            this.groupBox3.Controls.Add(this.chkAsthme);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 204);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "A Propos";
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(349, 129);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(222, 26);
            this.txtTel.TabIndex = 13;
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(63, 129);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(181, 26);
            this.txtAge.TabIndex = 12;
            // 
            // txtAdr
            // 
            this.txtAdr.Enabled = false;
            this.txtAdr.Location = new System.Drawing.Point(97, 93);
            this.txtAdr.Name = "txtAdr";
            this.txtAdr.Size = new System.Drawing.Size(308, 26);
            this.txtAdr.TabIndex = 11;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Enabled = false;
            this.txtPrenom.Location = new System.Drawing.Point(113, 58);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(292, 26);
            this.txtPrenom.TabIndex = 10;
            // 
            // txtNom
            // 
            this.txtNom.Enabled = false;
            this.txtNom.Location = new System.Drawing.Point(67, 25);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(338, 26);
            this.txtNom.TabIndex = 9;
            // 
            // chkF
            // 
            this.chkF.AutoSize = true;
            this.chkF.Enabled = false;
            this.chkF.Location = new System.Drawing.Point(463, 60);
            this.chkF.Name = "chkF";
            this.chkF.Size = new System.Drawing.Size(39, 24);
            this.chkF.TabIndex = 8;
            this.chkF.Text = "F";
            this.chkF.UseVisualStyleBackColor = true;
            // 
            // chkM
            // 
            this.chkM.AutoSize = true;
            this.chkM.Enabled = false;
            this.chkM.Location = new System.Drawing.Point(415, 60);
            this.chkM.Name = "chkM";
            this.chkM.Size = new System.Drawing.Size(42, 24);
            this.chkM.TabIndex = 7;
            this.chkM.Text = "M";
            this.chkM.UseVisualStyleBackColor = true;
            // 
            // chkAllergie
            // 
            this.chkAllergie.AutoSize = true;
            this.chkAllergie.Enabled = false;
            this.chkAllergie.Location = new System.Drawing.Point(131, 170);
            this.chkAllergie.Name = "chkAllergie";
            this.chkAllergie.Size = new System.Drawing.Size(88, 24);
            this.chkAllergie.TabIndex = 6;
            this.chkAllergie.Text = "Allergie";
            this.chkAllergie.UseVisualStyleBackColor = true;
            // 
            // chkAsthme
            // 
            this.chkAsthme.AutoSize = true;
            this.chkAsthme.Enabled = false;
            this.chkAsthme.Location = new System.Drawing.Point(10, 170);
            this.chkAsthme.Name = "chkAsthme";
            this.chkAsthme.Size = new System.Drawing.Size(89, 24);
            this.chkAsthme.TabIndex = 5;
            this.chkAsthme.Text = "Asthme";
            this.chkAsthme.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "N° Phone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Age :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Adresse :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Prénom(s) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nom :";
            // 
            // AccueilDocteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccueilDocteur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccueilDocteur";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultatRecherche)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btNouveau;
        private System.Windows.Forms.DataGridView dgvResultatRecherche;
        private System.Windows.Forms.DataGridViewTextBoxColumn _personne_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _personne_adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn _personne_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn _personne_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn _allergie;
        private System.Windows.Forms.DataGridViewTextBoxColumn _asthme;
        private System.Windows.Forms.DataGridViewTextBoxColumn _hospitaliser;
        private System.Windows.Forms.DataGridViewTextBoxColumn _chirurgie;
        private System.Windows.Forms.DataGridViewTextBoxColumn _diabete;
        private System.Windows.Forms.DataGridViewTextBoxColumn _hta;
        private System.Windows.Forms.DataGridViewTextBoxColumn _allergie_medicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn _diagnostique;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dureeT;
        private System.Windows.Forms.DataGridViewTextBoxColumn _traitement_anterieur;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drvdsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn _personne_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn _personne_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.Button btRechercherPatient;
        private System.Windows.Forms.TextBox txtRecherchePrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRechercheNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btDetail;
        private System.Windows.Forms.Button btOrdonnance;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDrvTdsp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTraitementAnt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDureeT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiagnostic;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAllergMed;
        private System.Windows.Forms.CheckBox chkHta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkDiabete;
        private System.Windows.Forms.CheckBox chkChirurgie;
        private System.Windows.Forms.CheckBox chkHosp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAdr;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.CheckBox chkF;
        private System.Windows.Forms.CheckBox chkM;
        private System.Windows.Forms.CheckBox chkAllergie;
        private System.Windows.Forms.CheckBox chkAsthme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}