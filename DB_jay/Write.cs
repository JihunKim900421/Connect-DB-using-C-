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
    public partial class Write : Form
    {
        public Write()
        {
            InitializeComponent();
            lbUser.Text = Global.Login.Current_user;    
        }
        public Write(Main _main)
        {
            InitializeComponent();
            lbUser.Text = Global.Login.Current_user;
            btOK.Text = "Update";
            tbTitle.Text = _main.tbTitle.Text;
            tbBody.Text = _main.tbBody.Text;

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Main fm = new Main();
            SqlConnection con = fm.ConnectDB(Global.DatabasePath.DB);

            string id = Global.Login.Current_user;
            string title = tbTitle.Text;
            string body = tbBody.Text;
            string sql;

            if (btOK.Text == "Update")
            {
                sql = "UPDATE bodylist SET body = N'"+body+"' WHERE r_user = N'"+id+"' AND title = N'"+title+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int result = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else if(btOK.Text == "OK")
            {
                sql = "INSERT INTO bodylist(r_user,title,w_date,body) values(N'" + id + "', N'" + title + "',getdate(), N'" + body + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                int result = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            else
            {
                MessageBox.Show("Another Error Occured. Check DB or Connection.");
                con.Close();
                this.Close();
            }

            con.Close();

            MessageBox.Show("Done.");
            tbTitle.Clear();
            tbBody.Clear();

            this.Close();
        }

    }
}
