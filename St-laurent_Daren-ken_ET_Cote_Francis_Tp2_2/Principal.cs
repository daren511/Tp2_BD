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
using St_laurent_Daren_ken_ET_Cote_Francis_Tp2;

namespace St_laurent_Daren_ken_ET_Cote_Francis_Tp2_2
{
    public partial class Principal : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        public Principal()
        {
            InitializeComponent();
        }

        private void BTN_Adherents_Click(object sender, EventArgs e)
        {
            Form_Adherents fa = new Form_Adherents();
            fa.conn = conn;

            this.Hide();
            fa.callBackForm = this;
            fa.Show();
        }

        private void BTN_Emprunts_Click(object sender, EventArgs e)
        {
            Emprunts fe = new Emprunts();
            fe.conn = conn;

            this.Hide();
            fe.callBackForm = this;
            fe.Show();
        }

        private void BTN_Retours_Click(object sender, EventArgs e)
        {
            Retour fr = new Retour();
            fr.conn = conn;

            this.Hide();
            fr.callBackForm = this;
            fr.Show();
        }

        private void BTN_Livres_Click(object sender, EventArgs e)
        {
            Gestion_Livres fl = new Gestion_Livres();
            fl.conn = conn;

            this.Hide();
            fl.callBackForm = this;
            fl.Show();
        }

        private void BTN_Deconnexion_Click(object sender, EventArgs e)
        {
            if(callBackForm != null)
            {
                callBackForm.Show();
            }
            this.Close();
        }

        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            callBackForm.Close();
        }
    }
}
