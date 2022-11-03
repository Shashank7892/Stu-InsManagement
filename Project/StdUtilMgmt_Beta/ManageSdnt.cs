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
using System.IO;

namespace StdUtilMgmt_Beta
{
    public partial class ManageSdnt : Form
    {
        public ManageSdnt()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string d = comboBox1.Text;
            Global.ddd = d;
            Load(d);
        }
        public void Load(string dd)
        {
            string query = "select * from Login WHERE Standard=@Standard";
            SqlConnection conn = null;
            try
            {
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Standard", dd);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
                else
                {
                    dataGridView1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
            conn.Close();

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
                    Load(Global.ddd);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
                conn.Close();

                string q = "delete from CGPATable WHERE UserID=@UserID";
                try
                {
                    conn = sqlConnect.GetSqlConnect();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@UserID", FileName);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Load(Global.ddd);
                    MessageBox.Show("User Removed!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeachersDashboardForm f = new TeachersDashboardForm();
            this.Hide();
            f.Show();
        }
    }
}
