using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.Vue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
