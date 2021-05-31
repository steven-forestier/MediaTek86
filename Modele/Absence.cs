using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Modele
{
    public class Absence
    {
        private int idPersonnel;
        private int idMotif;
        private DateTime dateDebut;
        private DateTime dateFin;

        #region Getteur
        public int IdPersonnel { get => idPersonnel; }
        public int IdMotif { get => idMotif; }
        public DateTime DateDebut { get => dateDebut; }
        public DateTime DateFin { get => dateFin; }
        #endregion

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="idMotif"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        public Absence(int idPersonnel, int idMotif, DateTime dateDebut, DateTime dateFin)
        {
            this.idPersonnel = idPersonnel;
            this.idMotif = idMotif;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
        }
    }
}
