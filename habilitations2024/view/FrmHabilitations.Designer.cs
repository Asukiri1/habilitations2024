namespace habilitations2024.view
{
    partial class FrmHabilitations
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDeveloppeurs = new System.Windows.Forms.DataGridView();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnChangerPwd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxDetailsDeveloppeur = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.cmbProfils = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.textprenom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxChangePwd = new System.Windows.Forms.GroupBox();
            this.btnAnnulerPwd = new System.Windows.Forms.Button();
            this.btnEnregistrerPwd = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textPwd1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeveloppeurs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxDetailsDeveloppeur.SuspendLayout();
            this.gbxChangePwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "les développeurs\r\n";
            // 
            // dgvDeveloppeurs
            // 
            this.dgvDeveloppeurs.AllowUserToAddRows = false;
            this.dgvDeveloppeurs.AllowUserToDeleteRows = false;
            this.dgvDeveloppeurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeveloppeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeveloppeurs.Location = new System.Drawing.Point(0, 13);
            this.dgvDeveloppeurs.MultiSelect = false;
            this.dgvDeveloppeurs.Name = "dgvDeveloppeurs";
            this.dgvDeveloppeurs.ReadOnly = true;
            this.dgvDeveloppeurs.RowHeadersVisible = false;
            this.dgvDeveloppeurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeveloppeurs.Size = new System.Drawing.Size(657, 228);
            this.dgvDeveloppeurs.TabIndex = 1;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(0, 247);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "modifier\r\n";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(81, 247);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnChangerPwd
            // 
            this.btnChangerPwd.Location = new System.Drawing.Point(162, 247);
            this.btnChangerPwd.Name = "btnChangerPwd";
            this.btnChangerPwd.Size = new System.Drawing.Size(92, 23);
            this.btnChangerPwd.TabIndex = 4;
            this.btnChangerPwd.Text = "changer pwd";
            this.btnChangerPwd.UseVisualStyleBackColor = true;
            this.btnChangerPwd.Click += new System.EventHandler(this.btnChangerPwd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangerPwd);
            this.groupBox1.Controls.Add(this.dgvDeveloppeurs);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 276);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // gbxDetailsDeveloppeur
            // 
            this.gbxDetailsDeveloppeur.Controls.Add(this.btnAnnuler);
            this.gbxDetailsDeveloppeur.Controls.Add(this.btnEnregistrer);
            this.gbxDetailsDeveloppeur.Controls.Add(this.cmbProfils);
            this.gbxDetailsDeveloppeur.Controls.Add(this.txtTel);
            this.gbxDetailsDeveloppeur.Controls.Add(this.txtMail);
            this.gbxDetailsDeveloppeur.Controls.Add(this.textprenom);
            this.gbxDetailsDeveloppeur.Controls.Add(this.label6);
            this.gbxDetailsDeveloppeur.Controls.Add(this.label5);
            this.gbxDetailsDeveloppeur.Controls.Add(this.label4);
            this.gbxDetailsDeveloppeur.Controls.Add(this.txtPrenom);
            this.gbxDetailsDeveloppeur.Controls.Add(this.txtNom);
            this.gbxDetailsDeveloppeur.Controls.Add(this.label2);
            this.gbxDetailsDeveloppeur.Location = new System.Drawing.Point(5, 289);
            this.gbxDetailsDeveloppeur.Name = "gbxDetailsDeveloppeur";
            this.gbxDetailsDeveloppeur.Size = new System.Drawing.Size(670, 142);
            this.gbxDetailsDeveloppeur.TabIndex = 6;
            this.gbxDetailsDeveloppeur.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(110, 117);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(116, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click_1);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(7, 118);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(96, 23);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // cmbProfils
            // 
            this.cmbProfils.FormattingEnabled = true;
            this.cmbProfils.Location = new System.Drawing.Point(368, 63);
            this.cmbProfils.Name = "cmbProfils";
            this.cmbProfils.Size = new System.Drawing.Size(280, 21);
            this.cmbProfils.TabIndex = 9;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(368, 34);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(280, 20);
            this.txtTel.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(368, 9);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(280, 20);
            this.txtMail.TabIndex = 7;
            // 
            // textprenom
            // 
            this.textprenom.Location = new System.Drawing.Point(51, 34);
            this.textprenom.Name = "textprenom";
            this.textprenom.Size = new System.Drawing.Size(270, 20);
            this.textprenom.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "profil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "mail";
            // 
            // txtPrenom
            // 
            this.txtPrenom.AutoSize = true;
            this.txtPrenom.Location = new System.Drawing.Point(7, 37);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(42, 13);
            this.txtPrenom.TabIndex = 2;
            this.txtPrenom.Text = "prenom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(51, 9);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(270, 20);
            this.txtNom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "nom";
            // 
            // gbxChangePwd
            // 
            this.gbxChangePwd.Controls.Add(this.btnAnnulerPwd);
            this.gbxChangePwd.Controls.Add(this.btnEnregistrerPwd);
            this.gbxChangePwd.Controls.Add(this.textBox2);
            this.gbxChangePwd.Controls.Add(this.label8);
            this.gbxChangePwd.Controls.Add(this.textPwd1);
            this.gbxChangePwd.Controls.Add(this.label7);
            this.gbxChangePwd.Controls.Add(this.label3);
            this.gbxChangePwd.Enabled = false;
            this.gbxChangePwd.Location = new System.Drawing.Point(5, 437);
            this.gbxChangePwd.Name = "gbxChangePwd";
            this.gbxChangePwd.Size = new System.Drawing.Size(670, 100);
            this.gbxChangePwd.TabIndex = 7;
            this.gbxChangePwd.TabStop = false;
            // 
            // btnAnnulerPwd
            // 
            this.btnAnnulerPwd.Location = new System.Drawing.Point(110, 71);
            this.btnAnnulerPwd.Name = "btnAnnulerPwd";
            this.btnAnnulerPwd.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerPwd.TabIndex = 6;
            this.btnAnnulerPwd.Text = "annuler";
            this.btnAnnulerPwd.UseVisualStyleBackColor = true;
            this.btnAnnulerPwd.Click += new System.EventHandler(this.btnAnnulerPwd_Click);
            // 
            // btnEnregistrerPwd
            // 
            this.btnEnregistrerPwd.Location = new System.Drawing.Point(10, 71);
            this.btnEnregistrerPwd.Name = "btnEnregistrerPwd";
            this.btnEnregistrerPwd.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrerPwd.TabIndex = 5;
            this.btnEnregistrerPwd.Text = "enregistrer";
            this.btnEnregistrerPwd.UseVisualStyleBackColor = true;
            this.btnEnregistrerPwd.Click += new System.EventHandler(this.btnEnregistrerPwd_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(368, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(280, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "encore";
            // 
            // textPwd1
            // 
            this.textPwd1.Location = new System.Drawing.Point(51, 31);
            this.textPwd1.Name = "textPwd1";
            this.textPwd1.PasswordChar = '*';
            this.textPwd1.Size = new System.Drawing.Size(270, 20);
            this.textPwd1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "pwd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "changer le mot de passe";
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 547);
            this.Controls.Add(this.gbxChangePwd);
            this.Controls.Add(this.gbxDetailsDeveloppeur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmHabilitations";
            this.Text = "Habilitations";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeveloppeurs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gbxDetailsDeveloppeur.ResumeLayout(false);
            this.gbxDetailsDeveloppeur.PerformLayout();
            this.gbxChangePwd.ResumeLayout(false);
            this.gbxChangePwd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDeveloppeurs;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnChangerPwd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxDetailsDeveloppeur;
        private System.Windows.Forms.TextBox textprenom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cmbProfils;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.GroupBox gbxChangePwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPwd1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAnnulerPwd;
        private System.Windows.Forms.Button btnEnregistrerPwd;
    }
}

