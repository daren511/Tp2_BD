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
    public partial class Retour_Ajouter : Form
    {
        public OracleConnection conn = null;
        public Retour_Ajouter()
        {
            InitializeComponent();
        }

        public string numPret
        {
            get
            {
                return CB_NumPret.Text;
            }
            set
            {
                CB_NumPret.Text = value;
            }  
        }
        public string dateEmpruntReel
        {
            get
            {
                return DTP_DateRetourReel.Value.ToShortDateString();
            }
            set
            {
                DTP_DateRetourReel.Value = DateTime.Parse(value);
            }
        }

        private void Retour_Ajouter_Load(object sender, EventArgs e)
        {
            OracleCommand oraSelect = new OracleCommand("GestionRetours", conn);
            oraSelect.CommandText = "GestionRetours.CONSULNUMPRET";
            oraSelect.CommandType = CommandType.StoredProcedure;

            using (OracleDataReader oraReader = oraSelect.ExecuteReader())
            {
                while (oraReader.Read())
                {
                    CB_NumPret.Items.Add(oraReader.GetString(0));
                }
            }
        }
    }
}
