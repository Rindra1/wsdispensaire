namespace Dispensaire
{
    partial class AjoutOrdonnance
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
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAjouterMedicament = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbNomMedicament = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtForme = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSymptome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPouls = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTensionArterien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvMedicament = new System.Windows.Forms.DataGridView();
            this._medicament_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._quantite_acheter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._prix_acheter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 80);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1103, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btAjouterMedicament);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 520);
            this.panel2.TabIndex = 2;
            // 
            // btAjouterMedicament
            // 
            this.btAjouterMedicament.BackColor = System.Drawing.Color.Green;
            this.btAjouterMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouterMedicament.ForeColor = System.Drawing.Color.White;
            this.btAjouterMedicament.Location = new System.Drawing.Point(469, 425);
            this.btAjouterMedicament.Name = "btAjouterMedicament";
            this.btAjouterMedicament.Size = new System.Drawing.Size(116, 34);
            this.btAjouterMedicament.TabIndex = 13;
            this.btAjouterMedicament.Text = "Ajouter";
            this.btAjouterMedicament.UseVisualStyleBackColor = false;
            this.btAjouterMedicament.Click += new System.EventHandler(this.btAjouterMedicament_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbNomMedicament);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtForme);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 201);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Médicament";
            // 
            // cbNomMedicament
            // 
            this.cbNomMedicament.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNomMedicament.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNomMedicament.FormattingEnabled = true;
            this.cbNomMedicament.Location = new System.Drawing.Point(14, 50);
            this.cbNomMedicament.Name = "cbNomMedicament";
            this.cbNomMedicament.Size = new System.Drawing.Size(320, 28);
            this.cbNomMedicament.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(13, 160);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(321, 26);
            this.txtNombre.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nombre";
            // 
            // txtForme
            // 
            this.txtForme.Location = new System.Drawing.Point(13, 108);
            this.txtForme.Name = "txtForme";
            this.txtForme.Size = new System.Drawing.Size(321, 26);
            this.txtForme.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Forme";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Nom Médicament";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSymptome);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTemperature);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPoids);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPouls);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTensionArterien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paramètres Vitaux";
            // 
            // txtSymptome
            // 
            this.txtSymptome.Location = new System.Drawing.Point(13, 160);
            this.txtSymptome.Name = "txtSymptome";
            this.txtSymptome.Size = new System.Drawing.Size(321, 26);
            this.txtSymptome.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Symptome";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(421, 108);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 26);
            this.txtTemperature.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "T°";
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(284, 108);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(100, 26);
            this.txtPoids.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Poids";
            // 
            // txtPouls
            // 
            this.txtPouls.Location = new System.Drawing.Point(150, 108);
            this.txtPouls.Name = "txtPouls";
            this.txtPouls.Size = new System.Drawing.Size(100, 26);
            this.txtPouls.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pouls";
            // 
            // txtTensionArterien
            // 
            this.txtTensionArterien.Location = new System.Drawing.Point(13, 108);
            this.txtTensionArterien.Name = "txtTensionArterien";
            this.txtTensionArterien.Size = new System.Drawing.Size(100, 26);
            this.txtTensionArterien.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "TA";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 55);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.btEnregistrer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(600, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 520);
            this.panel3.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dgvMedicament);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 520);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste Médicament";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(475, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvMedicament
            // 
            this.dgvMedicament.AllowUserToAddRows = false;
            this.dgvMedicament.AllowUserToDeleteRows = false;
            this.dgvMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._medicament_nom,
            this._description,
            this._quantite_acheter,
            this._prix_acheter});
            this.dgvMedicament.Location = new System.Drawing.Point(10, 39);
            this.dgvMedicament.Name = "dgvMedicament";
            this.dgvMedicament.ReadOnly = true;
            this.dgvMedicament.Size = new System.Drawing.Size(581, 429);
            this.dgvMedicament.TabIndex = 1;
            // 
            // _medicament_nom
            // 
            this._medicament_nom.HeaderText = "Médicament";
            this._medicament_nom.Name = "_medicament_nom";
            this._medicament_nom.ReadOnly = true;
            this._medicament_nom.Width = 238;
            // 
            // _description
            // 
            this._description.HeaderText = "Forme";
            this._description.Name = "_description";
            this._description.ReadOnly = true;
            // 
            // _quantite_acheter
            // 
            this._quantite_acheter.HeaderText = "Nombre";
            this._quantite_acheter.Name = "_quantite_acheter";
            this._quantite_acheter.ReadOnly = true;
            // 
            // _prix_acheter
            // 
            this._prix_acheter.HeaderText = "Montant";
            this._prix_acheter.Name = "_prix_acheter";
            this._prix_acheter.ReadOnly = true;
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.BackColor = System.Drawing.Color.Blue;
            this.btEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btEnregistrer.Location = new System.Drawing.Point(472, 474);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(116, 34);
            this.btEnregistrer.TabIndex = 9;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.UseVisualStyleBackColor = false;
            // 
            // AjoutOrdonnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjoutOrdonnance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjoutOrdonnance";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btAjouterMedicament;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbNomMedicament;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtForme;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSymptome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPouls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTensionArterien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn _medicament_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn _description;
        private System.Windows.Forms.DataGridViewTextBoxColumn _quantite_acheter;
        private System.Windows.Forms.DataGridViewTextBoxColumn _prix_acheter;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Button button2;
    }
}