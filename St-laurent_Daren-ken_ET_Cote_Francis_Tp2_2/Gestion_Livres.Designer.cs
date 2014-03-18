namespace St_laurent_Daren_ken_ET_Cote_Francis_Tp2
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
            this.CMS_Livres = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.BTN_Ajout = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.BTN_Auteur = new System.Windows.Forms.Button();
            this.BTN_PlusEmprunte = new System.Windows.Forms.Button();
            this.TB_Rechercher = new System.Windows.Forms.TextBox();
            this.BTN_Rechercher = new System.Windows.Forms.Button();
            this.DTP_DateFin = new System.Windows.Forms.DateTimePicker();
            this.DTP_DateDebut = new System.Windows.Forms.DateTimePicker();
            this.CB_NumAdherent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_AdherentPeriode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Livres)).BeginInit();
            this.CMS_Livres.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Livres
            // 
            this.DGV_Livres.AllowUserToAddRows = false;
            this.DGV_Livres.AllowUserToDeleteRows = false;
            this.DGV_Livres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Livres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Livres.ContextMenuStrip = this.CMS_Livres;
            this.DGV_Livres.Location = new System.Drawing.Point(12, 12);
            this.DGV_Livres.MultiSelect = false;
            this.DGV_Livres.Name = "DGV_Livres";
            this.DGV_Livres.ReadOnly = true;
            this.DGV_Livres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Livres.Size = new System.Drawing.Size(397, 286);
            this.DGV_Livres.TabIndex = 0;
            this.DGV_Livres.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Livres_CellDoubleClick);
            // 
            // CMS_Livres
            // 
            this.CMS_Livres.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterToolStripMenuItem,
            this.toolStripMenuItem1,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.CMS_Livres.Name = "CMS_Livres";
            this.CMS_Livres.Size = new System.Drawing.Size(130, 76);
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.consulterToolStripMenuItem.Text = "Consulter";
            this.consulterToolStripMenuItem.Click += new System.EventHandler(this.consulterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(126, 6);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // BTN_Close
            // 
            this.BTN_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Close.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Close.Location = new System.Drawing.Point(656, 275);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(75, 23);
            this.BTN_Close.TabIndex = 1;
            this.BTN_Close.Text = "Fermer";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // BTN_Ajout
            // 
            this.BTN_Ajout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Ajout.Location = new System.Drawing.Point(429, 12);
            this.BTN_Ajout.Name = "BTN_Ajout";
            this.BTN_Ajout.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ajout.TabIndex = 2;
            this.BTN_Ajout.Text = "Ajouter";
            this.BTN_Ajout.UseVisualStyleBackColor = true;
            this.BTN_Ajout.Click += new System.EventHandler(this.BTN_Ajout_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Modifier.Location = new System.Drawing.Point(429, 41);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(75, 23);
            this.BTN_Modifier.TabIndex = 3;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Delete.Location = new System.Drawing.Point(429, 80);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(75, 23);
            this.BTN_Delete.TabIndex = 4;
            this.BTN_Delete.Text = "Supprimer";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Refresh.Location = new System.Drawing.Point(430, 189);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(75, 42);
            this.BTN_Refresh.TabIndex = 4;
            this.BTN_Refresh.Text = "Afficher Tout";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // BTN_Auteur
            // 
            this.BTN_Auteur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Auteur.Location = new System.Drawing.Point(430, 123);
            this.BTN_Auteur.Name = "BTN_Auteur";
            this.BTN_Auteur.Size = new System.Drawing.Size(75, 41);
            this.BTN_Auteur.TabIndex = 5;
            this.BTN_Auteur.Text = "Afficher par auteur";
            this.BTN_Auteur.UseVisualStyleBackColor = true;
            this.BTN_Auteur.Click += new System.EventHandler(this.BTN_Auteur_Click);
            // 
            // BTN_PlusEmprunte
            // 
            this.BTN_PlusEmprunte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_PlusEmprunte.Location = new System.Drawing.Point(524, 151);
            this.BTN_PlusEmprunte.Name = "BTN_PlusEmprunte";
            this.BTN_PlusEmprunte.Size = new System.Drawing.Size(75, 42);
            this.BTN_PlusEmprunte.TabIndex = 6;
            this.BTN_PlusEmprunte.Text = "Afficher plus empruntés";
            this.BTN_PlusEmprunte.UseVisualStyleBackColor = true;
            this.BTN_PlusEmprunte.Click += new System.EventHandler(this.BTN_PlusEmprunte_Click);
            // 
            // TB_Rechercher
            // 
            this.TB_Rechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Rechercher.Location = new System.Drawing.Point(415, 249);
            this.TB_Rechercher.Name = "TB_Rechercher";
            this.TB_Rechercher.Size = new System.Drawing.Size(156, 20);
            this.TB_Rechercher.TabIndex = 7;
            // 
            // BTN_Rechercher
            // 
            this.BTN_Rechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Rechercher.Location = new System.Drawing.Point(455, 275);
            this.BTN_Rechercher.Name = "BTN_Rechercher";
            this.BTN_Rechercher.Size = new System.Drawing.Size(87, 23);
            this.BTN_Rechercher.TabIndex = 8;
            this.BTN_Rechercher.Text = "Rechercher";
            this.BTN_Rechercher.UseVisualStyleBackColor = true;
            this.BTN_Rechercher.Click += new System.EventHandler(this.BTN_Rechercher_Click);
            // 
            // DTP_DateFin
            // 
            this.DTP_DateFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP_DateFin.Location = new System.Drawing.Point(610, 44);
            this.DTP_DateFin.Name = "DTP_DateFin";
            this.DTP_DateFin.Size = new System.Drawing.Size(121, 20);
            this.DTP_DateFin.TabIndex = 9;
            // 
            // DTP_DateDebut
            // 
            this.DTP_DateDebut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP_DateDebut.Location = new System.Drawing.Point(610, 79);
            this.DTP_DateDebut.Name = "DTP_DateDebut";
            this.DTP_DateDebut.Size = new System.Drawing.Size(121, 20);
            this.DTP_DateDebut.TabIndex = 9;
            // 
            // CB_NumAdherent
            // 
            this.CB_NumAdherent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_NumAdherent.FormattingEnabled = true;
            this.CB_NumAdherent.Location = new System.Drawing.Point(610, 12);
            this.CB_NumAdherent.Name = "CB_NumAdherent";
            this.CB_NumAdherent.Size = new System.Drawing.Size(121, 21);
            this.CB_NumAdherent.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "# d\'adherent";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date Début";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date Fin";
            // 
            // BTN_AdherentPeriode
            // 
            this.BTN_AdherentPeriode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_AdherentPeriode.Location = new System.Drawing.Point(553, 104);
            this.BTN_AdherentPeriode.Name = "BTN_AdherentPeriode";
            this.BTN_AdherentPeriode.Size = new System.Drawing.Size(156, 23);
            this.BTN_AdherentPeriode.TabIndex = 12;
            this.BTN_AdherentPeriode.Text = "Recherche Par Période";
            this.BTN_AdherentPeriode.UseVisualStyleBackColor = true;
            this.BTN_AdherentPeriode.Click += new System.EventHandler(this.BTN_AdherentPeriode_Click);
            // 
            // Gestion_Livres
            // 
            this.AcceptButton = this.BTN_Close;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 310);
            this.Controls.Add(this.BTN_AdherentPeriode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_NumAdherent);
            this.Controls.Add(this.DTP_DateDebut);
            this.Controls.Add(this.DTP_DateFin);
            this.Controls.Add(this.BTN_Rechercher);
            this.Controls.Add(this.TB_Rechercher);
            this.Controls.Add(this.BTN_PlusEmprunte);
            this.Controls.Add(this.BTN_Auteur);
            this.Controls.Add(this.BTN_Refresh);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Ajout);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.DGV_Livres);
            this.MinimumSize = new System.Drawing.Size(759, 348);
            this.Name = "Gestion_Livres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des livres";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gestion_Livres_FormClosing);
            this.Load += new System.EventHandler(this.Gestion_Livres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Livres)).EndInit();
            this.CMS_Livres.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button BTN_Refresh;
        private System.Windows.Forms.Button BTN_Auteur;
        private System.Windows.Forms.Button BTN_PlusEmprunte;
        private System.Windows.Forms.TextBox TB_Rechercher;
        private System.Windows.Forms.Button BTN_Rechercher;
        private System.Windows.Forms.DateTimePicker DTP_DateFin;
        private System.Windows.Forms.DateTimePicker DTP_DateDebut;
        private System.Windows.Forms.ComboBox CB_NumAdherent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_AdherentPeriode;
    }
}