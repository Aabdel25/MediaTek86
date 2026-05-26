using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier représentant un service de la médiathèque
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idservice">identifiant du service</param>
        /// <param name="nom">nom du service</param>
        public Service(int idservice, string nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }
        /// <summary>
        /// Identifiant du service
        /// </summary>
        public int Idservice { get; }
        /// <summary>
        /// Nom du service
        /// </summary>
        public string Nom { get; set; }
    }
}