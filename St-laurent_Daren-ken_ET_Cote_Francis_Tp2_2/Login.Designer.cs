namespace St_laurent_Daren_ken_ET_Cote_Francis_Tp2
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Connect = new System.Windows.Forms.Button();
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.LB_Username = new System.Windows.Forms.Label();
            this.LB_MDP = new System.Windows.Forms.Label();
            this.LB_Error = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Connect
            // 
            this.BTN_Connect.Location = new System.Drawing.Point(352, 127);
            this.BTN_Connect.Name = "BTN_Connect";
            this.BTN_Connect.Size = new System.Drawing.Size(75, 23);
            this.BTN_Connect.TabIndex = 6;
            this.BTN_Connect.Text = "Connexion";
            this.BTN_Connect.UseVisualStyleBackColor = true;
            this.BTN_Connect.Click += new System.EventHandler(this.BTN_Connect_Click);
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.Location = new System.Drawing.Point(271, 127);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Quitter.TabIndex = 5;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            this.BTN_Quitter.Click += new System.EventHandler(this.BTN_Quitter_Click);
            // 
            // LB_Username
            // 
            this.LB_Username.AutoSize = true;
            this.LB_Username.Location = new System.Drawing.Point(268, 25);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(41, 13);
            this.LB_Username.TabIndex = 0;
            this.LB_Username.Text = "Usager";
            // 
            // LB_MDP
            // 
            this.LB_MDP.AutoSize = true;
            this.LB_MDP.Location = new System.Drawing.Point(268, 64);
            this.LB_MDP.Name = "LB_MDP";
            this.LB_MDP.Size = new System.Drawing.Size(71, 13);
            this.LB_MDP.TabIndex = 2;
            this.LB_MDP.Text = "Mot de passe";
            // 
            // LB_Error
            // 
            this.LB_Error.AutoSize = true;
            this.LB_Error.Location = new System.Drawing.Point(268, 103);
            this.LB_Error.Name = "LB_Error";
            this.LB_Error.Size = new System.Drawing.Size(0, 13);
            this.LB_Error.TabIndex = 4;
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(271, 80);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(100, 20);
            this.TB_Password.TabIndex = 3;
            this.TB_Password.UseSystemPasswordChar = true;
            this.TB_Password.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Password_KeyDown);
            // 
            // TB_Username
            // 
            this.TB_Username.Location = new System.Drawing.Point(271, 41);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(100, 20);
            this.TB_Username.TabIndex = 1;
            this.TB_Username.TextChanged += new System.EventHandler(this.TB_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 138);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 161);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.LB_Error);
            this.Controls.Add(this.LB_MDP);
            this.Controls.Add(this.LB_Username);
            this.Controls.Add(this.BTN_Quitter);
            this.Controls.Add(this.BTN_Connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(455, 199);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Connect;
        private System.Windows.Forms.Button BTN_Quitter;
        private System.Windows.Forms.Label LB_Username;
        private System.Windows.Forms.Label LB_MDP;
        private System.Windows.Forms.Label LB_Error;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

