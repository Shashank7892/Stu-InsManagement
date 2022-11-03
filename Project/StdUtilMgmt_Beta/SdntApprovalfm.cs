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

namespace StdUtilMgmt_Beta
{
    public partial class SdntApprovalfm : Form
    {
        public SdntApprovalfm()
        {
            InitializeComponent();
            LoadData();
        }

        private void SdntApprovalfm_Load(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            string query = "select UserID,Name,DOB,Gender,Father,Mother,Phone from Login where Astatus=0";
            SqlConnection conn = null;
            try
            {
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = dt;
                    button1.Visible = true;
                    button2.Visible = true;
                    conn.Close();
                }
                else
                {
                    dataGridView1.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var select = dataGridView1.SelectedRows;
            string FileName;
            string query = "update Login set Astatus=1 where UserID=@UserID";
            SqlConnection conn = null;
            foreach (var row in select)
            {
                FileName = (string)((DataGridViewRow)row).Cells[0].Value;
                try
                {
                    Global.tmpuser = FileName;
                    conn = sqlConnect.GetSqlConnect();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", FileName);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            }
            query = "Select Standard from Login WHERE UserID=@UserID";
            foreach (var row in select)
            {
                FileName = (string)((DataGridViewRow)row).Cells[0].Value;
                Global.user = FileName;
                try
                {
                    conn = sqlConnect.GetSqlConnect();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", FileName);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        Global.std=dt.Rows[0][0].ToString();
                    }
                    conn.Close();
                    
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            }
            string a="";
            
            if (Global.std == "1")
            {
                a = "First";
            }
            else if (Global.std == "2")
            {
                a = "Second";
            }
            else if (Global.std == "3")
            {
                a = "Third";
            }
            else if (Global.std == "4")
            {
                a = "Fourth";
            }
            else if (Global.std == "5")
            {
                a = "Fifth";
            }
            else if (Global.std == "6")
            {
                a = "Sixth";
            }
            else if (Global.std == "7")
            {
                a = "Seventh";
            }
            else if (Global.std == "8")
            {
                a = "Eighth";
            }
            else if (Global.std == "9")
            {
                a = "Ninth";
            }
            else if (Global.std == "10")
            {
                a = "Tenth";
            }
            else if (Global.std == "11")
            {
                a = "Eleventh";
            }
            else if (Global.std == "12")
            {
                a = "Twelveth";
            }

            query = "select "+ a +" from RegisterCounter";
            try
            {
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int count = int.Parse(dt.Rows[0][0].ToString());
                int c = count;
                Global.tm = count;
                if (dt.Rows.Count > 0)
                {
                       MessageBox.Show("Approved!");
                }
                count++;
                Global.tmpcnt = (c+1);
                conn.Close();
     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            query = "Update Login set RegNo="+ Global.tm+" WHERE UserID =@UserID";
            try
            {
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", Global.tmpuser);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            conn.Close();

            query = "Update RegisterCounter set "+a+"="+ Global.tmpcnt;
            try
            {
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            conn.Close();

            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeachersDashboardForm a = new TeachersDashboardForm();
            this.Hide();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var select = dataGridView1.SelectedRows;
            string FileName;
            string query = "delete from Login WHERE UserID=@UserID";
            SqlConnection conn = null;
            foreach (var row in select)
            {
                FileName = (string)((DataGridViewRow)row).Cells[0].Value;
                try
                {
                    conn = sqlConnect.GetSqlConnect();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", FileName);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            }
        }
    }
}
