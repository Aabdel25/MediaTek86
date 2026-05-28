using MediaTek86.controller;
using System;
using System.Windows.Forms;

namespace MediaTek86.view
{
    /// <summary>
    /// Formulaire de connexion au système MediaTek86
    /// </summary>
    public partial class FrmConnexion : Form
    {
        /// <summary>
        /// Contrôleur du formulaire
        /// </summary>
        private FrmConnexionController controller;

        /// <summary>
        /// Constructeur : initialise les composants graphiques
        /// </summary>
        public FrmConnexion()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisation : création du contrôleur
        /// </summary>
        private void Init()
        {
            controller = new FrmConnexionController();
        }

        /// <summary>
        /// Clic sur le bouton Connexion
        /// </summary>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string pwd = txtPwd.Text;

            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                if (controller.ControleAuthentification(login, pwd))
                {
                    FrmMediaTek86 frm = new FrmMediaTek86();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login ou mot de passe incorrect.", "Alerte");
                }
            }
        }

        private void btnConnexion_Click_1(object sender, EventArgs e)
        {
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
        }
    }
}