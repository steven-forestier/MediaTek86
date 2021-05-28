using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static MediaTek86.Connexion.ConnectionBDD;


namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les données distantes
    /// </summary>
    class AccesDonnees
    {
        /// <summary>
        /// chaine de connexion à la DBB
        /// </summary>
        private static string chaineConnexion = "server=localhost;user id=root;database=slamap;SslMode=none";




        // "SERVER=localhost; DATABASE=slamap; UID=root; PASSWORD="
        // "server=localhost;user id=root;database=slamap;SslMode=none"
    }
}
