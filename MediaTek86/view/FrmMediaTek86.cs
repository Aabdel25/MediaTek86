using MediaTek86.controller;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.view
{
    /// <summary>
    /// Formulaire principal — gestion du personnel
    /// </summary>
    public partial class FrmMediaTek86 : Form
    {
        /// <summary>
        /// Permet de lier la liste des personnels au DataGridView
        /// </summary>
        private readonly BindingSource bdgPersonnels = new BindingSource();
        /// <summary>
        /// Permet de lier la liste des services au ComboBox
        /// </summary>
        private readonly BindingSource bdgServices = new BindingSource();
        /// <summary>
        /// Vrai si on est en cours de modification d'un personnel
        /// </summary>
        private bool enCoursDeModif = false;
        /// <summary>
        /// Contrôleur du formulaire
        /// </summary>
        private FrmMediaTek86Controller controller;

        /// <summary>
        /// Constructeur : initialise les composants graphiques
        /// </summary>
        public FrmMediaTek86()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisation : contrôleur et remplissage des listes
        /// </summary>
        private void Init()
        {
     
            controller = new FrmMediaTek86Controller();
            RemplirListePersonnels();
            RemplirListeServices();
            EnCoursDeModif(false);
        }

        /// <summary>
        /// Affiche les personnels dans le DataGridView
        /// </summary>
        private void RemplirListePersonnels()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            dgvPersonnel.DataSource = bdgPersonnels;
            dgvPersonnel.Columns["Idpersonnel"].Visible = false;
            dgvPersonnel.Columns["Service"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Remplit le ComboBox avec les services
        /// </summary>
        private void RemplirListeServices()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgServices.DataSource = lesServices;
            cboService.DataSource = bdgServices;
            cboService.DisplayMember = "Nom";
        }

        /// <summary>
        /// Gère l'activation des GroupBox selon le mode en cours
        /// </summary>
        /// <param name="modif">vrai si on est en cours de modification</param>
        private void EnCoursDeModif(bool modif)
        {
            enCoursDeModif = modif;
            // on désactive seulement les boutons de la liste
            btnModifier.Enabled = !modif;
            btnSupprimer.Enabled = !modif;
            btnAbsences.Enabled = !modif;
            dgvPersonnel.Enabled = !modif;
            grbPersonnel.Enabled = true;
            if (modif)
            {
                grbPersonnel.Text = "modifier un personnel";
        }
            else
            {
                grbPersonnel.Text = "ajouter un personnel";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }

        /// <summary>
        /// Clic sur Modifier : charge les données du personnel sélectionné
        /// </summary>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                EnCoursDeModif(true);
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
    }
}

        /// <summary>
        /// Clic sur Supprimer : supprime le personnel sélectionné
        /// </summary>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                if (MessageBox.Show("Supprimer " + personnel.Prenom + " " + personnel.Nom + " ?",
                    "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Clic sur Absences : ouvre le formulaire des absences
        /// </summary>
        private void btnAbsences_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                FrmAbsence frm = new FrmAbsence(personnel);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Clic sur Enregistrer : ajoute ou modifie un personnel
        /// </summary>
        private void btnEnregPersonnel_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtMail.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                Service service = (Service)bdgServices.List[bdgServices.Position];
                if (enCoursDeModif)
                {
                    Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                    personnel.Nom = txtNom.Text;
                    personnel.Prenom = txtPrenom.Text;
                    personnel.Tel = txtTel.Text;
                    personnel.Mail = txtMail.Text;
                    personnel.Service = service;
                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service);
                    controller.AddPersonnel(personnel);
                }
                RemplirListePersonnels();
                EnCoursDeModif(false);
            }
            else
            {
                MessageBox.Show("Nom, prénom, mail et service sont obligatoires.", "Information");
            }
        }

        /// <summary>
        /// Clic sur Annuler : annule la saisie en cours
        /// </summary>
        private void btnAnnulPersonnel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursDeModif(false);
            }
        }      
    }
}