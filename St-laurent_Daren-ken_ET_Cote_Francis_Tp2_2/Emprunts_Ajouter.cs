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



        private void Emprunts_Ajouter_Load(object sender, EventArgs e)
        {
            DTP_DateRetourPrevu.MinDate = DateTime.Today;

            OracleCommand oraSelect = new OracleCommand("GestionEmprunts", conn);
            oraSelect.CommandText = "GestionEmprunts.ConsulNumExemplaire";
            oraSelect.CommandType = CommandType.StoredProcedure;

            // A REVOIR!! ON A PAS LE DROIT DE FAIRE SA
            //using (OracleDataReader oraReader = oraSelect.ExecuteReader())
            //{
            //    while (oraReader.Read())
            //    {
            //        CB_NumExemplaire.Items.Add(oraReader.GetString(0));
            //    }
            //}
            //OracleCommand oraSelectAdherent = new OracleCommand("GestionEmprunts", conn);
            //oraSelectAdherent.CommandText = "GestionEmprunts.ConsulNumAdherent";
            //oraSelectAdherent.CommandType = CommandType.StoredProcedure;

            //using (OracleDataReader oraReaderAd = oraSelectAdherent.ExecuteReader())
            //{
            //    while (oraReaderAd.Read())
            //    {
            //        CB_NumAdherent.Items.Add(oraReaderAd.GetString(0));
            //    }
            //}

        }
    }
}
