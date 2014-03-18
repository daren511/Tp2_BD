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
    public partial class Emprunts_Ajouter : Form
    {
        public OracleConnection conn = null;
        public Emprunts_Ajouter()
        {
            InitializeComponent();
        }

        public string numAdherent
        {
            get
            {
                return CB_NumAdherent.Text;
            }
            set
            {
                CB_NumAdherent.Text = value;
            }

        }
        public string numPret
        {
            get
            {
                return CB_Pret.Text;
            }
            set
            {
                CB_Pret.Text = value;
            }

        }

        public string numExemplaire
        {
            get
            {
                return CB_NumExemplaire.Text;
            }
            set
            {
                CB_NumExemplaire.Text = value;
            }

        }

        public string dateEmprunt
        {
            get
            {
                return DTP_DateEmprunt.Value.ToShortDateString();
            }
            set
            {
                DTP_DateEmprunt.Value = DateTime.Parse(value);
            }
        }

        public string dateRetourPrevu
        {
            get
            {
                return DTP_DateRetourPrevu.Value.ToShortDateString();
            }
            set
            {
                DTP_DateRetourPrevu.Value = DateTime.Parse(value);
            }
        }

        public void modification()
        {
            CB_NumAdherent.Enabled = false;
            CB_NumExemplaire.Enabled = false;
        }

        private void Emprunts_Ajouter_Load(object sender, EventArgs e)
        {
            DTP_DateRetourPrevu.MinDate = DateTime.Today;
            fillCB();
        }

        private void fillCB()
        {
            try
            {
                OracleCommand oraSelect = new OracleCommand("GestionEmprunts", conn);
                oraSelect.CommandText = "GestionEmprunts.ConsulNumExemplaire";
                oraSelect.CommandType = CommandType.StoredProcedure;

                OracleParameter oraParamSelect = new OracleParameter("RESULTAT", OracleDbType.RefCursor);
                oraParamSelect.Direction = ParameterDirection.ReturnValue;
                oraSelect.Parameters.Add(oraParamSelect);

                using (OracleDataReader oraReader = oraSelect.ExecuteReader())
                {
                    while (oraReader.Read())
                    {
                        CB_NumExemplaire.Items.Add(oraReader.GetInt32(0).ToString());
                    }
                }
            }
            catch (OracleException ex)
            {
                ErrorMessage(ex);
            }
            try
            {

                OracleCommand oraSelect2 = conn.CreateCommand(); ;
                oraSelect2.CommandText = "GestionEmprunts.Consulnumadherent";
                oraSelect2.CommandType = CommandType.StoredProcedure;

                OracleParameter oraParamSelect2 = new OracleParameter("RESULTAT", OracleDbType.RefCursor);
                oraParamSelect2.Direction = ParameterDirection.ReturnValue;
                oraSelect2.Parameters.Add(oraParamSelect2);

                using (OracleDataReader oraReader2 = oraSelect2.ExecuteReader())
                {
                    while (oraReader2.Read())
                    {
                        CB_NumAdherent.Items.Add(oraReader2.GetInt32(0).ToString());
                    }
                }
            }

            catch (OracleException ex)
            {
                ErrorMessage(ex);
            }
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

    

