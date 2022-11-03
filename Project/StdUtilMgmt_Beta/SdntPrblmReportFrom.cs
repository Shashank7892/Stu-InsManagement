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
    public partial class SdntPrblmReportFrom : Form
    {
        public SdntPrblmReportFrom()
        {
            InitializeComponent();
            
        }
        
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void SdntPrblmReportFrom_Load(object sender, EventArgs e)
        {

        }

        private void Report_btn_Click(object sender, EventArgs e)
        {
            string na = "";
            if (checkBox1.Checked)
            {
                na = Global.name;
            }
            else
            {
                na = "Anonymous";
            }
            if(Comboselect.Text=="Select")
            {
                MessageBox.Show("Select the tYPE");
            }
            else
            {
                if(textBox1.Text=="")
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    string query = "insert into ReportTable (Name ,Type ,Description) values (@Name, @Type, @Description)";
                    SqlConnection conn = null;
                    try
                    {
                        conn = sqlConnect.GetSqlConnect();
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Name", na);
                        cmd.Parameters.AddWithValue("@Type", Comboselect.Text);
                        cmd.Parameters.AddWithValue("@Description", textBox1.Text);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Report sucessful");
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        conn.Close();
                    }
                }
            }

        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            StudendDashboardForm f = new StudendDashboardForm();
            f.Show(); 
            this.Hide();
        }
    }
}
