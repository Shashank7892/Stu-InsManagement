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
    public partial class MyProfileForm : Form
    {
        public MyProfileForm()
        {
            InitializeComponent();
            Name_label.Text = Global.name;
            UserID_label.Text = Global.user;
            DOB_label.Text = Global.dob;
            Father_label.Text = Global.Father;
            Mother_label.Text = Global.Mother;
            Phone_label.Text = Global.Phone;
            label10.Text = Global.Regno.ToString();
            Standard.Text = Global.std;
            string query = "select * from AlertTable";
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
                    Alerts_label.Text = dt.Rows[0][0].ToString();
                    conn.Close();
                }
                else
                {
                    Alerts_label.Text = "No Alerts!";
                    conn.Close();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                conn.Close();
            }
            delcgpa();
            uppt();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            StudendDashboardForm f = new StudendDashboardForm();
            f.Show();
            this.Hide();
        }
        public void delcgpa()
        {
            string query1 = "select CGPA from CGPATable WHERE UserID=@UserID";
            SqlConnection conn = null;
            try
            {

                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query1, conn);
                cmd.Parameters.AddWithValue("@USerID", Global.user);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cgpa_label.Text = dt.Rows[0][0].ToString();
                    conn.Close();
                }
                else
                {
                    Alerts_label.Text = "No Alerts!";
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                conn.Close();
            }
        }
        public void uppt()
        {
            string query1 = "select Picture from Login WHERE UserID=@UserID";
            SqlConnection conn = null;
            try
            {

                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query1, conn);
                cmd.Parameters.AddWithValue("@USerID", Global.user);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    byte[] img = (byte[])dt.Rows[0][0];
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Cant load Image!");
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                conn.Close();
            }
        }
        
    }
}
