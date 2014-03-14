namespace St_laurent_Daren_ken_ET_Cote_Francis_Tp2
{
    partial class Form_Adherents
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
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Modif = new System.Windows.Forms.Button();
            this.DGV_Adherent = new System.Windows.Forms.DataGridView();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Adherent)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Fermer.Location = new System.Drawing.Point(90, 190);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(75, 23);
            this.BTN_Fermer.TabIndex = 1;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(280, 12);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ajouter.TabIndex = 5;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Modif
            // 
            this.BTN_Modif.Location = new System.Drawing.Point(280, 73);
            this.BTN_Modif.Name = "BTN_Modif";
            this.BTN_Modif.Size = new System.Drawing.Size(75, 23);
            this.BTN_Modif.TabIndex = 6;
            this.BTN_Modif.Text = "Modifier";
            this.BTN_Modif.UseVisualStyleBackColor = true;
            this.BTN_Modif.Click += new System.EventHandler(this.BTN_Modif_Click);
            // 
            // DGV_Adherent
            // 
            this.DGV_Adherent.AllowUserToAddRows = false;
            this.DGV_Adherent.AllowUserToDeleteRows = false;
            this.DGV_Adherent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Adherent.Location = new System.Drawing.Point(12, 9);
            this.DGV_Adherent.MultiSelect = false;
            this.DGV_Adherent.Name = "DGV_Adherent";
            this.DGV_Adherent.ReadOnly = true;
            this.DGV_Adherent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Adherent.Size = new System.Drawing.Size(240, 150);
            this.DGV_Adherent.TabIndex = 7;
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Location = new System.Drawing.Point(280, 136);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.BTN_Supprimer.TabIndex = 6;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // Form_Adherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Fermer;
            this.ClientSize = new System.Drawing.Size(381, 225);
            this.Controls.Add(this.DGV_Adherent);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Modif);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.BTN_Fermer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Adherents";
            this.Text = "Form_Adherents";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Adherents_FormClosed);
            this.Load += new System.EventHandler(this.Form_Adherents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Adherent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Fermer;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Modif;
        private System.Windows.Forms.DataGridView DGV_Adherent;
        private System.Windows.Forms.Button BTN_Supprimer;
    }
}