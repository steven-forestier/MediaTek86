using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MediaTek86.Controleur;
using MediaTek86.Modele;

namespace MediaTek86.Vue
{
    public partial class FormGestion : Form
    {
        /// <summary>
        /// instance du controlleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Booléen pour savoir si une modification est en cours
        /// </summary>
        private Boolean modifEnCours = false;

        /// <summary>
        /// Objet gérant la liste du personnel
        /// </summary>
        BindingSource bdgPersonnel = new BindingSource();

        /// <summary>
        /// Objet gérant la liste des absences
        /// </summary>
        BindingSource bdgAbsence = new BindingSource();

        /// <summary>
        /// Objet gérant la liste des motifs
        /// </summary>
        BindingSource bdgMotif = new BindingSource();

        /// <summary>
        /// Objet gérant la liste des affectations/services
        /// </summary>
        BindingSource bdgAffectation = new BindingSource();

        /// <summary>
        /// Initialise les graphismes
        /// Récupère le controleur
        /// </summary>
        /// <param name="controle"></param>
        public FormGestion(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            StatusDepart();
        }

        public void StatusDepart()
        {
            // la boite de deconnection est rendu invisible et est désactivé par mesure de sécurité.
            grp_Deconnect.Enabled = false;
            grp_Deconnect.Visible = false;
            // la boite de Personnel est rendu invisible et est désactivé par mesure de sécurité.
            grp_Perso.Enabled = false;
            grp_Perso.Visible = false;
            // la boite d'ajout de Personnel est rendu invisible et est désactivé par mesure de sécurité.
            grp_Perso_Ajout.Enabled = false;
            grp_Perso_Ajout.Visible = false;
            // la boite des absences est rendu invisible et est désactivé par mesure de sécurité.
            grp_Abs.Enabled = false;
            grp_Abs.Visible = false;
            // la boite d'ajout d'absence est rendu invisible et est désactivé par mesure de sécurité.
            grp_Abs_Ajout.Enabled = false;
            grp_Abs_Ajout.Visible = false;
            // la boite de connection est rendu visible et est activé.
            grp_Connect.Enabled = true;
            grp_Connect.Visible = true;
            // le message d'erreur est mis à zéro
            lbl_error.Text = "";
            // remplis la list du personnel
            Remplir_lst_Perso();
        }

        public void StatusConnecter(string nom)
        {
            // la boite de deconnection est rendu visible et est activé.
            grp_Deconnect.Enabled = true;
            grp_Deconnect.Visible = true;
            // la boite de Personnel est rendu visible et est activé.
            grp_Perso.Enabled = true;
            grp_Perso.Visible = true;
            // la boite des absences est rendu visible et est activé.
            grp_Abs.Enabled = true;
            grp_Abs.Visible = true;
            // la boite de connection est rendu invisible et est desactivé.
            grp_Connect.Enabled = false;
            grp_Connect.Visible = false;
            // change l'utilisateur par l'identifiant
            lbl_Identifiant.Text = nom;
        }

        public void Remplir_lst_Perso()
        {
            List<Personnel> personnels = controle.GetPersonnels();
            bdgPersonnel.DataSource = personnels;
            lst_Perso.DataSource = bdgPersonnel;
        }

        public void Remplir_lst_Absence()
        {
            List<Absence> absences = controle.GetAbsences();
            bdgAbsence.DataSource = absences;
            lst_Abs.DataSource = bdgAbsence;
        }

        public void Remplir_cmb_Motif()
        {
            List<Motif> motif = controle.GetMotifs();
            bdgAbsence.DataSource = motif;
            cmb_Abs_Ajout_Motif.DataSource = bdgAbsence;
            if(cmb_Abs_Ajout_Motif.Items.Count > 0)
            {
                cmb_Abs_Ajout_Motif.SelectedIndex = 0;
            }
        }

        public void Remplir_cmb_Affectation()
        {
            List<Service> services = controle.GetServices();
            bdgAffectation.DataSource = services;
            cmb_Perso_Ajout_Affectation.DataSource = bdgAffectation;
            if(cmb_Perso_Ajout_Affectation.Items.Count > 0)
            {
                cmb_Perso_Ajout_Affectation.SelectedIndex = 0;
            }
        }

        #region Paneaux d'ajout/modification/suppression de Personnel
        public void OpenPanel_Ajout_Perso(string action)
        {
            grp_Perso_Ajout.Enabled = true;
            grp_Perso_Ajout.Visible = true;
            grp_Perso_Ajout.Text = action;
        }

        public void ClosePannel_Ajout_Perso()
        {
            grp_Perso_Ajout.Enabled = false;
            grp_Perso_Ajout.Visible = false;
        }
        #endregion

        #region Panneaux d'ajout/modification/suppression d'Absence
        public void OpenPanel_Ajout_Abs(string action)
        {
            grp_Abs_Ajout.Enabled = true;
            grp_Abs_Ajout.Visible = true;
            grp_Abs_Ajout.Text = action;
        }

        public void ClosePannel_Ajout_Abs()
        {
            grp_Abs_Ajout.Enabled = false;
            grp_Abs_Ajout.Visible = false;
        }
        #endregion

        #region Test Onclick event
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            StatusConnecter("moi");
        }

        private void btn_Deconnect_Click(object sender, EventArgs e)
        {
            StatusDepart();
        }

        private void btn_Perso_Ajouter_Click(object sender, EventArgs e)
        {
            OpenPanel_Ajout_Perso("Ajouter Personnel");
        }

        private void btn_Perso_Modifer_Click(object sender, EventArgs e)
        {
            OpenPanel_Ajout_Perso("Modifier Personnel");
        }

        private void btn_Abs_Ajouter_Click(object sender, EventArgs e)
        {
            OpenPanel_Ajout_Abs("Ajouter une Absence");
        }

        private void btn_Abs_Modifier_Click(object sender, EventArgs e)
        {
            OpenPanel_Ajout_Abs("Modifier une Absence");
        }

        private void btn_Perso8ajout_Annuler_Click(object sender, EventArgs e)
        {
            ClosePannel_Ajout_Perso();
        }

        private void btn_Abs_Ajout_Annuler_Click(object sender, EventArgs e)
        {
            ClosePannel_Ajout_Abs();
        }
        #endregion
    }
}
