using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DB_jay
{
    
    public partial class Main : Form
    {   
        public Main()
        {
            InitializeComponent();
            
            // DB Connect
            SqlConnection con = ConnectDB(Global.DatabasePath.DB);

            // Print List to DataGridView
            OutputFromDB(con, dgv1);
        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)   // Print Body into tbBody
        {
            
            string[] idx = new string[3];
            int i=0;
            while(i < 3)
            {
                idx[i] = dgv1.CurrentRow.Cells[i+1].Value.ToString();
                i++;
            }

            // DB Connect
            SqlConnection con = ConnectDB(Global.DatabasePath.DB);

            // Throw SQL to DB for fetching Record unit
            string sql;
            sql = "SELECT * FROM bodylist WHERE r_user = N'"+ idx[0] + "' AND title = N'" + idx[1] + "'";
                        
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader data = cmd.ExecuteReader();
            
            while(data.Read())
            {
                tbUser.Text = data.GetString(1);
                tbTitle.Text = data.GetString(2);
                tbDate.Text = data.GetValue(3).ToString();
                tbBody.Text = data.GetString(4);
            }
            
            data.Close();
            cmd.Dispose();
            con.Close();
           
        } 
        public SqlConnection ConnectDB(string DBpath)  // Connect DB
        {
            string addr = DBpath;
            bool isConn = false;
            SqlConnection conn = new SqlConnection(addr);
            try
            { 
                conn.Open();
                isConn = true;
            }
            catch(ArgumentException e)
            {
                MessageBox.Show("Check the ConnectionString.");
                isConn = false;
            }
            catch(SqlException e)
            {
                MessageBox.Show("Check the SQL server.");
                isConn = false;
            }

            if(isConn != true)
            {   
                Application.Exit();
            }
            return conn;
        }
        private void OutputFromDB(SqlConnection conn, DataGridView dgv)    // Make Datatable from DB and Output to DatagridView
        {
            DataSet dataset = new DataSet();

            string sql;
            sql = "SELECT id,r_user,title,w_date FROM bodylist ORDER BY w_date DESC";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(dataset);
            dgv.DataSource = dataset.Tables[0];

            // Make up
            int wd = dgv.Width;
            dgv.Columns[0].HeaderText = "";
            dgv.Columns[1].HeaderText = "글쓴이";
            dgv.Columns[2].HeaderText = "제목";
            dgv.Columns[3].HeaderText = "작성일";

            dgv.Columns[0].Width = (int)(wd * 0.05);
            dgv.Columns[1].Width = (int)(wd * 0.175);
            dgv.Columns[2].Width = (int)(wd * 0.60);
            dgv.Columns[3].Width = (int)(wd * 0.175);

            dgv.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            conn.Close();
        }
        private void OutputFromDB(SqlConnection conn, DataGridView dgv, string SQL)    // Make Datatable from DB and Output to DatagridView
        {
            DataSet dataset = new DataSet();

            string sql;
            sql = SQL;

            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(dataset);
            dgv.DataSource = dataset.Tables[0];

            // Make up
            int wd = dgv.Width;
            dgv.Columns[0].HeaderText = "";
            dgv.Columns[1].HeaderText = "글쓴이";
            dgv.Columns[2].HeaderText = "제목";
            dgv.Columns[3].HeaderText = "작성일";

            dgv.Columns[0].Width = (int)(wd * 0.05);
            dgv.Columns[1].Width = (int)(wd * 0.175);
            dgv.Columns[2].Width = (int)(wd * 0.60);
            dgv.Columns[3].Width = (int)(wd * 0.175);

            dgv.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            conn.Close();
        }
        private void btCon_Click(object sender, EventArgs e)    // Main Page Reload
        {
            // DB Connect
            SqlConnection con = ConnectDB(Global.DatabasePath.DB);

            // Print List to DataGridView
            OutputFromDB(con, dgv1);

            tbUser.Clear();
            tbTitle.Clear();
            tbBody.Clear();
        }        
        private void btWrite_Click(object sender, EventArgs e)
        {   
            if(Global.Login.Gen == true)
            {
                Write dig = new Write();
                dig.ShowDialog();
            }
            else
            {
                MessageBox.Show("Plz Log-in first.");
            }
            
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            
            if(btLogin.Text == "로그인")
            {
                Log_in fm = new Log_in();
                fm.ShowDialog();
            }
            else if(btLogin.Text == "로그아웃")
            {
                Global.Login.Gen = false;
                Global.Login.Root = false;
                btLogin.Text = "로그인";
            }
            if(Global.Login.Gen == true)
            {
                btLogin.Text = "로그아웃";
            }
            else
            {
                btLogin.Text = "로그인";
            }
            
        }
        private void btJoin_Click(object sender, EventArgs e)
        {
            if (btLogin.Text == "로그아웃")
            {
                Global.Login.Gen = false;
                Global.Login.Root = false;
                btLogin.Text = "로그인";
            }

            Join fm = new Join();
            fm.ShowDialog();
        }
        private void btDel_Click(object sender, EventArgs e)
        {
            if (Global.Login.Root == true)
            {
                string[] idx = new string[3];
                int i = 0;
                while (i < 3)
                {
                    idx[i] = dgv1.CurrentRow.Cells[i + 1].Value.ToString();
                    i++;
                }

                // DB Connect
                SqlConnection con = ConnectDB(Global.DatabasePath.DB);

                // Throw SQL to DB for fetching Record unit
                string sql;
                sql = "DELETE FROM bodylist WHERE r_user = N'" + idx[0] + "' AND title = N'" + idx[1] + "'";

                SqlCommand cmd = new SqlCommand(sql, con);
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Done");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Occured anther Error. Check the DB Connection.");
                }
            }
            else
            {
                MessageBox.Show("You don't have authority.");
            }
                
        }
        private void btRepair_Click(object sender, EventArgs e)
        {
            string[] idx = new string[3];
            string check_id = "";
            int i = 0;
            while (i < 3)
            {
                idx[i] = dgv1.CurrentRow.Cells[i + 1].Value.ToString();
                i++;
            }

            // DB Connect
            SqlConnection con = ConnectDB(Global.DatabasePath.DB);

            // Throw SQL to DB for fetching Record unit
            string sql;
            sql = "SELECT * FROM bodylist WHERE r_user = N'" + idx[0] + "' AND title = N'" + idx[1] + "'";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                check_id = data.GetString(1);
            }
            if ((Global.Login.Gen == true) && (Global.Login.Current_user == check_id))
            {   
                Write dig = new Write(this);
                data.Close();
                cmd.Dispose();
                con.Close();
                dig.ShowDialog();
            }
            else
            {
                MessageBox.Show("You don't have privilege.");
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = ConnectDB(Global.DatabasePath.DB);

            string sql;
            sql = "SELECT id,r_user,title,w_date FROM bodylist WHERE r_user LIKE N'%" + tbSearch.Text + "%' OR title LIKE N'%" + tbSearch.Text + "%' OR body LIKE N'%" + tbSearch.Text + "%' ORDER BY w_date DESC";
            // Print List to DataGridView
            OutputFromDB(con, dgv1,sql);


        }
    }
}
