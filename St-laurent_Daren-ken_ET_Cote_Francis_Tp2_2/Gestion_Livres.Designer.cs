﻿namespace St_laurent_Daren_ken_ET_Cote_Francis_Tp2
{
    partial class Gestion_Livres
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
            this.components = new System.ComponentModel.Container();
            this.DGV_Livres = new System.Windows.Forms.DataGridView();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.BTN_Ajout = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.CMS_Livres = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Livres)).BeginInit();
            this.CMS_Livres.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Livres
            // 
            this.DGV_Livres.AllowUserToAddRows = false;
            this.DGV_Livres.AllowUserToDeleteRows = false;
            this.DGV_Livres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGV_Livres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Livres.ContextMenuStrip = this.CMS_Livres;
            this.DGV_Livres.Location = new System.Drawing.Point(12, 12);
            this.DGV_Livres.MultiSelect = false;
            this.DGV_Livres.Name = "DGV_Livres";
            this.DGV_Livres.ReadOnly = true;
            this.DGV_Livres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Livres.Size = new System.Drawing.Size(397, 216);
            this.DGV_Livres.TabIndex = 0;
            // 
            // BTN_Close
            // 
            this.BTN_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Close.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Close.Location = new System.Drawing.Point(427, 205);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(75, 23);
            this.BTN_Close.TabIndex = 1;
            this.BTN_Close.Text = "Fermer";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // BTN_Ajout
            // 
            this.BTN_Ajout.Location = new System.Drawing.Point(427, 12);
            this.BTN_Ajout.Name = "BTN_Ajout";
            this.BTN_Ajout.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ajout.TabIndex = 2;
            this.BTN_Ajout.Text = "Ajouter";
            this.BTN_Ajout.UseVisualStyleBackColor = true;
            this.BTN_Ajout.Click += new System.EventHandler(this.BTN_Ajout_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(427, 41);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(75, 23);
            this.BTN_Modifier.TabIndex = 3;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(427, 70);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(75, 23);
            this.BTN_Delete.TabIndex = 4;
            this.BTN_Delete.Text = "Supprimer";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // CMS_Livres
            // 
            this.CMS_Livres.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterToolStripMenuItem,
            this.toolStripMenuItem1,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.CMS_Livres.Name = "CMS_Livres";
            this.CMS_Livres.Size = new System.Drawing.Size(153, 98);
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consulterToolStripMenuItem.Text = "Consulter";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // Gestion_Livres
            // 
            this.AcceptButton = this.BTN_Close;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 240);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Ajout);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.DGV_Livres);
            this.Name = "Gestion_Livres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des livres";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gestion_Livres_FormClosing);
            this.Load += new System.EventHandler(this.Gestion_Livres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Livres)).EndInit();
            this.CMS_Livres.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Livres;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.Button BTN_Ajout;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.ContextMenuStrip CMS_Livres;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}