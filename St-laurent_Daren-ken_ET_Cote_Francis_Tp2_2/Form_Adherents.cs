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
    public partial class Form_Adherents : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        private DataSet AdherentDGV = null;
        public Form_Adherents()
        {
            InitializeComponent();
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            Form_Ajouter_Adherent Ajouter = new Form_Ajouter_Adherent();
            Ajouter.conn = this.conn;
            Ajouter.Text = "Ajout";
            if (Ajouter.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                try
                {
                    OracleCommand oraAjout = new OracleCommand("GestionAdherents", conn);
                    oraAjout.CommandText = "GestionAdherents.Insertion";
                    oraAjout.CommandType = CommandType.StoredProcedure;

                    OracleParameter OraParaNom = new OracleParameter("PNom", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaPrenom = new OracleParameter("PPrenom", OracleDbType.Varchar2, 40);

                    OraParaNom.Direction = ParameterDirection.Input;
                    OraParaPrenom.Direction = ParameterDirection.Input;


                    OraParaNom.Value = Ajouter.nomAdherent;
                    OraParaPrenom.Value = Ajouter.prenomAdherent;

                    oraAjout.Parameters.Add(OraParaNom);
                    oraAjout.Parameters.Add(OraParaPrenom);

                    oraAjout.ExecuteNonQuery();
                    ReloadDGV();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }

        private void BTN_Modif_Click(object sender, EventArgs e)
        {
            Form_Ajouter_Adherent Modifier = new Form_Ajouter_Adherent();
            Modifier.conn = conn;
            Modifier.Text = "Modification";
            Modifier.numAdherent = DGV_Adherent.SelectedRows[0].Cells[0].Value.ToString();
            Modifier.nomAdherent = DGV_Adherent.SelectedRows[0].Cells[1].Value.ToString();
            Modifier.prenomAdherent = DGV_Adherent.SelectedRows[0].Cells[2].Value.ToString();

            if(Modifier.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try 
                {
                    OracleCommand oraUpdate = new OracleCommand("GestionAdherents", conn);
                    oraUpdate.CommandText = "GestionAdherents.ModifAdherent";
                    oraUpdate.CommandType = CommandType.StoredProcedure;

                    OracleParameter paramNumAdherent = new OracleParameter("PNumAdherent", OracleDbType.Int32);
                    OracleParameter paramNom = new OracleParameter("Pnom", OracleDbType.Varchar2, 40);
                    OracleParameter paramPrenom = new OracleParameter("PPrenom", OracleDbType.Varchar2, 40);

                    paramNumAdherent.Direction = ParameterDirection.Input;
                    paramNom.Direction = ParameterDirection.Input;
                    paramPrenom.Direction = ParameterDirection.Input;


                    paramNumAdherent.Value = Modifier.numAdherent;
                    paramNom.Value = Modifier.nomAdherent;
                    paramPrenom.Value = Modifier.prenomAdherent;


                    oraUpdate.Parameters.Add(paramNumAdherent);
                    oraUpdate.Parameters.Add(paramNom);
                    oraUpdate.Parameters.Add(paramPrenom);
                    

                    oraUpdate.ExecuteNonQuery();
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
                OracleCommand oraDelete = new OracleCommand("GestionAdherents", conn);
                oraDelete.CommandText = "GestionAdherents.Supprimer";
                oraDelete.CommandType = CommandType.StoredProcedure;

                OracleParameter OraParaNumAdherent = new OracleParameter("PNumAdherent", OracleDbType.Int32);
                OraParaNumAdherent.Value = DGV_Adherent.SelectedRows[0].Cells[0].Value.ToString();
                OraParaNumAdherent.Direction = ParameterDirection.Input;
                oraDelete.Parameters.Add(OraParaNumAdherent);

                oraDelete.ExecuteNonQuery();
                ReloadDGV();
            }
            catch (OracleException ex)
            {

                MessageBox.Show(ex.Message.ToString());

            }

        }

        private void Form_Adherents_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void ReloadDGV()
        {
            try 
            {
                OracleCommand oraSelect = new OracleCommand("GestionAdherents", conn);
                oraSelect.CommandText = "GestionAdherents.Consuladherent";
                oraSelect.CommandType = CommandType.StoredProcedure;

                //Retour
                OracleParameter OraParaResultat = new OracleParameter("Resultat", OracleDbType.RefCursor);
                OraParaResultat.Direction = ParameterDirection.ReturnValue;
                oraSelect.Parameters.Add(OraParaResultat);

                //Remplir DGV 
                OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
                AdherentDGV = new DataSet();
                oraAdapter.Fill(AdherentDGV);
                DGV_Adherent.DataSource = AdherentDGV.Tables[0];
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        

        private void Form_Adherents_Load(object sender, EventArgs e)
        {
            ReloadDGV();
        }

        private void BTN_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
