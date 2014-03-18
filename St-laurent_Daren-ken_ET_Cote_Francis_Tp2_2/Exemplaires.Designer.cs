namespace St_laurent_Daren_ken_ET_Cote_Francis_Tp2_2
{
    partial class Exemplaires
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
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.DGV_Exemplaires = new System.Windows.Forms.DataGridView();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Exemplaires)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Ajouter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Ajouter.Location = new System.Drawing.Point(469, 30);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ajouter.TabIndex = 0;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Delete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Delete.Location = new System.Drawing.Point(469, 59);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(75, 23);
            this.BTN_Delete.TabIndex = 2;
            this.BTN_Delete.Text = "Supprimer";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // DGV_Exemplaires
            // 
            this.DGV_Exemplaires.AllowUserToAddRows = false;
            this.DGV_Exemplaires.AllowUserToDeleteRows = false;
            this.DGV_Exemplaires.AllowUserToOrderColumns = true;
            this.DGV_Exemplaires.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Exemplaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Exemplaires.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGV_Exemplaires.Location = new System.Drawing.Point(12, 12);
            this.DGV_Exemplaires.MinimumSize = new System.Drawing.Size(451, 197);
            this.DGV_Exemplaires.MultiSelect = false;
            this.DGV_Exemplaires.Name = "DGV_Exemplaires";
            this.DGV_Exemplaires.ReadOnly = true;
            this.DGV_Exemplaires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Exemplaires.Size = new System.Drawing.Size(451, 207);
            this.DGV_Exemplaires.TabIndex = 3;
            // 
            // BTN_OK
            // 
            this.BTN_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_OK.Location = new System.Drawing.Point(388, 225);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 4;
            this.BTN_OK.Text = "Ok";
            this.BTN_OK.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(469, 225);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 5;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // Exemplaires
            // 
            this.AcceptButton = this.BTN_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(556, 260);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.DGV_Exemplaires);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Ajouter);
            this.MinimumSize = new System.Drawing.Size(572, 298);
            this.Name = "Exemplaires";
            this.Text = "Exemplaires";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exemplaires_FormClosing);
            this.Load += new System.EventHandler(this.Exemplaires_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Exemplaires)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.DataGridView DGV_Exemplaires;
        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.Button BTN_Cancel;
    }
}