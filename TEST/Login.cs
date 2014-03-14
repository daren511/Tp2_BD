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
    public partial class Login : Form
    {
        private OracleConnection conn = null;
        public Login()
        {
            InitializeComponent();
            UpdateControls();
        }


        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            if (conn != null)
                conn.Close();
            this.Close();
        }

        private void BTN_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                string Dsource = "(DESCRIPTION="
               + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
               + "(HOST=205.237.244.251)(PORT=1521)))"
               + "(CONNECT_DATA=(SERVICE_NAME=ORCL)))";

                String ChaineConnexion = "Data Source=" + Dsource
                + ";User Id=" + TB_Username.Text + " ; Password =" + TB_Password.Text;
                conn = new OracleConnection();
                conn.ConnectionString = ChaineConnexion;

                conn.Open();

                if (conn.State.ToString() == "Open")
                {
                    Cursor = Cursors.Default;
                    Gestion_Livres fd = new Gestion_Livres();
                    fd.conn = conn;

                    this.Hide();
                    fd.callBackForm = this;
                    fd.Show();
                    LB_Error.Text = "";
                    LB_MDP.ForeColor = Color.Black;
                    LB_Username.ForeColor = Color.Black;
                }

            }
            catch (OracleException ex)
            {
                ErrorMessage(ex);
                Cursor = Cursors.Default;
            }
        }

        private void TB_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_Connect_Click(sender, e);
            }
        }

        private void UpdateControls()
        {
            if (TB_Username.Text == "" || TB_Password.Text == "")
            {
                BTN_Connect.Enabled = false;
            }
            else
            {
                BTN_Connect.Enabled = true;
            }
        }

        private void TB_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }
        private void ErrorMessage(OracleException Ex)
        {
            switch (Ex.Number)
            {
                case 1017:
                    LB_Username.ForeColor = Color.Red;
                    LB_MDP.ForeColor = Color.Red;
                    TB_Password.Clear();
                    TB_Password.Focus();
                    LB_Error.Text = "*Erreur Usager/Mot de passe";
                    break;
                case 12170:
                    MessageBox.Show("La base de données est indisponible,réessayer plus tard", "Erreur 12170", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 12543:
                    MessageBox.Show("Connexion impossible,Vérifiez votre connection internet", "Erreur 12543", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default: MessageBox.Show(Ex.Message.ToString());
                    break;
            }
        }
    }
}
