namespace St_laurent_Daren_ken_ET_Cote_Francis_Tp2_2
{
    partial class Ajouter_Exemplaire
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
            this.LB_Dispo = new System.Windows.Forms.Label();
            this.LB_NumExemplaire = new System.Windows.Forms.Label();
            this.LB_NumLivre = new System.Windows.Forms.Label();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.CB_NumExemplaire = new System.Windows.Forms.ComboBox();
            this.CB_NumLivre = new System.Windows.Forms.ComboBox();
            this.CB_Dispo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LB_Dispo
            // 
            this.LB_Dispo.AutoSize = true;
            this.LB_Dispo.Location = new System.Drawing.Point(24, 80);
            this.LB_Dispo.Name = "LB_Dispo";
            this.LB_Dispo.Size = new System.Drawing.Size(56, 13);
            this.LB_Dispo.TabIndex = 4;
            this.LB_Dispo.Text = "Disponible";
            // 
            // LB_NumExemplaire
            // 
            this.LB_NumExemplaire.AutoSize = true;
            this.LB_NumExemplaire.Location = new System.Drawing.Point(24, 29);
            this.LB_NumExemplaire.Name = "LB_NumExemplaire";
            this.LB_NumExemplaire.Size = new System.Drawing.Size(68, 13);
            this.LB_NumExemplaire.TabIndex = 0;
            this.LB_NumExemplaire.Text = "# Exemplaire";
            // 
            // LB_NumLivre
            // 
            this.LB_NumLivre.AutoSize = true;
            this.LB_NumLivre.Location = new System.Drawing.Point(24, 54);
            this.LB_NumLivre.Name = "LB_NumLivre";
            this.LB_NumLivre.Size = new System.Drawing.Size(40, 13);
            this.LB_NumLivre.TabIndex = 2;
            this.LB_NumLivre.Text = "# Livre";
            // 
            // BTN_OK
            // 
            this.BTN_OK.Location = new System.Drawing.Point(27, 108);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 6;
            this.BTN_OK.Text = "Ok";
            this.BTN_OK.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(108, 108);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 7;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // CB_NumExemplaire
            // 
            this.CB_NumExemplaire.Enabled = false;
            this.CB_NumExemplaire.FormattingEnabled = true;
            this.CB_NumExemplaire.Location = new System.Drawing.Point(99, 29);
            this.CB_NumExemplaire.Name = "CB_NumExemplaire";
            this.CB_NumExemplaire.Size = new System.Drawing.Size(100, 21);
            this.CB_NumExemplaire.TabIndex = 1;
            // 
            // CB_NumLivre
            // 
            this.CB_NumLivre.Enabled = false;
            this.CB_NumLivre.FormattingEnabled = true;
            this.CB_NumLivre.Location = new System.Drawing.Point(99, 51);
            this.CB_NumLivre.Name = "CB_NumLivre";
            this.CB_NumLivre.Size = new System.Drawing.Size(100, 21);
            this.CB_NumLivre.TabIndex = 3;
            // 
            // CB_Dispo
            // 
            this.CB_Dispo.Enabled = false;
            this.CB_Dispo.FormattingEnabled = true;
            this.CB_Dispo.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.CB_Dispo.Location = new System.Drawing.Point(99, 72);
            this.CB_Dispo.Name = "CB_Dispo";
            this.CB_Dispo.Size = new System.Drawing.Size(100, 21);
            this.CB_Dispo.TabIndex = 5;
            // 
            // Ajouter_Exemplaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 147);
            this.Controls.Add(this.CB_Dispo);
            this.Controls.Add(this.CB_NumLivre);
            this.Controls.Add(this.CB_NumExemplaire);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.LB_NumLivre);
            this.Controls.Add(this.LB_NumExemplaire);
            this.Controls.Add(this.LB_Dispo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(227, 185);
            this.Name = "Ajouter_Exemplaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Dispo;
        private System.Windows.Forms.Label LB_NumExemplaire;
        private System.Windows.Forms.Label LB_NumLivre;
        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.ComboBox CB_NumExemplaire;
        private System.Windows.Forms.ComboBox CB_NumLivre;
        private System.Windows.Forms.ComboBox CB_Dispo;
    }
}