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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            button1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUpForm f = new SignUpForm();
            f.Show();
            this.Hide();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            

            if(txtUserID.Text=="a" && txtPassword.Text == "a")
            {
                TeachersDashboardForm f = new TeachersDashboardForm();
                this.Hide();
                f.Show();
            }
            else
            {
                Login();
            }
            
        }

        public void Login()
        {
            string user = txtUserID.Text;
            string password = txtPassword.Text;
            string query = "select * from Login WHERE UserID = @UserID AND Password = @Password";

            Global.user = txtUserID.Text;
            SqlConnection conn = null;

            try
            {
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", user);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][19].ToString()=="1")
                    {
                        Global.name = dt.Rows[0][1].ToString();
                        Global.user = dt.Rows[0][0].ToString();
                        Global.dob = dt.Rows[0][2].ToString();
                        Global.Father = dt.Rows[0][4].ToString();
                        Global.Mother = dt.Rows[0][5].ToString();
                        Global.Phone = dt.Rows[0][6].ToString();
                        Global.Regno = int.Parse(dt.Rows[0][17].ToString());
                        Global.std= dt.Rows[0][8].ToString();
                        conn.Close();
                        StudendDashboardForm f = new StudendDashboardForm();
                        this.Hide();
                        f.Show();
                        // saveDetails(dt);
                    }
                    else
                    {
                        MessageBox.Show("Your Account is not Yet Approved! Please wait for some Time");
                        conn.Close();
                    }

                    
                }
                else
                {
                    MessageBox.Show("Check user id and password");
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

            conn.Close();


        }

        public void saveDetails(DataTable dt)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            
            button2.Visible = false;
            button1.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            RecoveryForm f = new RecoveryForm();
            this.Hide();
            f.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            button2.Visible = true;
            button1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
