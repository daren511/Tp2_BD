namespace St_laurent_Daren_ken_ET_Cote_Francis_Tp2_2
{
    partial class Emprunts
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
            this.BTN_Close = new System.Windows.Forms.Button();
            this.DGV_Emprunts = new System.Windows.Forms.DataGridView();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Emprunts)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Close
            // 
            this.BTN_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Close.Location = new System.Drawing.Point(633, 280);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(75, 23);
            this.BTN_Close.TabIndex = 1;
            this.BTN_Close.Text = "Fermer";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // DGV_Emprunts
            // 
            this.DGV_Emprunts.AllowUserToAddRows = false;
            this.DGV_Emprunts.AllowUserToDeleteRows = false;
            this.DGV_Emprunts.AllowUserToResizeColumns = false;
            this.DGV_Emprunts.AllowUserToResizeRows = false;
            this.DGV_Emprunts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Emprunts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Emprunts.Location = new System.Drawing.Point(12, 12);
            this.DGV_Emprunts.Name = "DGV_Emprunts";
            this.DGV_Emprunts.ReadOnly = true;
            this.DGV_Emprunts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Emprunts.Size = new System.Drawing.Size(558, 205);
            this.DGV_Emprunts.TabIndex = 2;
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Ajouter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Ajouter.Location = new System.Drawing.Point(596, 28);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ajouter.TabIndex = 3;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Modifier.Location = new System.Drawing.Point(596, 94);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(75, 23);
            this.BTN_Modifier.TabIndex = 4;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // Emprunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Close;
            this.ClientSize = new System.Drawing.Size(720, 315);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.DGV_Emprunts);
            this.Controls.Add(this.BTN_Close);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(736, 353);
            this.Name = "Emprunts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Emprunts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Emprunts_FormClosing);
            this.Load += new System.EventHandler(this.Emprunts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Emprunts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.DataGridView DGV_Emprunts;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Modifier;
    }
}