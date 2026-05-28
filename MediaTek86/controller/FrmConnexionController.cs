using MediaTek86.dal;

namespace MediaTek86.controller
{
    /// <summary>
    /// Contrôleur du formulaire de connexion
    /// </summary>
    public class FrmConnexionController
    {
        /// <summary>
        /// Objet d'accès aux données du responsable
        /// </summary>
        private readonly ResponsableAccess responsableAccess;

        /// <summary>
        /// Constructeur : instancie la classe DAL
        /// </summary>
        public FrmConnexionController()
        {
            responsableAccess = new ResponsableAccess();
        }

        /// <summary>
        /// Vérifie si les identifiants sont corrects
        /// </summary>
        /// <param name="login">login saisi</param>
        /// <param name="pwd">mot de passe en clair</param>
        /// <returns>true si authentification réussie</returns>
        public bool ControleAuthentification(string login, string pwd)
        {
            return responsableAccess.ControleAuthentification(login, pwd);
        }
    }
}