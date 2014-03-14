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

namespace St_laurent_Daren_ken_ET_Cote_Francis_Tp2
{
    public partial class Gestion_Livres : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        private DataSet livreDataSet = null;
        public Gestion_Livres()
        {
            InitializeComponent();
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
            this.Close();

        }

        private void BTN_Ajout_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {

        }
        private void reloadDGV()
        {
            int lastIndex = -1;
            if (DGV_Livres.SelectedRows.Count > 0) lastIndex = DGV_Livres.SelectedRows[0].Index;

            OracleCommand oraSelect = conn.CreateCommand();
            oraSelect.CommandText = "GestionLivres.Consultlivre";
            oraSelect.CommandType = CommandType.StoredProcedure;

            OracleParameter oraParaResult = new OracleParameter("Resultats", OracleDbType.RefCursor);
            oraParaResult.Direction = ParameterDirection.ReturnValue;
            oraSelect.Parameters.Add(oraParaResult);

            OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
            livreDataSet = new DataSet();
            oraAdapter.Fill(livreDataSet);
            DGV_Livres.DataSource = livreDataSet.Tables[0];

            if (lastIndex > -1 && DGV_Livres.Rows.Count > 0) DGV_Livres.Rows[Math.Min(lastIndex, DGV_Livres.Rows.Count - 1)].Selected = true;

            updateControls();
        }
        private void updateControls()
        {
            if (DGV_Livres.RowCount > 0)
            {
                BTN_Modifier.Enabled = true;
                BTN_Delete.Enabled = true;
            }
            else
            {
                BTN_Modifier.Enabled = false;
                BTN_Delete.Enabled = false;
            }
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            DialogResult Confirmation;
            Confirmation = MessageBox.Show("Voulez-vous vraiment effacer cette entrée ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Confirmation == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    OracleCommand oraDelete = new OracleCommand("GestionLivres", conn);
                    oraDelete.CommandText = "GestionLivre.Supprimer";
                    oraDelete.CommandType = CommandType.StoredProcedure;

                    OracleParameter oraParaNumLivre = new OracleParameter("PNumLivre", OracleDbType.Int32);
                    oraParaNumLivre.Value = DGV_Livres.SelectedRows[0].Cells[0].Value.ToString();
                    oraParaNumLivre.Direction = ParameterDirection.Input;
                    oraDelete.Parameters.Add(oraParaNumLivre);

                    oraDelete.ExecuteNonQuery();
                    reloadDGV();
                }
                catch (OracleException ex)
                {
                    if (ex.Number == 2292)
                    {
                        MessageBox.Show("TBD", "Erreur 2292", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void Gestion_Livres_Load(object sender, EventArgs e)
        {
            reloadDGV();
        }

        private void Gestion_Livres_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(callBackForm != null)
               callBackForm.Show();
            
        }
    }
}
