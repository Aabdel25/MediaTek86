using MediaTek86.dal;
using MediaTek86.model;
using System.Collections.Generic;

namespace MediaTek86.controller
{
    /// <summary>
    /// Contrôleur du formulaire principal
    /// </summary>
    public class FrmMediaTek86Controller
    {
        /// <summary>
        /// Accès aux données personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;
        /// <summary>
        /// Accès aux données service
        /// </summary>
        private readonly ServiceAccess serviceAccess;

        /// <summary>
        /// Constructeur : instancie les classes DAL
        /// </summary>
        public FrmMediaTek86Controller()
        {
            personnelAccess = new PersonnelAccess();
            serviceAccess = new ServiceAccess();
        }

        /// <summary>
        /// Retourne la liste de tous les personnels
        /// </summary>
        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }

        /// <summary>
        /// Retourne la liste de tous les services
        /// </summary>
        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        /// <summary>
        /// Ajoute un personnel
        /// </summary>
        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }

        /// <summary>
        /// Modifie un personnel
        /// </summary>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Supprime un personnel
        /// </summary>
        public void DelPersonnel(Personnel personnel)
        {
            personnelAccess.DelPersonnel(personnel);
        }
    }
}