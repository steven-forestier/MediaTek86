using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.Connexion
{
    public class ConnectionBDD
    {
        #region Singleton
        /// <summary>
        /// Unique instance de la classe
        /// </summary>
        private static ConnectionBDD instance = null;

        /// <summary>
        /// Creer une instance unique de la classe si elle n'existe pas déjà
        /// </summary>
        /// <returns></returns>
        public static ConnectionBDD GetInstance(string chaineConnection)
        {
            if (ConnectionBDD.instance == null)
            {
                instance = new ConnectionBDD(chaineConnection);
            }
            return instance;
        }
        #endregion
        
        /// <summary>
        /// objet permettant la connection à la base de donnée à partir d'une chaîne de connection
        /// </summary>
        private MySqlConnection connection;

        /// <summary>
        /// objet permettant d'éxecuter une requête SQL
        /// </summary>
        private MySqlCommand cmd;

        /// <summary>
        /// objet qui contient le résultat d'une requête select
        /// curseur
        /// </summary>
        private MySqlDataReader reader;

        /// <summary>
        /// Constructeur privé pour creer et ouvrir la connexion à la base de donnée
        /// </summary>
        /// <param name="chaineConnection"></param>
        private ConnectionBDD(string chaineConnection)
        {
            try
            {
                connection = new MySqlConnection(chaineConnection);
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Application.Exit();
            }
        }

        #region Curseur et Requêtes
        /// <summary>
        /// Exécute une demande d'un type autre que SELECT
        /// </summary>
        /// <param name="chaineDemande"></param>
        /// <param name="parametres"></param>
        public void ReqUpdate(string chaineDemande, Dictionary<string, object> parametres)
        {
            try
            {
                cmd = new MySqlCommand(chaineDemande, connection);
                foreach(KeyValuePair<string, object> parametre in parametres)
                {
                    cmd.Parameters.Add(new MySqlParameter(parametre.Key, parametre.Value));
                }
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Execute une requête SELECT
        /// </summary>
        /// <param name="chaineDemande"></param>
        public void ReqSelect(string chaineDemande)
        {
            try
            {
                cmd = new MySqlCommand(chaineDemande, connection);
                reader = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Execute une requête SELECT avec un parametre de recherche spécifique
        /// </summary>
        /// <param name="chaineDemande"></param>
        /// <param name="parameters"></param>
        public void ReqSelect(string chaineDemande, Dictionary<string, object> parameters)
        {
            try
            {
                cmd = new MySqlCommand(chaineDemande, connection);
                foreach(KeyValuePair<string,object> parametre in parameters)
                {
                    cmd.Parameters.Add(new MySqlParameter(parametre.Key, parametre.Value));
                }
                cmd.Prepare();
                reader = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Essai de lire la ligne suivante du curseur
        /// </summary>
        /// <returns>Faux si le curseur a atteint la dernière ligne</returns>
        public bool Read()
        {
            if(reader is null)
                return false;
            try
            {
                return reader.Read();
            }
            catch
            {
                return false;
            }            
        }

        /// <summary>
        /// Retourne le contenu du champ dont le nom est en paramètre
        /// </summary>
        /// <param name="nameField"></param>
        /// <returns>valeur du champ nomé</returns>
        public object Field(string nameField)
        {
            if (reader is null)
            {
                return null;
            }
            try
            {
                return reader[nameField];
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Ferme le curseur
        /// </summary>
        public void Close()
        {
            if(!(reader is null))
            {
                reader.Close();
            }
        }
        #endregion
    }
}
