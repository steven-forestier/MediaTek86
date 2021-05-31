using System;
using System.Collections.Generic;
using MediaTek86.Connexion;
using MediaTek86.Modele;


namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les données distantes
    /// </summary>
    public class AccesDonneesBDD
    {
        /// <summary>
        /// chaine de connexion à la DBB
        /// </summary>
        private static string chaineConnexion = "server=localhost;user id=root;database=slamap;SslMode=none";

        #region Getteur BDD
        /// <summary>
        /// Récupère la liste du personnel dans la bdd et la retourne
        /// </summary>
        /// <returns>liste du personnel</returns>
        public static List<Personnel> GetLePersonnel()
        {
            List<Personnel> lePersonnel = new List<Personnel>();
            string req = "select * from personnel order by nom, prenom";
            ConnectionBDD curseur = ConnectionBDD.GetInstance(chaineConnexion);
            curseur.ReqSelect(req);
            while (curseur.Read())
            {
                Personnel personnel = new Personnel((int)curseur.Field("idpersonnel"), (int)curseur.Field("idservice"), (string)curseur.Field("nom"), (string)curseur.Field("prenom"), (string)curseur.Field("tel"), (string)curseur.Field("mail"));
                lePersonnel.Add(personnel);
            }
            curseur.Close();
            return lePersonnel;
        }

        /// <summary>
        /// Récupère la liste des services de la bdd et la retourne
        /// </summary>
        /// <returns>liste des services</returns>
        public static List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            string req = "select * from service order by idservice asc";
            ConnectionBDD curseur = ConnectionBDD.GetInstance(chaineConnexion);
            curseur.ReqSelect(req);
            while (curseur.Read())
            {
                Service service = new Service((int)curseur.Field("idservice"), (string)curseur.Field("nom"));
                lesServices.Add(service);
            }
            curseur.Close();
            return lesServices;
        }

        /// <summary>
        /// Récupère la liste des motifs de la bdd et la retourne
        /// </summary>
        /// <returns>liste des motifs</returns>
        public static List<Motif> GetLesMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            string req = "select * from motif order by idmotif asc";
            ConnectionBDD curseur = ConnectionBDD.GetInstance(chaineConnexion);
            curseur.ReqSelect(req);
            while (curseur.Read())
            {
                Motif motif = new Motif((int)curseur.Field("idmotif"), (string)curseur.Field("libelle"));
                lesMotifs.Add(motif);
            }
            curseur.Close();
            return lesMotifs;
        }

        /// <summary>
        /// Récupère la liste des absences de la bdd et la retourne
        /// </summary>
        /// <returns>liste des absences</returns>
        public static List<Absence> GetLesAbsences(int id)
        {
            List<Absence> lesAbsences = new List<Absence>();
            string req = "select * from absence where idpersonnel = @idpersonnel order by datedebut desc";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", id);
            ConnectionBDD curseur = ConnectionBDD.GetInstance(chaineConnexion);
            curseur.ReqSelect(req, parameters);
            while (curseur.Read())
            {
                Absence absence = new Absence((int)curseur.Field("idpersonnel"), (int)curseur.Field("idmotif"), (DateTime)curseur.Field("datedebut"), (DateTime)curseur.Field("datefin"));
                lesAbsences.Add(absence);
            }
            curseur.Close();
            return lesAbsences;
        }

        /// <summary>
        /// Récupère la liste des responsable de la bdd et la retourne
        /// </summary>
        /// <returns></returns>
        public static List<Responsable> GetLeResponsable()
        {
            List<Responsable> responsables = new List<Responsable>();
            string req = "select * from responsable";
            ConnectionBDD curseur = ConnectionBDD.GetInstance(chaineConnexion);
            curseur.ReqSelect(req);
            while (curseur.Read())
            {
                Responsable responsable = new Responsable((string)curseur.Field("login"), (string)curseur.Field("pwd"));
                responsables.Add(responsable);
            }
            curseur.Close();
            return responsables;
        }
        #endregion

        public static Boolean ControleAuthentification(string identifiant,string mdp)
        {
            string req = "select * from responsable r where login = @login and pwd =SHA2(@pwd, 256)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", identifiant);
            parameters.Add("@pwd", mdp);
            ConnectionBDD curs = ConnectionBDD.GetInstance(chaineConnexion);
            curs.ReqSelect(req, parameters);
            if (curs.Read())
            {
                curs.Close();
                return true;
            }
            else
            {
                curs.Close();
                return false;
            }
        }

        #region Controle Personnel
        /// <summary>
        /// Ajoute un membre au personnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void AddPersonnel(Personnel personnel)
        {
            string req = "insert into personnel(idpersonnel, idservice, nom, prenom, tel, mail) ";
            req += "values (@idpersonnel, @idservice, @nom, @prenom, @tel, @mail);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            parameters.Add("@idservice", personnel.IdService);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            ConnectionBDD conn = ConnectionBDD.GetInstance(chaineConnexion);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modification d'un membre du personnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void MajPersonnel(Personnel personnel)
        {
            string req = "update personnel set idservice = @idservice, nom = @nom, prenom = @prenom, tel = @tel, mail = @mail where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            parameters.Add("@idservice", personnel.IdService);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            ConnectionBDD conn = ConnectionBDD.GetInstance(chaineConnexion);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Suppression d'un membre du personnel
        /// </summary>
        /// <param name="personnel">pesonnel a supprimer</param>
        public static void SupprPersonnel(Personnel personnel)
        {
            string req = "delete from personnel where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            ConnectionBDD conn = ConnectionBDD.GetInstance(chaineConnexion);
            conn.ReqUpdate(req, parameters);
        }

        #endregion

        #region Controle Absence
        /// <summary>
        /// Ajoute une absence
        /// </summary>
        /// <param name="absence"></param>
        public static void AddAbsence(Absence absence)
        {
            string req = "insert into absence(idpersonnel, datedebut, idmotif, datefin) ";
            req += "values (@idpersonnel, @datedebut, @idmotif, @datefin);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            parameters.Add("@datedebut", absence.DateDebut);
            parameters.Add("@idmotif", absence.IdMotif);
            parameters.Add("@datefin", absence.DateFin);
            ConnectionBDD conn = ConnectionBDD.GetInstance(chaineConnexion);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modification d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public static void MajAbsence(Absence absence)
        {
            string req = "update absence set datedebut = @datedebut, idmotif = @idmotif, datefin = @datefin ";
            req += "where idpersonnel = @idpersonnel and datedebut = @datedebut;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            parameters.Add("@datedebut", absence.DateDebut);
            parameters.Add("@idmotif", absence.IdMotif);
            parameters.Add("@datefin", absence.DateFin);
            ConnectionBDD conn = ConnectionBDD.GetInstance(chaineConnexion);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Suppression d'une absence
        /// </summary>
        /// <param name="absence">pesonnel a supprimer</param>
        public static void SupprAbsence(Absence absence)
        {
            string req = "delete from absence where idpersonnel = @idpersonnel and datedebut = @datedebut and datefin = @datefin and idmotif = @idmotif;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            parameters.Add("@datedebut", absence.DateDebut);
            parameters.Add("@idmotif", absence.IdMotif);
            parameters.Add("@datefin", absence.DateFin);
            ConnectionBDD conn = ConnectionBDD.GetInstance(chaineConnexion);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Permet la suppresssion de toutes les absences d'un membre du personnel
        /// </summary>
        /// <param name="id"></param>
        public static void SuppreAbsencePersonnel(int id)
        {
            string req = "delete from absence where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", id);
            ConnectionBDD conn = ConnectionBDD.GetInstance(chaineConnexion);
            conn.ReqUpdate(req, parameters);
        }
        #endregion

        // "SERVER=localhost; DATABASE=slamap; UID=root; PASSWORD="
        // "server=localhost;user id=root;database=slamap;SslMode=none"
    }
}
