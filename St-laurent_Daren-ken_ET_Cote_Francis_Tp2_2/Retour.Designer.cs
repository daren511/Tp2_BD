namespace St_laurent_Daren_ken_ET_Cote_Francis_Tp2_2
{
    partial class Retour
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
            this.DGV_Retour = new System.Windows.Forms.DataGridView();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Retour)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Retour
            // 
            this.DGV_Retour.AllowUserToAddRows = false;
            this.DGV_Retour.AllowUserToDeleteRows = false;
            this.DGV_Retour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Retour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Retour.Location = new System.Drawing.Point(12, 12);
            this.DGV_Retour.MultiSelect = false;
            this.DGV_Retour.Name = "DGV_Retour";
            this.DGV_Retour.ReadOnly = true;
            this.DGV_Retour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Retour.Size = new System.Drawing.Size(331, 150);
            this.DGV_Retour.TabIndex = 0;
            this.DGV_Retour.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Retour_CellMouseClick);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Modifier.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Modifier.Location = new System.Drawing.Point(370, 50);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(75, 39);
            this.BTN_Modifier.TabIndex = 2;
            this.BTN_Modifier.Text = "Valider des retours";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Close
            // 
            this.BTN_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Close.Location = new System.Drawing.Point(12, 183);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(75, 23);
            this.BTN_Close.TabIndex = 5;
            this.BTN_Close.Text = "Fermer";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // Retour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Close;
            this.ClientSize = new System.Drawing.Size(468, 218);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.DGV_Retour);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(484, 256);
            this.Name = "Retour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Retour";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Retour_FormClosing);
            this.Load += new System.EventHandler(this.Retour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Retour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Retour;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Close;
    }
}