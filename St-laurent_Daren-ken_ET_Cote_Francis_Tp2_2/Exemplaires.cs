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
    public partial class Exemplaires : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        private string livre = null;
        private DataSet Exemplairedata = null;
        public Exemplaires(string Livre)
        {
            livre = Livre;
            InitializeComponent();
        }
        
        private void updateControls()
        {
            if (DGV_Exemplaires.RowCount > 0)
                BTN_Delete.Enabled = true;
            else
                BTN_Delete.Enabled = false;
        }
        private void Exemplaires_Load(object sender, EventArgs e)
        {
            reloadDGV();
            updateControls();
        }

        private void reloadDGV()
        {
            try
            {
                OracleCommand oraSelect = conn.CreateCommand();
                oraSelect.CommandText = "GestionEXEMPLAIRES.consulexemplaireparlivre";
                oraSelect.CommandType = CommandType.StoredProcedure;

                OracleParameter oraParamLivre = new OracleParameter("PNUMLIVRE",OracleDbType.Int32);
                oraParamLivre.Direction = ParameterDirection.Input;
                oraParamLivre.Value = Int32.Parse(livre);

                //Retour
                OracleParameter OraParaResultat = new OracleParameter("Resultat", OracleDbType.RefCursor);
                OraParaResultat.Direction = ParameterDirection.ReturnValue;
                oraSelect.Parameters.Add(OraParaResultat);

                //Remplir DGV 
                OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
                Exemplairedata = new DataSet();
                oraAdapter.Fill(Exemplairedata);
                DGV_Exemplaires.DataSource = Exemplairedata.Tables[0];
                updateControls();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {

        }
        private void BTN_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
