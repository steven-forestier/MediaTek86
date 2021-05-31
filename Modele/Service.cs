using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Modele
{
    public class Service
    {
        private int idService;
        private string nom;

        #region Getteur
        public int IdService { get => idService; }
        public string Nom { get => nom; }
        #endregion

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idService"></param>
        /// <param name="nom"></param>
        public Service(int idService, string nom)
        {
            this.idService = idService;
            this.nom = nom;
        }
    }
}
