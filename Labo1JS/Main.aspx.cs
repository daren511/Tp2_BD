using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;

namespace Labo1JS
{
    public partial class Main : System.Web.UI.Page
    {
        private const string Dsource = "(DESCRIPTION="
+ "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
+ "(HOST=205.237.244.251)(PORT=1521)))"
+ "(CONNECT_DATA=(SERVICE_NAME=ORCL)))";

        private const String ChaineConnexion = "Data Source=" + Dsource
        + ";User Id=stlaure ; Password =oracle2";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private OracleConnection Connection()
        {
            OracleConnection conn = new OracleConnection(ChaineConnexion);
            conn.Open();
            return conn;
        }

        protected void BTN_Calcul_Click(object sender, EventArgs e)
        {
            OracleConnection conn = null;
            try
            {
                conn = Connection();
            }
            catch(OracleException ex)
            {
                LB_Connection.Text = ex.Number.ToString();
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
    }
}