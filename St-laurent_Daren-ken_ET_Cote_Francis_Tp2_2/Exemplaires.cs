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
        private int livre = 0;
        private DataSet Exemplairedata = null;
        public Exemplaires(int Livre)
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

                //Retour
                OracleParameter OraParaResultat = new OracleParameter("Resultat", OracleDbType.RefCursor);
                OraParaResultat.Direction = ParameterDirection.ReturnValue;


                OracleParameter oraParamLivre = new OracleParameter("PNUMLIVRE",OracleDbType.Int32);
                oraParamLivre.Direction = ParameterDirection.Input;
                oraParamLivre.Value = livre;

                oraSelect.Parameters.Add(OraParaResultat);
                oraSelect.Parameters.Add(oraParamLivre);

                //Remplir DGV 
                OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
                Exemplairedata = new DataSet();
                oraAdapter.Fill(Exemplairedata);
                DGV_Exemplaires.DataSource = Exemplairedata.Tables[0];
                updateControls();
            }
            catch (OracleException ex)
            {
                ErrorMessage(ex);
            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            DialogResult Confirmation;
            Confirmation = MessageBox.Show("Voulez-vous Crée un exemplaire du livre "+ livre.ToString() + " ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Confirmation == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    OracleCommand oraAjout = new OracleCommand("Gestionexemplaires", conn);
                    oraAjout.CommandText = "Gestionexemplaires.Insertion";
                    oraAjout.CommandType = CommandType.StoredProcedure;

                    OracleParameter OraParaNumLivre = new OracleParameter("PNUMLIVRE", OracleDbType.Int32);
                    OracleParameter OraParaDispo = new OracleParameter("PDISPONIBLE", OracleDbType.Char);

                    OraParaNumLivre.Direction = ParameterDirection.Input;
                    OraParaDispo.Direction = ParameterDirection.Input;


                    OraParaNumLivre.Value = livre;
                    OraParaDispo.Value = 1;

                    oraAjout.Parameters.Add(OraParaNumLivre);
                    oraAjout.Parameters.Add(OraParaDispo);

                    oraAjout.ExecuteNonQuery();
                    reloadDGV();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

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
                    OracleCommand oraDelete = new OracleCommand("GestionExemplaires", conn);
                    oraDelete.CommandText = "GestionExemplaires.Supprimer";
                    oraDelete.CommandType = CommandType.StoredProcedure;

                    OracleParameter OraParaNumAdherent = new OracleParameter("PNUMEXEMPLAIRE", OracleDbType.Int32);
                    OraParaNumAdherent.Value = DGV_Exemplaires.SelectedRows[0].Cells[0].Value.ToString();
                    OraParaNumAdherent.Direction = ParameterDirection.Input;
                    oraDelete.Parameters.Add(OraParaNumAdherent);

                    oraDelete.ExecuteNonQuery();
                    reloadDGV();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exemplaires_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }
        private void ErrorMessage(OracleException Ex)
        {
            switch (Ex.Number)
            {
                case 2292:
                    MessageBox.Show("Le livre à déjà été louer", "Erreur 2292", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show("Une erreur non-gerer est survenue : " + Ex.Number.ToString() + ":" + Ex.Message.ToString(), Ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
