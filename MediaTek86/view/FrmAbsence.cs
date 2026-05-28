using MediaTek86.controller;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.view
{
    /// <summary>
    /// Formulaire de gestion des absences d'un personnel
    /// </summary>
    public partial class FrmAbsence : Form
    {
        /// <summary>
        /// Permet de lier la liste des absences au DataGridView
        /// </summary>
        private readonly BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Permet de lier la liste des motifs au ComboBox
        /// </summary>
        private readonly BindingSource bdgMotifs = new BindingSource();
        /// <summary>
        /// Vrai si on est en cours de modification d'une absence
        /// </summary>
        private bool enCoursDeModif = false;
        /// <summary>
        /// Contrôleur du formulaire
        /// </summary>
        private FrmAbsenceController controller;
        /// <summary>
        /// Personnel dont on gère les absences
        /// </summary>
        private Personnel personnel;

        /// <summary>
        /// Constructeur : reçoit le personnel sélectionné
        /// </summary>
        /// <param name="personnel">personnel concerné</param>
        public FrmAbsence(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            Init();
        }

        /// <summary>
        /// Initialisation : contrôleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmAbsenceController();
            lblPersonnel.Text = personnel.Prenom + " " + personnel.Nom;
            RemplirListeAbsences();
            RemplirListeMotifs();
            EnCoursDeModif(false);
        }

        /// <summary>
        /// Affiche les absences dans le DataGridView
        /// </summary>
        private void RemplirListeAbsences()
        {
            List<Absence> lesAbsences = controller.GetLesAbsences(personnel.Idpersonnel);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Remplit le ComboBox avec les motifs
        /// </summary>
        private void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cboMotif.DataSource = bdgMotifs;
            cboMotif.DisplayMember = "Libelle";
        }

        /// <summary>
        /// Gère l'activation des contrôles selon le mode en cours
        /// </summary>
        /// <param name="modif">vrai si on est en cours de modification</param>
        private void EnCoursDeModif(bool modif)
        {
            enCoursDeModif = modif;
            btnModifier.Enabled = !modif;
            btnSupprimer.Enabled = !modif;
            dgvAbsences.Enabled = !modif;
            grbAbsence.Enabled = true;
            if (modif)
            {
                grbAbsence.Text = "modifier une absence";
            }
            else
            {
                grbAbsence.Text = "ajouter une absence";
                dtpDateDebut.Value = DateTime.Today;
                dtpDateFin.Value = DateTime.Today;
            }
        }

        /// <summary>
        /// Clic sur Modifier : charge les données de l'absence sélectionnée
        /// </summary>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                EnCoursDeModif(true);
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                dtpDateDebut.Value = absence.Datedebut;
                dtpDateFin.Value = absence.Datefin;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.Motif.Libelle);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Clic sur Supprimer : supprime l'absence sélectionnée
        /// </summary>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Supprimer cette absence ?", "Confirmation",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences();
                    EnCoursDeModif(false);
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Clic sur Enregistrer : ajoute ou modifie une absence
        /// </summary>
        private void btnEnregAbsence_Click(object sender, EventArgs e)
        {
            if (dtpDateFin.Value.Date < dtpDateDebut.Value.Date)
            {
                MessageBox.Show("La date de fin doit être après la date de début.", "Information");
                return;
            }
            if (cboMotif.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un motif.", "Information");
                return;
            }
            Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
            if (enCoursDeModif)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                absence.Datefin = dtpDateFin.Value;
                absence.Motif = motif;
                controller.UpdateAbsence(absence);
            }
            else
            {
                Absence absence = new Absence(
                    personnel.Idpersonnel,
                    dtpDateDebut.Value,
                    dtpDateFin.Value,
                    motif
                );
                controller.AddAbsence(absence);
            }
            RemplirListeAbsences();
            EnCoursDeModif(false);
        }

        /// <summary>
        /// Clic sur Annuler : annule la saisie en cours
        /// </summary>
        private void btnAnnulAbsence_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursDeModif(false);
            }
        }
    }
}