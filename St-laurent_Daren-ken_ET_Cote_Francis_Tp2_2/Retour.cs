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

namespace St_laurent_Daren_ken_ET_Cote_Francis_Tp2_2
{
    public partial class Retour : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        private DataSet RetourDGV = null;
        public int numPret = 0;
    

        public Retour()
        {
            InitializeComponent();
        }
        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            Retour_Ajouter Modifier = new Retour_Ajouter();
            Modifier.conn = this.conn;
            Modifier.Text = "Modification";
            Modifier.numPret = DGV_Retour.SelectedRows[0].Cells[0].Value.ToString();
            if (DGV_Retour.SelectedRows[0].Cells[1].Value.ToString() != "")
                //MessageBox.Show(DGV_Retour.SelectedRows[0].Cells[1].Value.ToString());
                Modifier.dateEmpruntReel = DGV_Retour.SelectedRows[0].Cells[1].Value.ToString();
            else
                Modifier.dateEmpruntReel = DateTime.Today.ToString();

            if (Modifier.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                try
                {
                    OracleCommand oraAjout = new OracleCommand("GestionRetours", conn);
                    oraAjout.CommandText = "GestionRetours.Modifretour";
                    oraAjout.CommandType = CommandType.StoredProcedure;

                    OracleParameter OraNumPret = new OracleParameter("PNumPret", OracleDbType.Int32);
                    OracleParameter OraDateRetourReel = new OracleParameter("PDateRetourReel", OracleDbType.Date);

                    OraNumPret.Direction = ParameterDirection.Input;
                    OraDateRetourReel.Direction = ParameterDirection.Input;


                    OraNumPret.Value = Modifier.numPret;
                    OraDateRetourReel.Value = DateTime.Parse(Modifier.dateEmpruntReel);


                    oraAjout.Parameters.Add(OraNumPret);
                    oraAjout.Parameters.Add(OraDateRetourReel);

                    oraAjout.ExecuteNonQuery();
                    ReloadDGV();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand oraDelete = new OracleCommand("GestionRetours", conn);
                oraDelete.CommandText = "GestionRetours.Supprimer";
                oraDelete.CommandType = CommandType.StoredProcedure;

                OracleParameter OraParaNumPret = new OracleParameter("PNumPret", OracleDbType.Int32);
                OraParaNumPret.Value = DGV_Retour.SelectedRows[0].Cells[0].Value.ToString();
                OraParaNumPret.Direction = ParameterDirection.Input;
                oraDelete.Parameters.Add(OraParaNumPret);

                oraDelete.ExecuteNonQuery();
                ReloadDGV();
            }
            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void ReloadDGV()
        {
            try
            {
                OracleCommand oraSelect = new OracleCommand("GestionRetour", conn);
                oraSelect.CommandText = "GestionRetours.ConsulRetour";
                oraSelect.CommandType = CommandType.StoredProcedure;

                //Retour
                OracleParameter OraParaResultat = new OracleParameter("Resultat", OracleDbType.RefCursor);
                OraParaResultat.Direction = ParameterDirection.ReturnValue;
                oraSelect.Parameters.Add(OraParaResultat);

                //Remplir DGV 
                OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
                RetourDGV = new DataSet();
                oraAdapter.Fill(RetourDGV);
                DGV_Retour.DataSource = RetourDGV.Tables[0];
                updateControls();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Retour_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            if(callBackForm != null)
            callBackForm.Show();
            this.Close();
        }

        private void Retour_Load(object sender, EventArgs e)
        {
            ReloadDGV();
        }

        private void updateControls()
        {
            if (DGV_Retour.RowCount > 0)
            {
                BTN_Modifier.Enabled = true;
                BTN_Supprimer.Enabled = true;
            }
            else
            {
                BTN_Modifier.Enabled = false;
                BTN_Supprimer.Enabled = false;
            }
        }
    }
}
