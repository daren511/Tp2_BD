using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace St_laurent_Daren_ken_ET_Cote_Francis_Tp2_2
{
    public partial class Emprunts : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        private DataSet AdherentDGV = null;
        public string livre = null;
        public int numAdherent = 0;
        public int numExemplaire = 0;
        public Emprunts()
        {
            InitializeComponent();
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            Emprunts_Ajouter Ajouter = new Emprunts_Ajouter();
            Ajouter.conn = this.conn;
            Ajouter.Text = "Ajout";
            if (Ajouter.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                try
                {
                    OracleCommand oraAjout = new OracleCommand("GestionEmprunts", conn);
                    oraAjout.CommandText = "GestionEmprunts.Insertion";
                    oraAjout.CommandType = CommandType.StoredProcedure;

                    OracleParameter OraNumExemplaire = new OracleParameter("PNumExemplaire", OracleDbType.Int32);
                    OracleParameter OraNumAdherent = new OracleParameter("PNumAdherent", OracleDbType.Int32);
                    OracleParameter OraDateEmprunt = new OracleParameter("PDateEmprunt", OracleDbType.Date);
                    OracleParameter OraDateRetourPrevu = new OracleParameter("PDateRetourPrevu", OracleDbType.Date);

                    OraNumExemplaire.Direction = ParameterDirection.Input;
                    OraNumAdherent.Direction = ParameterDirection.Input;
                    OraDateEmprunt.Direction = ParameterDirection.Input;
                    OraDateRetourPrevu.Direction = ParameterDirection.Input;

                    OraNumExemplaire.Value = Ajouter.numExemplaire;
                    OraNumAdherent.Value = Ajouter.numAdherent;
                    OraDateEmprunt.Value = DateTime.Parse(Ajouter.dateEmprunt);
                    OraDateRetourPrevu.Value = DateTime.Parse(Ajouter.dateRetourPrevu);

                    oraAjout.Parameters.Add(OraNumExemplaire);
                    oraAjout.Parameters.Add(OraNumAdherent);
                    oraAjout.Parameters.Add(OraDateEmprunt);
                    oraAjout.Parameters.Add(OraDateRetourPrevu);

                    oraAjout.ExecuteNonQuery();
                    ReloadDGV();
                }
                catch (OracleException ex)
                {
                    ErrorMessage(ex);
                }

            }
        }


        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            Emprunts_Ajouter Modifier = new Emprunts_Ajouter();
            Modifier.conn = this.conn;
            Modifier.Text = "Modification";
            Modifier.modification();
            Modifier.numPret = DGV_Emprunts.SelectedRows[0].Cells[1].Value.ToString();
            Modifier.numAdherent = DGV_Emprunts.SelectedRows[0].Cells[0].Value.ToString();
            Modifier.numExemplaire = DGV_Emprunts.SelectedRows[0].Cells[2].Value.ToString();
            Modifier.dateEmprunt = DGV_Emprunts.SelectedRows[0].Cells[3].Value.ToString();
            Modifier.dateRetourPrevu = DGV_Emprunts.SelectedRows[0].Cells[4].Value.ToString();
            if (Modifier.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                try
                {
                    OracleCommand oraAjout = new OracleCommand("GestionEmprunts", conn);
                    oraAjout.CommandText = "GestionEmprunts.MODIFEMPRUNT";
                    oraAjout.CommandType = CommandType.StoredProcedure;

                    OracleParameter OraNumPret = new OracleParameter("PNumPret", OracleDbType.Int32);
                    OracleParameter OraDateRetourPrevu = new OracleParameter("PDateRetourPrevu", OracleDbType.Date);

                    OraNumPret.Direction = ParameterDirection.Input;
                    OraDateRetourPrevu.Direction = ParameterDirection.Input;

                    OraNumPret.Value = Modifier.numPret;
                    OraDateRetourPrevu.Value = DateTime.Parse(Modifier.dateRetourPrevu);

                    oraAjout.Parameters.Add(OraNumPret);
                    oraAjout.Parameters.Add(OraDateRetourPrevu);

                    oraAjout.ExecuteNonQuery();
                    ReloadDGV();
                }
                catch (OracleException ex)
                {
                    ErrorMessage(ex);
                }
            }
        }

        private void ReloadDGV()
        {
            try
            {
                OracleCommand oraSelect = new OracleCommand("GestionEmprunts", conn);
                oraSelect.CommandText = "GestionEmprunts.ConsultEmprunts";
                oraSelect.CommandType = CommandType.StoredProcedure;

                //Retour
                OracleParameter OraParaResultat = new OracleParameter("Resultat", OracleDbType.RefCursor);
                OraParaResultat.Direction = ParameterDirection.ReturnValue;
                oraSelect.Parameters.Add(OraParaResultat);

                //Remplir DGV 
                OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
                AdherentDGV = new DataSet();
                oraAdapter.Fill(AdherentDGV);
                DGV_Emprunts.DataSource = AdherentDGV.Tables[0];

                updateControls();
            }
            catch (OracleException ex)
            {
                ErrorMessage(ex);
            }
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
            this.Close();
        }

        private void Emprunts_Load(object sender, EventArgs e)
        {
            ReloadDGV();
            updateControls();
        }

        private void updateControls()
        {
            if (DGV_Emprunts.RowCount > 0)
            {
                BTN_Modifier.Enabled = true;
            }
            else
            {
                BTN_Modifier.Enabled = false;
            }
        }
        private void ErrorMessage(OracleException Ex)
        {
            switch (Ex.Number)
            {
                case 20325:
                    MessageBox.Show("Le livre n'est pas disponible", "Erreur 20325", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show("Une erreur non-gerer est survenue : " + Ex.Number.ToString() + ":" + Ex.Message.ToString(), Ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void Emprunts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }
    }
}

    


