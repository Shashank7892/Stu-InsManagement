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
    public partial class CGPAForm : Form
    {
        public CGPAForm()
        {
            InitializeComponent();
            label1.Hide();
            label2.Hide();
            textBox2.Hide();
            Update_btn.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            string query = "select CGPA from CGPATable WHERE UserID = @UserID";
            SqlConnection conn = null;
            try
            {
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    label1.Text = dt.Rows[0][0].ToString();
                    label1.Show();
                    textBox2.Show();
                    Update_btn.Show();
                    label2.Show();
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    label1.Hide();
                    label2.Hide();
                    textBox2.Hide();
                    Update_btn.Hide();
                    MessageBox.Show("User id not Found");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter the USER ID!");
            }
            else
            {
                string query1 = "Update CGPATable set CGPA=@CGPA WHERE UserID=@UserID";
                SqlConnection conn = null;
                try
                {
                    conn = sqlConnect.GetSqlConnect();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query1, conn);
                    cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@CGPA", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("CGPA Updated!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    label1.Text = "";
                    label2.Hide();
                    textBox2.Hide();
                    Update_btn.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeachersDashboardForm f = new TeachersDashboardForm();
            this.Close();
            f.Show();
        }
    }
}
