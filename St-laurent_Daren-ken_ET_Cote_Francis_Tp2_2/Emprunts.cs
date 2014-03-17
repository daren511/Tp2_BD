using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DataAccess.Client;

namespace St_laurent_Daren_ken_ET_Cote_Francis_Tp2_2
{
    public partial class Emprunts : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        private DataSet AdherentDGV = null;
        public Emprunts()
        {
            InitializeComponent();
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            Ajouter_Emprunts Ajouter = new Ajouter_Emprunts();
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
                    OracleParameter OraNumExemplaire = new OracleParameter("PNumExemplaire", OracleDbType.Int32);
                    OracleParameter OraNumExemplaire = new OracleParameter("PNumExemplaire", OracleDbType.Int32);

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
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
