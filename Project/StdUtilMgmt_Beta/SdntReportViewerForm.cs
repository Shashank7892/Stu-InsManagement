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
    public partial class SdntReportViewerForm : Form
    {
        public SdntReportViewerForm()
        {
            InitializeComponent();
            string query = "select * from ReportTable";
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
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("No Data!");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            TeachersDashboardForm f = new TeachersDashboardForm();
            this.Hide();
            f.Show();
        }

        private void SdntReportViewerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
