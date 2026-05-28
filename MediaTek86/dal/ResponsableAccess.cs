using MediaTek86.bddManager;
using MediaTek86.model;
using System;
using System.Collections.Generic;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe d'accès aux données pour le responsable (authentification)
    /// </summary>
    public class ResponsableAccess
    {
        /// <summary>
        /// Objet d'accès à BddManager (même pattern que Habilitations)
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Constructeur : récupère l'instance unique d'Access
        /// </summary>
        public ResponsableAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// CU1 - Vérifie les identifiants du responsable en base de données.
        /// Compare le login et le mot de passe hashé en SHA2-256.
        /// </summary>
        /// <param name="login">login saisi par l'utilisateur</param>
        /// <param name="pwd">mot de passe en clair saisi par l'utilisateur</param>
        /// <returns>true si les identifiants sont corrects, false sinon</returns>
        public bool ControleAuthentification(string login, string pwd)
        {
            if (access.Manager != null)
            {
                string req = "select login from responsable ";
                req += "where BINARY login = @login and pwd = SHA2(@pwd, 256);";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@login", login },
                    { "@pwd",   pwd   }
                };
                try
                {
                    List<object[]> records = access.Manager.ReqSelect(req, parameters);
                    return (records.Count > 0);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return false;
        }
    }
}