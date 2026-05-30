namespace MediaTek86.view
{
    partial class FrmMediaTek86
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
            this.grbLesPersonnels = new System.Windows.Forms.GroupBox();
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.btnAnnulPersonnel = new System.Windows.Forms.Button();
            this.btnEnregPersonnel = new System.Windows.Forms.Button();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.grbLesPersonnels.SuspendLayout();
            this.grbPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // grbLesPersonnels
            // 
            this.grbLesPersonnels.Controls.Add(this.grbPersonnel);
            this.grbLesPersonnels.Controls.Add(this.btnAbsences);
            this.grbLesPersonnels.Controls.Add(this.btnSupprimer);
            this.grbLesPersonnels.Controls.Add(this.btnModifier);
            this.grbLesPersonnels.Controls.Add(this.dgvPersonnel);
            this.grbLesPersonnels.Location = new System.Drawing.Point(12, 12);
            this.grbLesPersonnels.Name = "grbLesPersonnels";
            this.grbLesPersonnels.Size = new System.Drawing.Size(740, 285);
            this.grbLesPersonnels.TabIndex = 5;
            this.grbLesPersonnels.TabStop = false;
            this.grbLesPersonnels.Text = "les personnels";
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnAnnulPersonnel);
            this.grbPersonnel.Controls.Add(this.btnEnregPersonnel);
            this.grbPersonnel.Controls.Add(this.cboService);
            this.grbPersonnel.Controls.Add(this.txtMail);
            this.grbPersonnel.Controls.Add(this.txtTel);
            this.grbPersonnel.Controls.Add(this.txtPrenom);
            this.grbPersonnel.Controls.Add(this.txtNom);
            this.grbPersonnel.Controls.Add(this.label5);
            this.grbPersonnel.Controls.Add(this.label4);
            this.grbPersonnel.Controls.Add(this.label3);
            this.grbPersonnel.Controls.Add(this.label2);
            this.grbPersonnel.Controls.Add(this.label1);
            this.grbPersonnel.Location = new System.Drawing.Point(440, 28);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(284, 235);
            this.grbPersonnel.TabIndex = 7;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "ajouter un personnel";
            // 
            // btnAnnulPersonnel
            // 
            this.btnAnnulPersonnel.Location = new System.Drawing.Point(150, 206);
            this.btnAnnulPersonnel.Name = "btnAnnulPersonnel";
            this.btnAnnulPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulPersonnel.TabIndex = 11;
            this.btnAnnulPersonnel.Text = "annuler";
            this.btnAnnulPersonnel.UseVisualStyleBackColor = true;
            this.btnAnnulPersonnel.Click += new System.EventHandler(this.btnAnnulPersonnel_Click);
            // 
            // btnEnregPersonnel
            // 
            this.btnEnregPersonnel.Location = new System.Drawing.Point(34, 206);
            this.btnEnregPersonnel.Name = "btnEnregPersonnel";
            this.btnEnregPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnEnregPersonnel.TabIndex = 10;
            this.btnEnregPersonnel.Text = "enregistrer";
            this.btnEnregPersonnel.UseVisualStyleBackColor = true;
            this.btnEnregPersonnel.Click += new System.EventHandler(this.btnEnregPersonnel_Click);
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(53, 147);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(100, 21);
            this.cboService.TabIndex = 9;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(53, 116);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 8;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(53, 87);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(53, 54);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(53, 20);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "service :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "tel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "prenom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " nom :";
            // 
            // btnAbsences
            // 
            this.btnAbsences.Location = new System.Drawing.Point(318, 240);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(75, 23);
            this.btnAbsences.TabIndex = 6;
            this.btnAbsences.Text = "absences";
            this.btnAbsences.UseVisualStyleBackColor = true;
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(172, 240);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(41, 240);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(15, 28);
            this.dgvPersonnel.MultiSelect = false;
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.RowHeadersVisible = false;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnel.Size = new System.Drawing.Size(419, 191);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // FrmMediaTek86
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 303);
            this.Controls.Add(this.grbLesPersonnels);
            this.Name = "FrmMediaTek86";
            this.Text = "FrmMediaTek86";
            this.grbLesPersonnels.ResumeLayout(false);
            this.grbPersonnel.ResumeLayout(false);
            this.grbPersonnel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbLesPersonnels;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.Button btnAnnulPersonnel;
        private System.Windows.Forms.Button btnEnregPersonnel;
        private System.Windows.Forms.ComboBox cboService;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}