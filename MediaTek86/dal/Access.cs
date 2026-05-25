using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.bddManager;

namespace MediaTek86.dal
{
    /// <summary>
    /// Singleton : classe d'accès à BddManager
    /// </summary>
    public class Access
    {
        /// <summary>
        /// chaîne de connexion à la BDD
        /// </summary>
        private static readonly string connectionString =
            "server=localhost;user id=mediatek86;password=mediatek86pwd;database=mediatek86;";
        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private static Access instance = null;
        /// <summary>
        /// Getter sur l'objet d'accès aux données
        /// </summary>
        public BddManager Manager { get; }
        /// <summary>
        /// Création unique de l'objet de type BddManager
        /// </summary>
        private Access()
        {
            Manager = BddManager.GetInstance(connectionString);
        }
        /// <summary>
        /// Création d'une seule instance de la classe
        /// </summary>
        /// <returns>instance unique de la classe</returns>
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }
    }
}