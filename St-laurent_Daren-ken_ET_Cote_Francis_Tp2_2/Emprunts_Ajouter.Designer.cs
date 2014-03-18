namespace St_laurent_Daren_ken_ET_Cote_Francis_Tp2_2
{
    partial class Emprunts_Ajouter
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
            this.CB_NumExemplaire = new System.Windows.Forms.ComboBox();
            this.CB_NumAdherent = new System.Windows.Forms.ComboBox();
            this.DTP_DateEmprunt = new System.Windows.Forms.DateTimePicker();
            this.DTP_DateRetourPrevu = new System.Windows.Forms.DateTimePicker();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB_NumExemplaire
            // 
            this.CB_NumExemplaire.FormattingEnabled = true;
            this.CB_NumExemplaire.Location = new System.Drawing.Point(129, 23);
            this.CB_NumExemplaire.Name = "CB_NumExemplaire";
            this.CB_NumExemplaire.Size = new System.Drawing.Size(115, 21);
            this.CB_NumExemplaire.TabIndex = 0;
            // 
            // CB_NumAdherent
            // 
            this.CB_NumAdherent.FormattingEnabled = true;
            this.CB_NumAdherent.Location = new System.Drawing.Point(129, 70);
            this.CB_NumAdherent.Name = "CB_NumAdherent";
            this.CB_NumAdherent.Size = new System.Drawing.Size(115, 21);
            this.CB_NumAdherent.TabIndex = 1;
            // 
            // DTP_DateEmprunt
            // 
            this.DTP_DateEmprunt.Enabled = false;
            this.DTP_DateEmprunt.Location = new System.Drawing.Point(129, 119);
            this.DTP_DateEmprunt.Name = "DTP_DateEmprunt";
            this.DTP_DateEmprunt.Size = new System.Drawing.Size(115, 20);
            this.DTP_DateEmprunt.TabIndex = 2;
            // 
            // DTP_DateRetourPrevu
            // 
            this.DTP_DateRetourPrevu.Location = new System.Drawing.Point(129, 164);
            this.DTP_DateRetourPrevu.Name = "DTP_DateRetourPrevu";
            this.DTP_DateRetourPrevu.Size = new System.Drawing.Size(115, 20);
            this.DTP_DateRetourPrevu.TabIndex = 3;
            this.DTP_DateRetourPrevu.Value = new System.DateTime(2014, 3, 25, 23, 59, 59, 0);
            // 
            // BTN_OK
            // 
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_OK.Location = new System.Drawing.Point(15, 206);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 4;
            this.BTN_OK.Text = "Ok";
            this.BTN_OK.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(142, 206);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 5;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "# d\'exemplaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "# d\'adherent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date d\'emprunt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date de retour";
            // 
            // Emprunts_Ajouter
            // 
            this.AcceptButton = this.BTN_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(283, 249);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.DTP_DateRetourPrevu);
            this.Controls.Add(this.DTP_DateEmprunt);
            this.Controls.Add(this.CB_NumAdherent);
            this.Controls.Add(this.CB_NumExemplaire);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Emprunts_Ajouter";
            this.Text = "Emprunts_Ajouter";
            this.Load += new System.EventHandler(this.Emprunts_Ajouter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_NumExemplaire;
        private System.Windows.Forms.ComboBox CB_NumAdherent;
        private System.Windows.Forms.DateTimePicker DTP_DateEmprunt;
        private System.Windows.Forms.DateTimePicker DTP_DateRetourPrevu;
        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}