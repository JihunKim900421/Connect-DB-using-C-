using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_jay
{
    public partial class Join : Form
    {
        public Join()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Main fm = new Main();
            SqlConnection con = fm.ConnectDB(Global.DatabasePath.DB);

            string id = tbUser.Text;
            string pass = tbPass.Text;

            string sql;
            sql = "INSERT INTO userlist(r_user,j_date,pass,grade) values('"+id+"',getdate(),'"+pass+"',1)";

            SqlCommand cmd = new SqlCommand(sql, con);
            int result = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            this.Close();
        }
    }
}
