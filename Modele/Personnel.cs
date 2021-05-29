using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Modele
{
    class Personnel
    {
        private int idPersonnel;
        private int idService;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;

        #region Getteur
        public int IdPersonnel { get => idPersonnel; }
        public int IdService { get => idService; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Tel { get => tel; }
        public string Mail { get => mail; }
        #endregion

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="idService"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        public Personnel(int idPersonnel, int idService, string nom, string prenom, string tel, string mail)
        {
            this.idPersonnel = idPersonnel;
            this.idService = idService;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
        }
    }
}
