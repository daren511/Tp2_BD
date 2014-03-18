namespace St_laurent_Daren_ken_ET_Cote_Francis_Tp2_2
{
    partial class Livres_Ajout
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
            this.BTN_OK = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.LB_NumLivre = new System.Windows.Forms.Label();
            this.LB_Titre = new System.Windows.Forms.Label();
            this.LB_Auteur = new System.Windows.Forms.Label();
            this.TB_NumLivre = new System.Windows.Forms.TextBox();
            this.TB_Titre = new System.Windows.Forms.TextBox();
            this.TB_Auteur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_OK
            // 
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_OK.Location = new System.Drawing.Point(110, 124);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 6;
            this.BTN_OK.Text = "Ok";
            this.BTN_OK.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(218, 124);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 7;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // LB_NumLivre
            // 
            this.LB_NumLivre.AutoSize = true;
            this.LB_NumLivre.Location = new System.Drawing.Point(45, 25);
            this.LB_NumLivre.Name = "LB_NumLivre";
            this.LB_NumLivre.Size = new System.Drawing.Size(36, 13);
            this.LB_NumLivre.TabIndex = 0;
            this.LB_NumLivre.Text = "# livre";
            // 
            // LB_Titre
            // 
            this.LB_Titre.AutoSize = true;
            this.LB_Titre.Location = new System.Drawing.Point(51, 55);
            this.LB_Titre.Name = "LB_Titre";
            this.LB_Titre.Size = new System.Drawing.Size(28, 13);
            this.LB_Titre.TabIndex = 2;
            this.LB_Titre.Text = "Titre";
            // 
            // LB_Auteur
            // 
            this.LB_Auteur.AutoSize = true;
            this.LB_Auteur.Location = new System.Drawing.Point(45, 86);
            this.LB_Auteur.Name = "LB_Auteur";
            this.LB_Auteur.Size = new System.Drawing.Size(38, 13);
            this.LB_Auteur.TabIndex = 4;
            this.LB_Auteur.Text = "Auteur";
            // 
            // TB_NumLivre
            // 
            this.TB_NumLivre.Location = new System.Drawing.Point(85, 22);
            this.TB_NumLivre.Name = "TB_NumLivre";
            this.TB_NumLivre.Size = new System.Drawing.Size(70, 20);
            this.TB_NumLivre.TabIndex = 1;
            this.TB_NumLivre.TextChanged += new System.EventHandler(this.TB_NumLivre_TextChanged);
            // 
            // TB_Titre
            // 
            this.TB_Titre.Location = new System.Drawing.Point(85, 52);
            this.TB_Titre.Name = "TB_Titre";
            this.TB_Titre.Size = new System.Drawing.Size(242, 20);
            this.TB_Titre.TabIndex = 3;
            // 
            // TB_Auteur
            // 
            this.TB_Auteur.Location = new System.Drawing.Point(85, 83);
            this.TB_Auteur.Name = "TB_Auteur";
            this.TB_Auteur.Size = new System.Drawing.Size(242, 20);
            this.TB_Auteur.TabIndex = 5;
            // 
            // Livres_Ajout
            // 
            this.AcceptButton = this.BTN_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(360, 164);
            this.Controls.Add(this.TB_Auteur);
            this.Controls.Add(this.TB_Titre);
            this.Controls.Add(this.TB_NumLivre);
            this.Controls.Add(this.LB_Auteur);
            this.Controls.Add(this.LB_Titre);
            this.Controls.Add(this.LB_NumLivre);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(376, 202);
            this.Name = "Livres_Ajout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Livres_Ajout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Label LB_NumLivre;
        private System.Windows.Forms.Label LB_Titre;
        private System.Windows.Forms.Label LB_Auteur;
        private System.Windows.Forms.TextBox TB_NumLivre;
        private System.Windows.Forms.TextBox TB_Titre;
        private System.Windows.Forms.TextBox TB_Auteur;
    }
}