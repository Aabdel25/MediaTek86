using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier représentant une absence
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel">identifiant du personnel</param>
        /// <param name="datedebut">date de début de l'absence</param>
        /// <param name="datefin">date de fin de l'absence</param>
        /// <param name="motif">motif de l'absence</param>
        
        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            this.Idpersonnel = idpersonnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.Motif = motif;
        }
        /// <summary>
        /// Identifiant du personnel concerné
        /// </summary>
        public int Idpersonnel { get; }
        /// <summary>
        /// Date de début de l'absence
        /// </summary>
        public DateTime Datedebut { get; set; }
        /// <summary>
        /// Date de fin de l'absence
        /// </summary>
        public DateTime Datefin { get; set; }
        /// <summary>
        /// Motif de l'absence
        /// </summary>
        public Motif Motif { get; set; }
    }
}