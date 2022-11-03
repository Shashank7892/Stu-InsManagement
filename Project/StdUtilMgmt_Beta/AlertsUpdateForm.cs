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
    public partial class AlertsUpdateForm : Form
    {
        public AlertsUpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateAlert_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                SqlConnection conn = null;
                string query = "Update AlertTable set AlertText='No Alerts at the Moment!'";
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                textBox1.Text = "";
            }
            else
            {
                SqlConnection conn = null;
                string query = "Update AlertTable set AlertText=@Message";
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Message", textBox1.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Alert Updated!");
                textBox1.Text = "";
            }
        }

        private void RemoveAlert_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string query = "Update AlertTable set AlertText='No Alerts at the Moment!'";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Alert Removed!");
            textBox1.Text = "";
        }

        private void AlertsUpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeachersDashboardForm f = new TeachersDashboardForm();
            this.Hide();
            f.Show();
        }
    }
}
