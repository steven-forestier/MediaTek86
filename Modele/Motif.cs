using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Modele
{
    class Motif
    {
        private int idMotif;
        private string libelle;

        #region Getteur
        public int IdMotif { get => idMotif; }
        public string Libelle { get => libelle; }
        #endregion

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idMotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idMotif, string libelle)
        {
            this.idMotif = idMotif;
            this.libelle = libelle;
        }
    }
}
