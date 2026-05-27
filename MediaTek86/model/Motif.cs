using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier représentant un motif d'absence
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idmotif">identifiant du motif</param>
        /// <param name="libelle">libellé du motif</param>
        public Motif(int idmotif, string libelle)
        {
            this.Idmotif = idmotif;
            this.Libelle = libelle;
        }
        /// <summary>
        /// Identifiant du motif
        /// </summary>
        public int Idmotif { get; }
        /// <summary>
        /// Libellé du motif
        /// </summary>
        public string Libelle { get; set; }
        /// <summary>
        /// Retourne le libellé du motif
        /// </summary>
        /// <returns>libellé du motif</returns>
        public override string ToString()
        {
            return this.Libelle;
        }

    }
}