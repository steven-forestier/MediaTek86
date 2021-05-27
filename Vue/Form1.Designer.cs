namespace MediaTek86
{
    partial class Form1
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
            this.grp_Perso = new System.Windows.Forms.GroupBox();
            this.grp_Abs = new System.Windows.Forms.GroupBox();
            this.grp_Deconnect = new System.Windows.Forms.GroupBox();
            this.grp_Connect = new System.Windows.Forms.GroupBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txt_MotDePasse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Identifiant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_Identifiant = new System.Windows.Forms.Label();
            this.btn_Deconnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lst_Perso = new System.Windows.Forms.ListBox();
            this.btn_Perso_Ajouter = new System.Windows.Forms.Button();
            this.btn_Perso_Modifer = new System.Windows.Forms.Button();
            this.btn_Perso_Supprimer = new System.Windows.Forms.Button();
            this.grp_Perso_Ajout = new System.Windows.Forms.GroupBox();
            this.txt_Perso_Ajout_Nom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Perso_Ajout_Prenom = new System.Windows.Forms.TextBox();
            this.txt_Perso_Ajout_Tel = new System.Windows.Forms.TextBox();
            this.txt_Perso_Ajout_Mail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Perso_Ajout_Affectation = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Perso8ajout_Annuler = new System.Windows.Forms.Button();
            this.btn_Peso_Ajout_Valider = new System.Windows.Forms.Button();
            this.btn_Abs_Supprimer = new System.Windows.Forms.Button();
            this.btn_Abs_Modifier = new System.Windows.Forms.Button();
            this.btn_Abs_Ajouter = new System.Windows.Forms.Button();
            this.lst_Abs = new System.Windows.Forms.ListBox();
            this.grp_Abs_Ajout = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_Abs_Debut = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_Abs_Fin = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_Abs_Ajout_Motif = new System.Windows.Forms.ComboBox();
            this.btn_Abs_Ajout_Valider = new System.Windows.Forms.Button();
            this.btn_Abs_Ajout_Annuler = new System.Windows.Forms.Button();
            this.grp_Perso.SuspendLayout();
            this.grp_Abs.SuspendLayout();
            this.grp_Deconnect.SuspendLayout();
            this.grp_Connect.SuspendLayout();
            this.grp_Perso_Ajout.SuspendLayout();
            this.grp_Abs_Ajout.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Perso
            // 
            this.grp_Perso.Controls.Add(this.btn_Perso_Supprimer);
            this.grp_Perso.Controls.Add(this.btn_Perso_Modifer);
            this.grp_Perso.Controls.Add(this.btn_Perso_Ajouter);
            this.grp_Perso.Controls.Add(this.lst_Perso);
            this.grp_Perso.Location = new System.Drawing.Point(265, 12);
            this.grp_Perso.Name = "grp_Perso";
            this.grp_Perso.Size = new System.Drawing.Size(250, 410);
            this.grp_Perso.TabIndex = 0;
            this.grp_Perso.TabStop = false;
            this.grp_Perso.Text = "Personnel";
            // 
            // grp_Abs
            // 
            this.grp_Abs.Controls.Add(this.btn_Abs_Supprimer);
            this.grp_Abs.Controls.Add(this.lst_Abs);
            this.grp_Abs.Controls.Add(this.btn_Abs_Modifier);
            this.grp_Abs.Controls.Add(this.btn_Abs_Ajouter);
            this.grp_Abs.Location = new System.Drawing.Point(521, 12);
            this.grp_Abs.Name = "grp_Abs";
            this.grp_Abs.Size = new System.Drawing.Size(293, 410);
            this.grp_Abs.TabIndex = 1;
            this.grp_Abs.TabStop = false;
            this.grp_Abs.Text = "Absence";
            // 
            // grp_Deconnect
            // 
            this.grp_Deconnect.Controls.Add(this.label4);
            this.grp_Deconnect.Controls.Add(this.btn_Deconnect);
            this.grp_Deconnect.Controls.Add(this.lbl_Identifiant);
            this.grp_Deconnect.Location = new System.Drawing.Point(12, 12);
            this.grp_Deconnect.Name = "grp_Deconnect";
            this.grp_Deconnect.Size = new System.Drawing.Size(247, 69);
            this.grp_Deconnect.TabIndex = 2;
            this.grp_Deconnect.TabStop = false;
            // 
            // grp_Connect
            // 
            this.grp_Connect.Controls.Add(this.lbl_error);
            this.grp_Connect.Controls.Add(this.label2);
            this.grp_Connect.Controls.Add(this.txt_Identifiant);
            this.grp_Connect.Controls.Add(this.label1);
            this.grp_Connect.Controls.Add(this.txt_MotDePasse);
            this.grp_Connect.Controls.Add(this.btn_Connect);
            this.grp_Connect.Location = new System.Drawing.Point(12, 87);
            this.grp_Connect.Name = "grp_Connect";
            this.grp_Connect.Size = new System.Drawing.Size(247, 115);
            this.grp_Connect.TabIndex = 3;
            this.grp_Connect.TabStop = false;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(6, 84);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(95, 23);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "Se Connecter";
            this.btn_Connect.UseVisualStyleBackColor = true;
            // 
            // txt_MotDePasse
            // 
            this.txt_MotDePasse.Location = new System.Drawing.Point(90, 45);
            this.txt_MotDePasse.Name = "txt_MotDePasse";
            this.txt_MotDePasse.Size = new System.Drawing.Size(150, 20);
            this.txt_MotDePasse.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Identifiant :";
            // 
            // txt_Identifiant
            // 
            this.txt_Identifiant.Location = new System.Drawing.Point(90, 19);
            this.txt_Identifiant.Name = "txt_Identifiant";
            this.txt_Identifiant.Size = new System.Drawing.Size(150, 20);
            this.txt_Identifiant.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de Passe :";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(25, 68);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(176, 13);
            this.lbl_error.TabIndex = 8;
            this.lbl_error.Text = "Identifiant ou Mot de Passe Invalide";
            // 
            // lbl_Identifiant
            // 
            this.lbl_Identifiant.AutoSize = true;
            this.lbl_Identifiant.Location = new System.Drawing.Point(63, 16);
            this.lbl_Identifiant.Name = "lbl_Identifiant";
            this.lbl_Identifiant.Size = new System.Drawing.Size(53, 13);
            this.lbl_Identifiant.TabIndex = 0;
            this.lbl_Identifiant.Text = "Utilisateur";
            // 
            // btn_Deconnect
            // 
            this.btn_Deconnect.Location = new System.Drawing.Point(6, 40);
            this.btn_Deconnect.Name = "btn_Deconnect";
            this.btn_Deconnect.Size = new System.Drawing.Size(95, 23);
            this.btn_Deconnect.TabIndex = 1;
            this.btn_Deconnect.Text = "Se deconnecter";
            this.btn_Deconnect.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bienvenue,";
            // 
            // lst_Perso
            // 
            this.lst_Perso.FormattingEnabled = true;
            this.lst_Perso.Location = new System.Drawing.Point(6, 19);
            this.lst_Perso.Name = "lst_Perso";
            this.lst_Perso.Size = new System.Drawing.Size(238, 355);
            this.lst_Perso.TabIndex = 0;
            // 
            // btn_Perso_Ajouter
            // 
            this.btn_Perso_Ajouter.Location = new System.Drawing.Point(8, 381);
            this.btn_Perso_Ajouter.Name = "btn_Perso_Ajouter";
            this.btn_Perso_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Perso_Ajouter.TabIndex = 1;
            this.btn_Perso_Ajouter.Text = "Ajouter";
            this.btn_Perso_Ajouter.UseVisualStyleBackColor = true;
            // 
            // btn_Perso_Modifer
            // 
            this.btn_Perso_Modifer.Location = new System.Drawing.Point(89, 380);
            this.btn_Perso_Modifer.Name = "btn_Perso_Modifer";
            this.btn_Perso_Modifer.Size = new System.Drawing.Size(75, 23);
            this.btn_Perso_Modifer.TabIndex = 2;
            this.btn_Perso_Modifer.Text = "Modifier";
            this.btn_Perso_Modifer.UseVisualStyleBackColor = true;
            // 
            // btn_Perso_Supprimer
            // 
            this.btn_Perso_Supprimer.Location = new System.Drawing.Point(171, 380);
            this.btn_Perso_Supprimer.Name = "btn_Perso_Supprimer";
            this.btn_Perso_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_Perso_Supprimer.TabIndex = 3;
            this.btn_Perso_Supprimer.Text = "Supprimer";
            this.btn_Perso_Supprimer.UseVisualStyleBackColor = true;
            // 
            // grp_Perso_Ajout
            // 
            this.grp_Perso_Ajout.Controls.Add(this.btn_Peso_Ajout_Valider);
            this.grp_Perso_Ajout.Controls.Add(this.btn_Perso8ajout_Annuler);
            this.grp_Perso_Ajout.Controls.Add(this.label9);
            this.grp_Perso_Ajout.Controls.Add(this.cmb_Perso_Ajout_Affectation);
            this.grp_Perso_Ajout.Controls.Add(this.label8);
            this.grp_Perso_Ajout.Controls.Add(this.txt_Perso_Ajout_Mail);
            this.grp_Perso_Ajout.Controls.Add(this.txt_Perso_Ajout_Tel);
            this.grp_Perso_Ajout.Controls.Add(this.txt_Perso_Ajout_Prenom);
            this.grp_Perso_Ajout.Controls.Add(this.label7);
            this.grp_Perso_Ajout.Controls.Add(this.label6);
            this.grp_Perso_Ajout.Controls.Add(this.label5);
            this.grp_Perso_Ajout.Controls.Add(this.txt_Perso_Ajout_Nom);
            this.grp_Perso_Ajout.Location = new System.Drawing.Point(265, 428);
            this.grp_Perso_Ajout.Name = "grp_Perso_Ajout";
            this.grp_Perso_Ajout.Size = new System.Drawing.Size(250, 181);
            this.grp_Perso_Ajout.TabIndex = 4;
            this.grp_Perso_Ajout.TabStop = false;
            // 
            // txt_Perso_Ajout_Nom
            // 
            this.txt_Perso_Ajout_Nom.Location = new System.Drawing.Point(80, 16);
            this.txt_Perso_Ajout_Nom.Name = "txt_Perso_Ajout_Nom";
            this.txt_Perso_Ajout_Nom.Size = new System.Drawing.Size(164, 20);
            this.txt_Perso_Ajout_Nom.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Prenom :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tel :";
            // 
            // txt_Perso_Ajout_Prenom
            // 
            this.txt_Perso_Ajout_Prenom.Location = new System.Drawing.Point(80, 42);
            this.txt_Perso_Ajout_Prenom.Name = "txt_Perso_Ajout_Prenom";
            this.txt_Perso_Ajout_Prenom.Size = new System.Drawing.Size(164, 20);
            this.txt_Perso_Ajout_Prenom.TabIndex = 4;
            // 
            // txt_Perso_Ajout_Tel
            // 
            this.txt_Perso_Ajout_Tel.Location = new System.Drawing.Point(80, 69);
            this.txt_Perso_Ajout_Tel.Name = "txt_Perso_Ajout_Tel";
            this.txt_Perso_Ajout_Tel.Size = new System.Drawing.Size(164, 20);
            this.txt_Perso_Ajout_Tel.TabIndex = 5;
            // 
            // txt_Perso_Ajout_Mail
            // 
            this.txt_Perso_Ajout_Mail.Location = new System.Drawing.Point(80, 96);
            this.txt_Perso_Ajout_Mail.Name = "txt_Perso_Ajout_Mail";
            this.txt_Perso_Ajout_Mail.Size = new System.Drawing.Size(164, 20);
            this.txt_Perso_Ajout_Mail.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mail :";
            // 
            // cmb_Perso_Ajout_Affectation
            // 
            this.cmb_Perso_Ajout_Affectation.FormattingEnabled = true;
            this.cmb_Perso_Ajout_Affectation.Location = new System.Drawing.Point(80, 123);
            this.cmb_Perso_Ajout_Affectation.Name = "cmb_Perso_Ajout_Affectation";
            this.cmb_Perso_Ajout_Affectation.Size = new System.Drawing.Size(164, 21);
            this.cmb_Perso_Ajout_Affectation.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Affectation :";
            // 
            // btn_Perso8ajout_Annuler
            // 
            this.btn_Perso8ajout_Annuler.Location = new System.Drawing.Point(145, 150);
            this.btn_Perso8ajout_Annuler.Name = "btn_Perso8ajout_Annuler";
            this.btn_Perso8ajout_Annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_Perso8ajout_Annuler.TabIndex = 10;
            this.btn_Perso8ajout_Annuler.Text = "Annuler";
            this.btn_Perso8ajout_Annuler.UseVisualStyleBackColor = true;
            // 
            // btn_Peso_Ajout_Valider
            // 
            this.btn_Peso_Ajout_Valider.Location = new System.Drawing.Point(28, 150);
            this.btn_Peso_Ajout_Valider.Name = "btn_Peso_Ajout_Valider";
            this.btn_Peso_Ajout_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Peso_Ajout_Valider.TabIndex = 11;
            this.btn_Peso_Ajout_Valider.Text = "Valider";
            this.btn_Peso_Ajout_Valider.UseVisualStyleBackColor = true;
            // 
            // btn_Abs_Supprimer
            // 
            this.btn_Abs_Supprimer.Location = new System.Drawing.Point(189, 377);
            this.btn_Abs_Supprimer.Name = "btn_Abs_Supprimer";
            this.btn_Abs_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_Abs_Supprimer.TabIndex = 7;
            this.btn_Abs_Supprimer.Text = "Supprimer";
            this.btn_Abs_Supprimer.UseVisualStyleBackColor = true;
            // 
            // btn_Abs_Modifier
            // 
            this.btn_Abs_Modifier.Location = new System.Drawing.Point(107, 377);
            this.btn_Abs_Modifier.Name = "btn_Abs_Modifier";
            this.btn_Abs_Modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_Abs_Modifier.TabIndex = 6;
            this.btn_Abs_Modifier.Text = "Modifier";
            this.btn_Abs_Modifier.UseVisualStyleBackColor = true;
            // 
            // btn_Abs_Ajouter
            // 
            this.btn_Abs_Ajouter.Location = new System.Drawing.Point(26, 378);
            this.btn_Abs_Ajouter.Name = "btn_Abs_Ajouter";
            this.btn_Abs_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Abs_Ajouter.TabIndex = 5;
            this.btn_Abs_Ajouter.Text = "Ajouter";
            this.btn_Abs_Ajouter.UseVisualStyleBackColor = true;
            // 
            // lst_Abs
            // 
            this.lst_Abs.FormattingEnabled = true;
            this.lst_Abs.Location = new System.Drawing.Point(6, 16);
            this.lst_Abs.Name = "lst_Abs";
            this.lst_Abs.Size = new System.Drawing.Size(281, 355);
            this.lst_Abs.TabIndex = 4;
            // 
            // grp_Abs_Ajout
            // 
            this.grp_Abs_Ajout.Controls.Add(this.btn_Abs_Ajout_Valider);
            this.grp_Abs_Ajout.Controls.Add(this.cmb_Abs_Ajout_Motif);
            this.grp_Abs_Ajout.Controls.Add(this.btn_Abs_Ajout_Annuler);
            this.grp_Abs_Ajout.Controls.Add(this.label12);
            this.grp_Abs_Ajout.Controls.Add(this.dtp_Abs_Fin);
            this.grp_Abs_Ajout.Controls.Add(this.label11);
            this.grp_Abs_Ajout.Controls.Add(this.dtp_Abs_Debut);
            this.grp_Abs_Ajout.Controls.Add(this.label10);
            this.grp_Abs_Ajout.Location = new System.Drawing.Point(521, 428);
            this.grp_Abs_Ajout.Name = "grp_Abs_Ajout";
            this.grp_Abs_Ajout.Size = new System.Drawing.Size(293, 181);
            this.grp_Abs_Ajout.TabIndex = 5;
            this.grp_Abs_Ajout.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Date de début :";
            // 
            // dtp_Abs_Debut
            // 
            this.dtp_Abs_Debut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_Abs_Debut.Location = new System.Drawing.Point(93, 16);
            this.dtp_Abs_Debut.Name = "dtp_Abs_Debut";
            this.dtp_Abs_Debut.Size = new System.Drawing.Size(194, 20);
            this.dtp_Abs_Debut.TabIndex = 2;
            this.dtp_Abs_Debut.TabStop = false;
            this.dtp_Abs_Debut.Value = new System.DateTime(2021, 5, 27, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Date de fin :";
            // 
            // dtp_Abs_Fin
            // 
            this.dtp_Abs_Fin.Location = new System.Drawing.Point(93, 42);
            this.dtp_Abs_Fin.Name = "dtp_Abs_Fin";
            this.dtp_Abs_Fin.Size = new System.Drawing.Size(194, 20);
            this.dtp_Abs_Fin.TabIndex = 4;
            this.dtp_Abs_Fin.Value = new System.DateTime(2021, 5, 27, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Motif :";
            // 
            // cmb_Abs_Ajout_Motif
            // 
            this.cmb_Abs_Ajout_Motif.FormattingEnabled = true;
            this.cmb_Abs_Ajout_Motif.Location = new System.Drawing.Point(93, 68);
            this.cmb_Abs_Ajout_Motif.Name = "cmb_Abs_Ajout_Motif";
            this.cmb_Abs_Ajout_Motif.Size = new System.Drawing.Size(194, 21);
            this.cmb_Abs_Ajout_Motif.TabIndex = 6;
            // 
            // btn_Abs_Ajout_Valider
            // 
            this.btn_Abs_Ajout_Valider.Location = new System.Drawing.Point(50, 96);
            this.btn_Abs_Ajout_Valider.Name = "btn_Abs_Ajout_Valider";
            this.btn_Abs_Ajout_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Abs_Ajout_Valider.TabIndex = 13;
            this.btn_Abs_Ajout_Valider.Text = "Valider";
            this.btn_Abs_Ajout_Valider.UseVisualStyleBackColor = true;
            // 
            // btn_Abs_Ajout_Annuler
            // 
            this.btn_Abs_Ajout_Annuler.Location = new System.Drawing.Point(189, 96);
            this.btn_Abs_Ajout_Annuler.Name = "btn_Abs_Ajout_Annuler";
            this.btn_Abs_Ajout_Annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_Abs_Ajout_Annuler.TabIndex = 12;
            this.btn_Abs_Ajout_Annuler.Text = "Annuler";
            this.btn_Abs_Ajout_Annuler.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 621);
            this.Controls.Add(this.grp_Abs_Ajout);
            this.Controls.Add(this.grp_Perso_Ajout);
            this.Controls.Add(this.grp_Connect);
            this.Controls.Add(this.grp_Deconnect);
            this.Controls.Add(this.grp_Abs);
            this.Controls.Add(this.grp_Perso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_Perso.ResumeLayout(false);
            this.grp_Abs.ResumeLayout(false);
            this.grp_Deconnect.ResumeLayout(false);
            this.grp_Deconnect.PerformLayout();
            this.grp_Connect.ResumeLayout(false);
            this.grp_Connect.PerformLayout();
            this.grp_Perso_Ajout.ResumeLayout(false);
            this.grp_Perso_Ajout.PerformLayout();
            this.grp_Abs_Ajout.ResumeLayout(false);
            this.grp_Abs_Ajout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Perso;
        private System.Windows.Forms.GroupBox grp_Abs;
        private System.Windows.Forms.GroupBox grp_Deconnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Deconnect;
        private System.Windows.Forms.Label lbl_Identifiant;
        private System.Windows.Forms.GroupBox grp_Connect;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Identifiant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MotDePasse;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Perso_Supprimer;
        private System.Windows.Forms.Button btn_Perso_Modifer;
        private System.Windows.Forms.Button btn_Perso_Ajouter;
        private System.Windows.Forms.ListBox lst_Perso;
        private System.Windows.Forms.GroupBox grp_Perso_Ajout;
        private System.Windows.Forms.Button btn_Perso8ajout_Annuler;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_Perso_Ajout_Affectation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Perso_Ajout_Mail;
        private System.Windows.Forms.TextBox txt_Perso_Ajout_Tel;
        private System.Windows.Forms.TextBox txt_Perso_Ajout_Prenom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Perso_Ajout_Nom;
        private System.Windows.Forms.Button btn_Abs_Supprimer;
        private System.Windows.Forms.ListBox lst_Abs;
        private System.Windows.Forms.Button btn_Abs_Modifier;
        private System.Windows.Forms.Button btn_Abs_Ajouter;
        private System.Windows.Forms.Button btn_Peso_Ajout_Valider;
        private System.Windows.Forms.GroupBox grp_Abs_Ajout;
        private System.Windows.Forms.Button btn_Abs_Ajout_Valider;
        private System.Windows.Forms.ComboBox cmb_Abs_Ajout_Motif;
        private System.Windows.Forms.Button btn_Abs_Ajout_Annuler;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtp_Abs_Fin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_Abs_Debut;
        private System.Windows.Forms.Label label10;
    }
}

