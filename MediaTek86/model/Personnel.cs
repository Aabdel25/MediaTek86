using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier représentant un membre du personnel
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel">identifiant du personnel</param>
        /// <param name="nom">nom du personnel</param>
        /// <param name="prenom">prénom du personnel</param>
        /// <param name="tel">téléphone du personnel</param>
        /// <param name="mail">mail du personnel</param>
        /// <param name="service">service du personnel</param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Service service)
        {
            this.Idpersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }
        /// <summary>
        /// Identifiant du personnel
        /// </summary>
        public int Idpersonnel { get; }
        /// <summary>
        /// Nom du personnel
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Prénom du personnel
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// Téléphone du personnel
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// Mail du personnel
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// Service du personnel
        /// </summary>
        public Service Service { get; set; }
        
        /// <summary>
        /// Retourne le prénom et le nom du personnel
        /// </summary>
        /// <returns>prénom et nom</returns>
        public override string ToString()
        {
            return this.Prenom + " " + this.Nom;
        }
    }
}