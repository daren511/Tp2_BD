namespace St_laurent_Daren_ken_ET_Cote_Francis_Tp2_2
{
    partial class Principal
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
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.BTN_Deconnexion = new System.Windows.Forms.Button();
            this.BTN_Adherents = new System.Windows.Forms.Button();
            this.BTN_Emprunts = new System.Windows.Forms.Button();
            this.BTN_Retours = new System.Windows.Forms.Button();
            this.BTN_Livres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.Location = new System.Drawing.Point(851, 214);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(90, 23);
            this.BTN_Quitter.TabIndex = 0;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            this.BTN_Quitter.Click += new System.EventHandler(this.BTN_Quitter_Click);
            // 
            // BTN_Deconnexion
            // 
            this.BTN_Deconnexion.Location = new System.Drawing.Point(763, 214);
            this.BTN_Deconnexion.Name = "BTN_Deconnexion";
            this.BTN_Deconnexion.Size = new System.Drawing.Size(82, 23);
            this.BTN_Deconnexion.TabIndex = 0;
            this.BTN_Deconnexion.Text = "Déconnexion";
            this.BTN_Deconnexion.UseVisualStyleBackColor = true;
            this.BTN_Deconnexion.Click += new System.EventHandler(this.BTN_Deconnexion_Click);
            // 
            // BTN_Adherents
            // 
            this.BTN_Adherents.Location = new System.Drawing.Point(12, 12);
            this.BTN_Adherents.Name = "BTN_Adherents";
            this.BTN_Adherents.Size = new System.Drawing.Size(228, 191);
            this.BTN_Adherents.TabIndex = 1;
            this.BTN_Adherents.Text = "Adhérents";
            this.BTN_Adherents.UseVisualStyleBackColor = true;
            this.BTN_Adherents.Click += new System.EventHandler(this.BTN_Adherents_Click);
            // 
            // BTN_Emprunts
            // 
            this.BTN_Emprunts.Location = new System.Drawing.Point(246, 12);
            this.BTN_Emprunts.Name = "BTN_Emprunts";
            this.BTN_Emprunts.Size = new System.Drawing.Size(228, 191);
            this.BTN_Emprunts.TabIndex = 1;
            this.BTN_Emprunts.Text = "Emprunts";
            this.BTN_Emprunts.UseVisualStyleBackColor = true;
            this.BTN_Emprunts.Click += new System.EventHandler(this.BTN_Emprunts_Click);
            // 
            // BTN_Retours
            // 
            this.BTN_Retours.Location = new System.Drawing.Point(480, 12);
            this.BTN_Retours.Name = "BTN_Retours";
            this.BTN_Retours.Size = new System.Drawing.Size(228, 191);
            this.BTN_Retours.TabIndex = 1;
            this.BTN_Retours.Text = "Retours";
            this.BTN_Retours.UseVisualStyleBackColor = true;
            this.BTN_Retours.Click += new System.EventHandler(this.BTN_Retours_Click);
            // 
            // BTN_Livres
            // 
            this.BTN_Livres.Location = new System.Drawing.Point(714, 12);
            this.BTN_Livres.Name = "BTN_Livres";
            this.BTN_Livres.Size = new System.Drawing.Size(228, 191);
            this.BTN_Livres.TabIndex = 1;
            this.BTN_Livres.Text = "Livres";
            this.BTN_Livres.UseVisualStyleBackColor = true;
            this.BTN_Livres.Click += new System.EventHandler(this.BTN_Livres_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 249);
            this.Controls.Add(this.BTN_Livres);
            this.Controls.Add(this.BTN_Retours);
            this.Controls.Add(this.BTN_Emprunts);
            this.Controls.Add(this.BTN_Adherents);
            this.Controls.Add(this.BTN_Deconnexion);
            this.Controls.Add(this.BTN_Quitter);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Quitter;
        private System.Windows.Forms.Button BTN_Deconnexion;
        private System.Windows.Forms.Button BTN_Adherents;
        private System.Windows.Forms.Button BTN_Emprunts;
        private System.Windows.Forms.Button BTN_Retours;
        private System.Windows.Forms.Button BTN_Livres;
    }
}