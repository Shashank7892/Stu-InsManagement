using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace StdUtilMgmt_Beta
{
    public partial class StudendDashboardForm : Form
    {
        
        string but = "";
        public StudendDashboardForm()
        {
            
            InitializeComponent();
            button2.Text= "   "+ Global.name;
            EnableButton();
            timer1.Start();
        }

        public void EnableButton()
        {
            string query = "select BrowserA,CalculatorA,PdfReaderA,GamesA from Login WHERE UserID=@UserID";
            SqlConnection conn = null;

            try
            {
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", Global.user);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                   
                    if(dt.Rows[0][0].ToString() == "1")
                    {
                        Browser_btn.Enabled = true;
                    }
                    else
                    {
                        Browser_btn.Enabled = false;
                    }

                    if (dt.Rows[0][1].ToString() == "1")
                    {
                        Calculator_btn.Enabled = true;
                    }
                    else
                    {
                        Calculator_btn.Enabled = false;
                    }

                    if (dt.Rows[0][2].ToString() == "1")
                    {
                        PDF_Reader_btn.Enabled = true;
                    }
                    else
                    {
                        PDF_Reader_btn.Enabled = false;
                    }

                    if (dt.Rows[0][3].ToString() == "1")
                    {
                        Games_btn.Enabled = true;
                    }
                    else
                    {
                        Games_btn.Enabled = false;
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
            }
            conn.Close();
        }

        private void Calculator_btn_Click(object sender, EventArgs e)
        {
            but = "CalculatorCounter";
            increment();
            CalculatorForm f = new CalculatorForm();
            f.Show();
        }

        public void noname()
        {
            Browser_btn.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudendDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            this.Hide();
            f.Show();
        }

        private void Browser_btn_Click(object sender, EventArgs e)
        {
            but = "BrowserCounter";
            increment();
            BrowserForm f = new BrowserForm();
            f.Show();
        }

        public void increment()
        {
            try
            {
                string query = "select " + but + " from Login WHERE UserID = @UserID";
                SqlConnection conn = null;
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", Global.user);
                cmd.Parameters.AddWithValue("@but", but);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int count = int.Parse(dt.Rows[0][0].ToString());
                count++;
                conn.Close();

                query = "UPDATE Login SET " + but + " = '" + count + "' WHERE UserID = @UserID";
                conn = null;
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", Global.user);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }



        private void PDF_Reader_btn_Click(object sender, EventArgs e)
        {
            but = "PdfReaderCounter";
            increment();
            Documentviewer f = new Documentviewer();
            this.Hide();
            f.Show();
        }

        private void Games_btn_Click(object sender, EventArgs e)
        {
            but = "GamesCounter";
            increment();
            GamesForm f = new GamesForm();
            f.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dtv = DateTime.Now;
            this.Time_lbl.Text = dtv.ToString();
        }

        private void Time_lbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SdntPrblmReportFrom f = new SdntPrblmReportFrom();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyProfileForm f = new MyProfileForm();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed By THARUN M.A & SHASHANK C");
        }

        private void PDF_Reader_btn_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
