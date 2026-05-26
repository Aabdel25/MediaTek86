using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier représentant le responsable de l'application
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="login">login du responsable</param>
        /// <param name="pwd">mot de passe du responsable</param>
        public Responsable(string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }
        /// <summary>
        /// Login du responsable
        /// </summary>
        public string Login { get; }
        /// <summary>
        /// Mot de passe du responsable
        /// </summary>
        public string Pwd { get; }
    }
}