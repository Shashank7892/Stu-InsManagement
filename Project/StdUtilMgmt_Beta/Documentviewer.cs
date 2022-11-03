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
    public partial class Documentviewer : Form
    {
        public Documentviewer()
        {
            InitializeComponent();
        }

        private void Documentviewer_Load(object sender, EventArgs e)
        {
            Loaddata();
        }
        public void OpenFile(string FileName)
        {
            string query = "select * from Pdfupld where FileName=@FileName";
            SqlConnection conn = null;
            try
            {
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FileName", FileName);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var names = reader["FileName"].ToString();
                    var data = (byte[])reader["Data"];
                    var extension = reader["Extension"].ToString();
                    var newFilename = names.Replace(extension, DateTime.Now.ToString("ddmmyyyyhhmmss")) + extension;
                    File.WriteAllBytes(newFilename, data);
                    System.Diagnostics.Process.Start(newFilename);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }
        public void Loaddata()
        {
            string query = "select FileName,Extension from Pdfupld WHERE Standard="+Global.std+"OR Standard=0";
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
                    DgvDocuments.DataSource = dt;

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }

        private void Btnopen_Click(object sender, EventArgs e)
        {
            var select = DgvDocuments.SelectedRows;
            foreach (var row in select)
            {
                string FileName = (string)((DataGridViewRow)row).Cells[0].Value;
                OpenFile(FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudendDashboardForm f = new StudendDashboardForm();
            this.Close();
            f.Show();
        }
    }
}
