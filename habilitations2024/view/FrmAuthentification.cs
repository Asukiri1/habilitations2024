using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using habilitations2024.controller;
using habilitations2024.model;

namespace habilitations2024.view
{
    public partial class FrmAuthentification : Form
    {
        private readonly FrmAuthentificationController controller;
        public FrmAuthentification()
        {
            InitializeComponent();
            this.controller = new FrmAuthentificationController();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Ou le nom que votre designer utilise, ex: button1_Click
        {
            // UTILISEZ LES NOMS DE VOS TEXTBOX : txtNomAuth, txtPrenomAuth, txtPwdAuth
            String nom = txtNomAuth.Text.Trim();
            String prenom = txtPrenomAuth.Text.Trim();
            String pwd = txtPwdAuth.Text;

            if (String.IsNullOrEmpty(nom) || String.IsNullOrEmpty(prenom) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Admin admin = new Admin(nom, prenom, pwd);
                if (controller.ControleAuthentification(admin))
                {
                    // Authentification réussie
                    this.Hide(); // Cacher le formulaire d'authentification
                    FrmHabilitations frmHabilitations = new FrmHabilitations();
                    frmHabilitations.ShowDialog(); // Afficher le formulaire principal en modal
                    this.Close(); // Fermer le formulaire d'authentification après la fermeture du principal
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas admin", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPwdAuth.Text = "";
                    txtPwdAuth.Focus();
                }
            }
        }
    }
}