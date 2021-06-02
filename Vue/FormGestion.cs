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

        #region Affichage des Status (connecter/déconnecter)
        /// <summary>
        /// Met en place l'affichage de début de l'application, hors connexion.
        /// </summary>
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
            // Affichage d'une image pour combler l'espace vide
            pct_MediaTek86.Visible = true;
            // le message d'erreur et les boites de saisie de l'identifiant et le mot de passe sont vidée
            lbl_error.Text = "";
            txt_Identifiant.Text = "";
            txt_MotDePasse.Text = "";
            // met le focus sur la boite texte identifiant
            txt_Identifiant.Focus();
        }

        /// <summary>
        /// Met en place l'affichage de l'application après connexion
        /// </summary>
        /// <param name="nom"></param>
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
            //par default, comme aucun membre du personnel n'est selectionné, les boutons d'ajout/modif/suppression d'absence sont désactivé.
            btn_Abs_Ajouter.Enabled = false;
            btn_Abs_Modifier.Enabled = false;
            btn_Abs_Supprimer.Enabled = false;
            // Cache l'image de fond d'écran
            pct_MediaTek86.Visible = false;
            // remplis la list du personnel
            Remplir_lst_Perso();
            Remplir_cmb_Affectation();
            Remplir_cmb_Motif();
        }
        #endregion

        #region Remplissage des Objets
        /// <summary>
        /// remplis la liste du personnel
        /// </summary>
        public void Remplir_lst_Perso()
        {
            List<Personnel> personnels = controle.GetPersonnels();
            lst_Perso.Items.Clear();
            foreach (Personnel personnel in personnels)
            {
                lst_Perso.Items.Add(personnel.Nom + " - " + personnel.Prenom + " - " + personnel.Tel + " - " + personnel.Mail);
            }
        }

        /// <summary>
        /// remplis la liste des absences
        /// </summary>
        public void Remplir_lst_Absence(int id)
        {
            List<Absence> absences = controle.GetAbsences(id);
            List<Motif> motifs = controle.GetMotifs();
            lst_Abs.Items.Clear();
            foreach (Absence absence in absences)
            {
                lst_Abs.Items.Add(absence.DateDebut + " - " + absence.DateFin + " - " + absence.IdMotif + "." + motifs[absence.IdMotif-1].Libelle);
            }
        }

        /// <summary>
        /// remplis la liste des motifs d'absence
        /// </summary>
        public void Remplir_cmb_Motif()
        {
            List<Motif> motifs = controle.GetMotifs();
            cmb_Abs_Ajout_Motif.Items.Clear();
            foreach(Motif motif in motifs)
            {
                cmb_Abs_Ajout_Motif.Items.Add(motif.Libelle);
            }
        }

        /// <summary>
        /// remplis la liste des affectations (services) possible
        /// </summary>
        public void Remplir_cmb_Affectation()
        {
            List<Service> services = controle.GetServices();
            cmb_Perso_Ajout_Affectation.Items.Clear();
            foreach (Service service in services)
            {
                cmb_Perso_Ajout_Affectation.Items.Add(service.Nom);
            }
        }

        /// <summary>
        /// Affiche les absences du membre du personnel selectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lst_Perso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Perso.SelectedIndex != -1)
            {
                Personnel perso = controle.GetPersonnels()[lst_Perso.SelectedIndex];
                Remplir_lst_Absence(perso.IdPersonnel);
                btn_Abs_Ajouter.Enabled = true;
                btn_Abs_Modifier.Enabled = true;
                btn_Abs_Supprimer.Enabled = true;
            }
            else
            {
                lst_Abs.Items.Clear();
                btn_Abs_Ajouter.Enabled = false;
                btn_Abs_Modifier.Enabled = false;
                btn_Abs_Supprimer.Enabled = false;
            }

        }

        #endregion

        #region Paneaux d'ajout/modification/suppression de Personnel

        /// <summary>
        /// gere l'ouverture du panneau d'ajout ou modification du personnel
        /// </summary>
        /// <param name="action"></param>
        public void OpenPanel_Ajout_Perso(string action)
        {
            grp_Perso_Ajout.Enabled = true;
            grp_Perso_Ajout.Visible = true;
            grp_Perso_Ajout.Text = action;
        }

        /// <summary>
        /// gere la fermeture du panneau d'ajout ou modification du personnel
        /// </summary>
        public void ClosePannel_Ajout_Perso()
        {
            grp_Perso_Ajout.Enabled = false;
            grp_Perso_Ajout.Visible = false;
            txt_Perso_Ajout_Nom.Text = "";
            txt_Perso_Ajout_Prenom.Text = "";
            txt_Perso_Ajout_Tel.Text = "";
            txt_Perso_Ajout_Mail.Text = "";
            cmb_Perso_Ajout_Affectation.SelectedIndex = -1;
        }

        /// <summary>
        /// affiche le panneaux d'ajout de personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Perso_Ajouter_Click(object sender, EventArgs e)
        {
            OpenPanel_Ajout_Perso("Ajouter Personnel");
            txt_Perso_Ajout_Nom.Focus();
        }

        /// <summary>
        /// affiche le panneaux de modification du personnel si un membre est sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Perso_Modifer_Click(object sender, EventArgs e)
        {
            if (RecupererPersoSelect())
            {
                OpenPanel_Ajout_Perso("Modifier Personnel");
                txt_Perso_Ajout_Nom.Focus();
            }
            else
            {
                MessageBox.Show("Un membre du personnel doit être sélectionné");
            }

        }

        /// <summary>
        /// récupère et affiche les informations du membres du personnel selectionné
        /// </summary>
        /// <returns>vrai si un personnel est selectionné</returns>
        private bool RecupererPersoSelect()
        {
            if (lst_Perso.SelectedIndex != -1)
            {
                Personnel personnel = controle.GetPersonnels()[lst_Perso.SelectedIndex];
                txt_Perso_Ajout_Nom.Text = personnel.Nom;
                txt_Perso_Ajout_Prenom.Text = personnel.Prenom;
                txt_Perso_Ajout_Tel.Text = personnel.Tel;
                txt_Perso_Ajout_Mail.Text = personnel.Mail;
                cmb_Perso_Ajout_Affectation.SelectedIndex = personnel.IdService - 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gere l'annulation d'un ajout ou d'une modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Perso_ajout_Annuler_Click(object sender, EventArgs e)
        {
            Annule_Perso();
        }

        /// <summary>
        /// Annule la modification ou l'ajout en cours avec une demande de confirmation.
        /// </summary>
        private void Annule_Perso()
        {
            DialogResult dialog = MessageBox.Show("Les données saisie seront perdu, continuer?", "Annulation", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                ClosePannel_Ajout_Perso();
            }
            else
            {
                txt_Perso_Ajout_Prenom.Focus();
            }
        }

        /// <summary>
        /// ajoute un nouveau membre ou en modifie un préexistant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Peso_Ajout_Valider_Click(object sender, EventArgs e)
        {
            if (!VerifPersoParam())
            {
                MessageBox.Show("Veuillez remplir tout les paramètres");
                return;
            }
            DialogResult dialog = MessageBox.Show("Confirmez", "Confirmez", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.Cancel)
            {
                return;
            }

            Service service = controle.GetServices()[cmb_Perso_Ajout_Affectation.SelectedIndex];
            string nom = txt_Perso_Ajout_Nom.Text;
            string prenom = txt_Perso_Ajout_Prenom.Text;
            string tel = txt_Perso_Ajout_Tel.Text;
            string mail = txt_Perso_Ajout_Mail.Text;
            if (grp_Perso_Ajout.Text.Equals("Modifier Personnel"))
            {
                Personnel personnel = controle.GetPersonnels()[lst_Perso.SelectedIndex];
                Personnel perso = new Personnel(personnel.IdPersonnel, service.IdService, nom, prenom, tel, mail);
                controle.ModifPersonnel(perso);
            }
            else
            {
                Personnel perso = new Personnel(lst_Perso.Items.Count + 1, service.IdService, nom, prenom, tel, mail);
                controle.AddPersonnel(perso);
            }
            Remplir_lst_Perso();
            ClosePannel_Ajout_Perso();
        }

        /// <summary>
        /// Verifie que toute les paramètres sont remplis
        /// </summary>
        /// <returns>vrai si tout les paramètres sont remplis</returns>
        private bool VerifPersoParam()
        {
            if(txt_Perso_Ajout_Nom.Text.Equals("") || txt_Perso_Ajout_Prenom.Text.Equals("") || txt_Perso_Ajout_Tel.Text.Equals("") || txt_Perso_Ajout_Mail.Text.Equals("") || cmb_Perso_Ajout_Affectation.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Supprime un membre du personnel et ses absences de la base de donnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Perso_Supprimer_Click(object sender, EventArgs e)
        {
            if (lst_Perso.SelectedIndex != -1)
            {
                DialogResult dialog = MessageBox.Show("Cette action entraînera la suppression des données personnel et des absences de façon définitive. Continuer?", "Confirmation Suppression", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK && !VerifPersoParam())
                {
                    Personnel perso = controle.GetPersonnels()[lst_Perso.SelectedIndex];
                    controle.SupprPersonnel(perso);
                    controle.SupprAbsencePersonnel(perso.IdPersonnel);
                    lst_Perso.DataSource = null;
                    Remplir_lst_Perso();
                    lst_Abs.Items.Clear();
                    lst_Perso.SelectedIndex = -1;
                    btn_Abs_Ajouter.Enabled = false;
                    btn_Abs_Modifier.Enabled = false;
                    btn_Abs_Supprimer.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tout les paramètres");
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un membre du personnel");
            }
        }

        #endregion

        #region Panneaux d'ajout/modification/suppression d'Absence

        /// <summary>
        /// gere l'ouverture du panneau d'ajout ou modification d'absence
        /// </summary>
        /// <param name="action"></param>
        public void OpenPanel_Ajout_Abs(string action)
        {
            grp_Abs_Ajout.Enabled = true;
            grp_Abs_Ajout.Visible = true;
            grp_Abs_Ajout.Text = action;
        }

        /// <summary>
        /// gere la fermeture du panneau d'ajout ou modification d'absence
        /// </summary>
        public void ClosePannel_Ajout_Abs()
        {
            grp_Abs_Ajout.Enabled = false;
            grp_Abs_Ajout.Visible = false;
        }

        /// <summary>
        /// affiche le panneau d'ajout d'absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Abs_Ajouter_Click(object sender, EventArgs e)
        {
            OpenPanel_Ajout_Abs("Ajouter une Absence");
            dtp_Abs_Debut.Value = DateTime.Now;
            dtp_Abs_Fin.Value = DateTime.Now;
            cmb_Abs_Ajout_Motif.SelectedIndex = -1;
            dtp_Abs_Debut.Focus();
        }

        /// <summary>
        /// affiche le panneau de modification d'absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Abs_Modifier_Click(object sender, EventArgs e)
        {
            if (RecupererAbsSelect())
            {
                OpenPanel_Ajout_Abs("Modifier une Absence");
                dtp_Abs_Debut.Focus();
            }
            else
            {
                MessageBox.Show("Une Absence doit être sélectionné");
            }
        }

        private bool RecupererAbsSelect()
        {
            if (lst_Abs.SelectedIndex != -1)
            {
                Absence absence = controle.GetAbsences(controle.GetPersonnels()[lst_Perso.SelectedIndex].IdPersonnel)[lst_Abs.SelectedIndex];
                dtp_Abs_Debut.Value = absence.DateDebut;
                dtp_Abs_Fin.Value = absence.DateFin;
                cmb_Abs_Ajout_Motif.SelectedIndex = absence.IdMotif - 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Abs_Ajout_Annuler_Click(object sender, EventArgs e)
        {
            Annule_Abs();
        }

        /// <summary>
        /// Annule la modification ou l'ajout en cours avec une demande de confirmation.
        /// </summary>
        private void Annule_Abs()
        {
            DialogResult dialog = MessageBox.Show("Les données saisie seront perdu, continuer?", "Annulation", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                ClosePannel_Ajout_Abs();
            }
            else
            {
                dtp_Abs_Debut.Focus();
            }
        }

        /// <summary>
        /// ajoute une nouvelle absence ou en modifie une préexistante.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Abs_Ajout_Valider_Click(object sender, EventArgs e)
        {
            if (!VerifAbsParam())
            {
                MessageBox.Show("Veuillez remplir tout les paramètres");
                return;
            }
            DialogResult dialog = MessageBox.Show("Confirmez", "Confirmez", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.Cancel)
            {
                return;
            }

            DateTime dateDebut = dtp_Abs_Debut.Value;
            DateTime dateFin = dtp_Abs_Fin.Value;
            if(!VerifieAnomalieDates(dateDebut, dateFin))
            {
                MessageBox.Show("La date de fin ne peut être antérieure à la date de début");
                return;
            }

            Motif motif = controle.GetMotifs()[cmb_Abs_Ajout_Motif.SelectedIndex];
            Personnel personnel = controle.GetPersonnels()[lst_Perso.SelectedIndex];
            if (grp_Abs_Ajout.Text.Equals("Modifier une Absence"))
            {
                Absence absence = controle.GetAbsences(personnel.IdPersonnel)[lst_Abs.SelectedIndex];
                Absence abs = new Absence(absence.IdPersonnel, motif.IdMotif, dateDebut, dateFin);
                controle.ModifAbsence(abs);
            }
            else
            {
                Absence abs = new Absence(personnel.IdPersonnel, motif.IdMotif, dateDebut, dateFin);
                controle.AddAbsence(abs);
            }
            Remplir_lst_Absence(controle.GetPersonnels()[lst_Perso.SelectedIndex].IdPersonnel);
            ClosePannel_Ajout_Abs();
        }

        /// <summary>
        /// Vérifie si la date de fin est bien après la date de début
        /// </summary>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <returns>vrai si les dates suive un ordre chronologique</returns>
        private bool VerifieAnomalieDates(DateTime datedebut, DateTime datefin)
        {
            if (datedebut <= datefin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// retourne vrai si tout les parametres d'ajout/modification d'absence sont bien remplis
        /// </summary>
        /// <returns>vrai si tout les parametres sont remplis</returns>
        private bool VerifAbsParam()
        {
            if (cmb_Abs_Ajout_Motif.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Supression d'une absence de la base de donnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Abs_Supprimer_Click(object sender, EventArgs e)
        {
            if (lst_Abs.SelectedIndex != -1)
            {
                DialogResult dialog = MessageBox.Show("Cette action entraînera la suppression des données d'absence de façon définitive. Continuer?", "Confirmation Suppression", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                {
                    Personnel personnel = controle.GetPersonnels()[lst_Perso.SelectedIndex];
                    Absence absence = controle.GetAbsences(personnel.IdPersonnel)[lst_Abs.SelectedIndex];
                    controle.SupprAbsence(absence);
                    Remplir_lst_Absence(personnel.IdPersonnel);
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une absence");
            }
        }

        #endregion

        #region Connexion à l'application

        /// <summary>
        /// Gere la connexion de l'utilisateur à l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            EssaiConnexion();
        }


        private void EssaiConnexion()
        {
            if (!txt_Identifiant.Text.Equals("") && !txt_MotDePasse.Text.Equals(""))
            {
                if (!controle.ControleIdentite(txt_Identifiant.Text, txt_MotDePasse.Text))
                {
                    lbl_error.Text = "Identifiant ou Mot de passe invalide!";
                    txt_Identifiant.Text = "";
                    txt_MotDePasse.Text = "";
                    txt_Identifiant.Focus();
                }
            }
            else
            {
                lbl_error.Text = "Tous les champs doivent être remplis";
                // place le focus sur la première ligne vide. 
                if (txt_Identifiant.Text.Equals(""))
                    txt_Identifiant.Focus();
                else
                    txt_MotDePasse.Focus();
            }
        }

        /// <summary>
        /// Gere la deconnexion de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Deconnect_Click(object sender, EventArgs e)
        {
            StatusDepart();
            lst_Perso.Items.Clear();
            lst_Abs.Items.Clear();
        }

        /// <summary>
        /// Offre la possibilité de connexion en pressant entrer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Identifiant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EssaiConnexion();
            }
        }

        /// <summary>
        /// Offre la possibilité de connexion en pressant entrer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_MotDePasse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                EssaiConnexion();
            }
        }

        #endregion
    }
}
