using MediaTek86.dal;
using MediaTek86.model;
using System.Collections.Generic;

namespace MediaTek86.controller
{
    /// <summary>
    /// Contrôleur du formulaire des absences
    /// </summary>
    public class FrmAbsenceController
    {
        /// <summary>
        /// Accès aux données des absences
        /// </summary>
        private readonly AbsenceAccess absenceAccess;
        /// <summary>
        /// Accès aux données des motifs
        /// </summary>
        private readonly MotifAccess motifAccess;

        /// <summary>
        /// Constructeur : instancie les classes DAL
        /// </summary>
        public FrmAbsenceController()
        {
            absenceAccess = new AbsenceAccess();
            motifAccess = new MotifAccess();
        }

        /// <summary>
        /// Retourne les absences d'un personnel
        /// </summary>
        /// <param name="idpersonnel">identifiant du personnel</param>
        /// <returns>liste des absences</returns>
        public List<Absence> GetLesAbsences(int idpersonnel)
        {
            return absenceAccess.GetLesAbsences(idpersonnel);
        }

        /// <summary>
        /// Retourne la liste de tous les motifs
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// Ajoute une absence
        /// </summary>
        /// <param name="absence">absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }

        /// <summary>
        /// Modifie une absence
        /// </summary>
        /// <param name="absence">absence à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            absenceAccess.UpdateAbsence(absence);
        }

        /// <summary>
        /// Supprime une absence
        /// </summary>
        /// <param name="absence">absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }
    }
}