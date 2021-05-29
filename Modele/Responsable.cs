using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Modele
{
    class Responsable
    {
        private string login;
        private string pwd;

        #region Getteur
        public string Login { get => login; }
        public string Pwd { get => pwd; set => pwd = value; }
        #endregion

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }
    }
}
