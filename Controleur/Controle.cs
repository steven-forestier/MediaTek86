using System;
using System.Collections.Generic;
using MediaTek86.dal;
using MediaTek86.Modele;
using MediaTek86.Vue;


namespace MediaTek86.Controleur
{
    class Controle
    {
        public Controle()
        {
            (new FormGestion(this)).ShowDialog();
        }

        #region Getteur Données BDD
        /// <summary>
        /// Récupère la liste du Personnel de la BDD et la retourne
        /// </summary>
        /// <returns>liste du personnel</returns>
        public List<Personnel> GetPersonnels()
        {
            return AccesDonneesBDD.GetLePersonnel();
        }

        /// <summary>
        /// Récupère la liste des absences de la bdd et la retourne
        /// </summary>
        /// <returns>liste des absences</returns>
        public List<Absence> GetAbsences()
        {
            return AccesDonneesBDD.GetLesAbsences();
        }

        /// <summary>
        /// Récupère la liste des services de la bdd et la retourne
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetServices()
        {
            return AccesDonneesBDD.GetLesServices();
        }

        /// <summary>
        /// Récupère la liste des motifs de la bdd et la retourne
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetMotifs()
        {
            return AccesDonneesBDD.GetLesMotifs();
        }

        /// <summary>
        /// Récupère la liste des responsable de la bdd et la retourne
        /// </summary>
        /// <returns></returns>
        public List<Responsable> GetResponsable()
        {
            return AccesDonneesBDD.GetLeResponsable();
        }

        #endregion
        #region Add/Mod/Suppr Personnel

        /// <summary>
        /// Permet l'ajout d'un membre du personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void AddPersonnel(Personnel personnel)
        {
            AccesDonneesBDD.AddPersonnel(personnel);
        }

        /// <summary>
        /// Permet la modification d'un membre du personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void ModifPersonnel(Personnel personnel)
        {
            AccesDonneesBDD.MajPersonnel(personnel);
        }

        /// <summary>
        /// Permet la suppression d'un membre du Personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void SupprPersonnel(Personnel personnel)
        {
            AccesDonneesBDD.SupprPersonnel(personnel);
        }
        #endregion
        #region Add/Mod/Suppr Absence
        /// <summary>
        /// Permet l'ajout d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void AddAbsence(Absence absence)
        {
            AccesDonneesBDD.AddAbsence(absence);
        }

        /// <summary>
        /// Permet de modifier une absence
        /// </summary>
        /// <param name="absence"></param>
        public void ModifAbsence(Absence absence)
        {
            AccesDonneesBDD.MajAbsence(absence);
        }

        /// <summary>
        /// Permet la suppression d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void SupprAbsence(Absence absence)
        {
            AccesDonneesBDD.SupprAbsence(absence);
        }
        #endregion

    }
}
