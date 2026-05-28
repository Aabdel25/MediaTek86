namespace MediaTek86.view
{
    partial class FrmAbsence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbLesAbsences = new System.Windows.Forms.GroupBox();
            this.grbAbsence = new System.Windows.Forms.GroupBox();
            this.btnAnnulAbsence = new System.Windows.Forms.Button();
            this.btnEnregAbsence = new System.Windows.Forms.Button();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.lblPersonnel = new System.Windows.Forms.Label();
            this.grbLesAbsences.SuspendLayout();
            this.grbAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // grbLesAbsences
            // 
            this.grbLesAbsences.Controls.Add(this.grbAbsence);
            this.grbLesAbsences.Controls.Add(this.btnSupprimer);
            this.grbLesAbsences.Controls.Add(this.btnModifier);
            this.grbLesAbsences.Controls.Add(this.dgvAbsences);
            this.grbLesAbsences.Location = new System.Drawing.Point(12, 39);
            this.grbLesAbsences.Name = "grbLesAbsences";
            this.grbLesAbsences.Size = new System.Drawing.Size(663, 269);
            this.grbLesAbsences.TabIndex = 0;
            this.grbLesAbsences.TabStop = false;
            this.grbLesAbsences.Text = "les absences";
            // 
            // grbAbsence
            // 
            this.grbAbsence.Controls.Add(this.btnAnnulAbsence);
            this.grbAbsence.Controls.Add(this.btnEnregAbsence);
            this.grbAbsence.Controls.Add(this.cboMotif);
            this.grbAbsence.Controls.Add(this.dtpDateFin);
            this.grbAbsence.Controls.Add(this.dtpDateDebut);
            this.grbAbsence.Controls.Add(this.label3);
            this.grbAbsence.Controls.Add(this.label2);
            this.grbAbsence.Controls.Add(this.label1);
            this.grbAbsence.Location = new System.Drawing.Point(380, 19);
            this.grbAbsence.Name = "grbAbsence";
            this.grbAbsence.Size = new System.Drawing.Size(271, 243);
            this.grbAbsence.TabIndex = 3;
            this.grbAbsence.TabStop = false;
            this.grbAbsence.Text = "ajouter une absence";
            // 
            // btnAnnulAbsence
            // 
            this.btnAnnulAbsence.Location = new System.Drawing.Point(172, 207);
            this.btnAnnulAbsence.Name = "btnAnnulAbsence";
            this.btnAnnulAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulAbsence.TabIndex = 7;
            this.btnAnnulAbsence.Text = "annuler";
            this.btnAnnulAbsence.UseVisualStyleBackColor = true;
            this.btnAnnulAbsence.Click += new System.EventHandler(this.btnAnnulAbsence_Click);
            // 
            // btnEnregAbsence
            // 
            this.btnEnregAbsence.Location = new System.Drawing.Point(38, 207);
            this.btnEnregAbsence.Name = "btnEnregAbsence";
            this.btnEnregAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnEnregAbsence.TabIndex = 6;
            this.btnEnregAbsence.Text = "enregistrer";
            this.btnEnregAbsence.UseVisualStyleBackColor = true;
            this.btnEnregAbsence.Click += new System.EventHandler(this.btnEnregAbsence_Click);
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(77, 97);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(121, 21);
            this.cboMotif.TabIndex = 5;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(77, 63);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(161, 20);
            this.dtpDateFin.TabIndex = 4;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(77, 31);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(161, 20);
            this.dtpDateDebut.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "motif :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "date fin :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "date début :";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(196, 226);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(64, 226);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(6, 19);
            this.dgvAbsences.MultiSelect = false;
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.ReadOnly = true;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.Size = new System.Drawing.Size(358, 201);
            this.dgvAbsences.TabIndex = 0;
            // 
            // lblPersonnel
            // 
            this.lblPersonnel.AutoSize = true;
            this.lblPersonnel.Location = new System.Drawing.Point(15, 9);
            this.lblPersonnel.Name = "lblPersonnel";
            this.lblPersonnel.Size = new System.Drawing.Size(60, 13);
            this.lblPersonnel.TabIndex = 1;
            this.lblPersonnel.Text = "Personnel :";
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 310);
            this.Controls.Add(this.lblPersonnel);
            this.Controls.Add(this.grbLesAbsences);
            this.Name = "FrmAbsence";
            this.Text = "Gestion des absences";
            this.grbLesAbsences.ResumeLayout(false);
            this.grbAbsence.ResumeLayout(false);
            this.grbAbsence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLesAbsences;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.GroupBox grbAbsence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Button btnAnnulAbsence;
        private System.Windows.Forms.Button btnEnregAbsence;
        private System.Windows.Forms.Label lblPersonnel;
    }
}