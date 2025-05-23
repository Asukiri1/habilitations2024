using System.Windows.Forms;

namespace habilitations2024.view
{
    public partial class FrmAuthentification : Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomAuth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenomAuth = new System.Windows.Forms.TextBox();
            this.txtPwdAuth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomAuth
            // 
            this.txtNomAuth.Location = new System.Drawing.Point(57, 6);
            this.txtNomAuth.Name = "txtNomAuth";
            this.txtNomAuth.Size = new System.Drawing.Size(100, 20);
            this.txtNomAuth.TabIndex = 1;
            this.txtNomAuth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPrenomAuth
            // 
            this.txtPrenomAuth.Location = new System.Drawing.Point(57, 32);
            this.txtPrenomAuth.Name = "txtPrenomAuth";
            this.txtPrenomAuth.Size = new System.Drawing.Size(100, 20);
            this.txtPrenomAuth.TabIndex = 3;
            // 
            // txtPwdAuth
            // 
            this.txtPwdAuth.Location = new System.Drawing.Point(212, 6);
            this.txtPwdAuth.Name = "txtPwdAuth";
            this.txtPwdAuth.PasswordChar = '*';
            this.txtPwdAuth.Size = new System.Drawing.Size(100, 20);
            this.txtPwdAuth.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pwd";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(148, 68);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(100, 23);
            this.btnConnecter.TabIndex = 6;
            this.btnConnecter.Text = "Se connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPwdAuth);
            this.Controls.Add(this.txtPrenomAuth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomAuth);
            this.Controls.Add(this.label1);
            this.Name = "FrmAuthentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNomAuth;
        private Label label2;
        private TextBox txtPrenomAuth;
        private TextBox txtPwdAuth;
        private Label label3;
        private Button btnConnecter;
    }
}