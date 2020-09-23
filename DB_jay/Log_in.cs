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
    public partial class Log_in : Form
    {
        public Log_in()
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

            string id = tbID.Text;
            string pass = tbPass.Text;
            string id_from_db = "";
            string pass_from_db = "";

            string sql;
            sql = "SELECT r_user, pass FROM userlist WHERE r_user = N'" + id + "' AND pass = N'" + pass + "'";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader data = cmd.ExecuteReader();


            fm.btLogin.Text = "로그아웃";
            while (data.Read())
            {
                id_from_db = data.GetString(0);
                pass_from_db = data.GetString(1);
            }

            if ((id == id_from_db) & (pass == pass_from_db))
            {
                Global.Login.Gen = true;
                Global.Login.Current_user = id_from_db;
                if(id_from_db == "김지훈")
                {
                    Global.Login.Root = true;
                }
                data.Close();
                cmd.Dispose();
                con.Close();
                this.Close();

            }
            else
            {
                MessageBox.Show("로그인 실패. 계정정보 확인");
            }
        }
    }
}
