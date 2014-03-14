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
    public partial class Form_Ajouter_Adherent : Form
    {
        public OracleConnection conn = null;
        public Form_Ajouter_Adherent()
        {
            InitializeComponent();
        }

        public string numAdherent
        {
            get
            {
                return TB_NumAdherent.Text;
            }
            set
            {
                TB_NumAdherent.Text = value;
            }
        }
        public string nomAdherent
        {
            get
            {
                return TB_NomAdherent.Text;
            }
            set
            {
                TB_NomAdherent.Text = value;
            }
        }
        public string prenomAdherent
        {
            get
            {
                return TB_PrenomAdherent.Text;
            }
            set
            {
                TB_PrenomAdherent.Text = value;
            }
        }
    }
}
