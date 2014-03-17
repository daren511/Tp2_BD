using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace St_laurent_Daren_ken_ET_Cote_Francis_Tp2_2
{
    public partial class Livres_Ajout : Form
    {
        public Livres_Ajout()
        {
            InitializeComponent();
        }

        public string numLivre
        {
            get
            {
                return TB_NumLivre.Text;
            }
            set
            {
                TB_NumLivre.Text = value;
            }
        }
        public string titre
        {
            get
            {
                return TB_Titre.Text;
            }
            set
            {
                TB_Titre.Text = value;
            }
        }
        public string auteur
        {
            get
            {
                return TB_Auteur.Text;
            }
            set
            {
                TB_Auteur.Text = value;
            }
        }
    }
}
