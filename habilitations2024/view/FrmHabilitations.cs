﻿using habilitations2024.controller;
using habilitations2024.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace habilitations2024.view
{
    /// <summary>
    /// Fenêtre d'affichage des développeurs et de leurs profils
    /// </summary>
    public partial class FrmHabilitations : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifDeveloppeur = false;
        /// <summary>
        /// Objet pour gérer la liste des développeurs
        /// </summary>
        private BindingSource bdgDeveloppeurs = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        private BindingSource bdgProfils = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmHabilitationsController controller;

        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmHabilitations()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmHabilitationsController();
            RemplirListeDeveloppeurs();
            RemplirListeProfils();
            EnCourseModifDeveloppeur(false);
            EnCoursModifPwd(false);
        }

        /// <summary>
        /// Affiche les développeurs
        /// </summary>
        private void RemplirListeDeveloppeurs()
        {
            List<Developpeur> lesDeveloppeurs = controller.GetLesDeveloppeurs();
            bdgDeveloppeurs.DataSource = lesDeveloppeurs;
            dgvDeveloppeurs.DataSource = bdgDeveloppeurs;
            dgvDeveloppeurs.Columns["iddeveloppeur"].Visible = false;
            dgvDeveloppeurs.Columns["pwd"].Visible = false;
            dgvDeveloppeurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les profils
        /// </summary>
        private void RemplirListeProfils()
        {
            List<Profil> lesProfils = controller.GetLesProfils();
            bdgProfils.DataSource = lesProfils;
            cmbProfils.DataSource = bdgProfils;
        }

        /// <summary>
        ///  Demande de modification d'un développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvDeveloppeurs.SelectedRows.Count > 0)
            {
                EnCourseModifDeveloppeur(true);
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                txtNom.Text = developpeur.Nom;
                textprenom.Text = developpeur.Prenom;
                txtTel.Text = developpeur.Tel;
                txtMail.Text = developpeur.Mail;
                cmbProfils.SelectedIndex = cmbProfils.FindStringExact(developpeur.Profil.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande de suppression d'un développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvDeveloppeurs.SelectedRows.Count > 0)
            {
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + developpeur.Nom + " " + developpeur.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelDeveloppeur(developpeur);
                    RemplirListeDeveloppeurs();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande de changement du pwd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangerPwd_Click(object sender, EventArgs e)
        {
            if (dgvDeveloppeurs.SelectedRows.Count > 0)
            {
                EnCoursModifPwd(true);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !textprenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cmbProfils.SelectedIndex != -1)
            {
                Profil profil = (Profil)bdgProfils.List[bdgProfils.Position];
                if (enCoursDeModifDeveloppeur)
                {
                    Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                    developpeur.Nom = txtNom.Text;
                    developpeur.Prenom = textprenom.Text;
                    developpeur.Tel = txtTel.Text;
                    developpeur.Mail = txtMail.Text;
                    developpeur.Profil = profil;
                    controller.UpdateDeveloppeur(developpeur);
                }
                else
                {
                    Developpeur developpeur = new Developpeur(0, txtNom.Text, textprenom.Text, txtTel.Text, txtMail.Text, profil);
                    controller.AddDeveloppeur(developpeur);
                }
                RemplirListeDeveloppeurs();
                EnCourseModifDeveloppeur(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification d'un développeur
        /// Vide les zones de saisie du développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCourseModifDeveloppeur(false);
            }
        }

        /// <summary>
        /// Demande d'enregistrement du nouveau pwd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerPwd_Click(object sender, EventArgs e)
        {
            if (!textPwd1.Text.Equals("") && !textBox2.Text.Equals("") && textPwd1.Text.Equals(textBox2.Text))
            {
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                developpeur.Pwd = textPwd1.Text;
                controller.UpdatePwd(developpeur);
                EnCoursModifPwd(false);
            }
            else
            {
                MessageBox.Show("Les 2 zones doivent être remplies et de contenu identique", "Information");
            }
        }

        /// <summary>
        /// Annulation de demande d'enregistrement d'un nouveau pwd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerPwd_Click(object sender, EventArgs e)
        {
            EnCoursModifPwd(false);
        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'un developpeur
        /// </summary>
        /// <param name="modif"></param>
        private void EnCourseModifDeveloppeur(Boolean modif)
        {
            enCoursDeModifDeveloppeur = modif;
            groupBox1.Enabled = !modif;
            if (modif)
            {
                gbxDetailsDeveloppeur.Text = "modifier un développeur";
            }
            else
            {
                gbxDetailsDeveloppeur.Text = "ajouter un développeur";
                txtNom.Text = "";
                textprenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }

        /// <summary>
        /// Modification d'affichage suivant si on est ou non en cours de modif du pwd
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursModifPwd(Boolean modif)
        {
            gbxChangePwd.Enabled = modif;
            groupBox1.Enabled = !modif;
            gbxDetailsDeveloppeur.Enabled = !modif;
            textPwd1.Text = "";
            textBox2.Text = "";
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {

        }
    }
}