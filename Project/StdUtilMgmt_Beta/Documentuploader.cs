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
    public partial class Documentuploader : Form
    {
        public Documentuploader()
        {
            InitializeComponent();
            Filepath.Visible = false;
        }

        private void Browsebtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            Filepath.Text = dlg.FileName;
            Filepath.Visible = true;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            Savefile(Filepath.Text);
            MessageBox.Show("saved");
            clear();
        }

        private void Documentuploader_Load(object sender, EventArgs e)
        {
            Loaddata();
        }
        public void Savefile(string filepath)
        {
            using (Stream stream = File.OpenRead(filepath))
            {
                byte[] files = new byte[stream.Length];
                stream.Read(files, 0, files.Length);
                var fi = new FileInfo(filepath);
                string extn = fi.Extension;
                string name = fi.Name;
                string select = SelectStandard.Text;
                string query = "insert into Pdfupld(Data,Extension,FileName,Standard)values(@data,@extension,@name,@standard)";
                SqlConnection con = null;
                try
                {
                    con = sqlConnect.GetSqlConnect();
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@data", files);
                    cmd.Parameters.AddWithValue("@extension", extn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@standard", select);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                Loaddata();

            }
        }
        public void Loaddata()
        {
            string query = "select FileName,Extension,Standard from Pdfupld";
            SqlConnection con = null;
            try
            {
                con =sqlConnect. GetSqlConnect();
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvDocuments.DataSource = dt;

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void Openbtn_Click(object sender, EventArgs e)
        {
            var select = dgvDocuments.SelectedRows;
            foreach (var row in select)
            {
                string FileName = (string)((DataGridViewRow)row).Cells[0].Value;
                OpenFile(FileName);
            }
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
        public void clear()
        {
            Filepath.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeachersDashboardForm f = new TeachersDashboardForm();
            this.Hide();
            f.Show();

        }
    }
}
