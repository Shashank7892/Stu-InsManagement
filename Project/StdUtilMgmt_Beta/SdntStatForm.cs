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
    public partial class SdntStatForm : Form
    {
        public SdntStatForm()
        {
            InitializeComponent();
            Name_label.Visible = false;
            Notfound_label.Visible = false;
            BrowserCounter.Visible = false;
            CalculatorCounter.Visible = false;
            GamesCounter.Visible = false;
            PdfreaderCounter.Visible = false;
            OABrowser.Visible = false;
            OACalculator.Visible = false;
            OAPdfreader.Visible = false;
            OAGames.Visible = false;
            checkall();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            bool checkuser = checkUser();
            if (checkuser == true)
            {
                Name_label.Text = textBox1.Text+"'s Statistics";
                Name_label.Visible = true;
                Notfound_label.Visible = false;
                assign();
            }
            else
            {
                BrowserCounter.Visible = false;
                CalculatorCounter.Visible = false;
                GamesCounter.Visible = false;
                PdfreaderCounter.Visible = false;
                Name_label.Visible = false;
                Notfound_label.Visible = true;
            }

        }
        public bool checkUser()
        {
            string user =textBox1.Text;
            string query = "select * from Login WHERE UserID = @UserID";
            bool check = true;
            SqlConnection conn = null;

            try
            {
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", user);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    check = true;
                    conn.Close();
                }
                else
                {
                    check = false;
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

            return check;
        }

        public void assign()
        {
            SqlConnection conn = null;
            try
            {
                string query = "select BrowserCounter,CalculatorCounter,PdfReaderCounter,GamesCounter from Login WHERE UserID = @UserID";
                
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
                    BrowserCounter.Text = dt.Rows[0][0].ToString();
                    CalculatorCounter.Text= dt.Rows[0][1].ToString();
                    PdfreaderCounter.Text= dt.Rows[0][2].ToString();
                    GamesCounter.Text= dt.Rows[0][3].ToString();
                    BrowserCounter.Visible = true;
                    CalculatorCounter.Visible = true;
                    GamesCounter.Visible = true;
                    PdfreaderCounter.Visible = true;
                    conn.Close();
                }
                else
                {
                    
                    conn.Close();
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }
        public void checkall()
        {
            SqlConnection conn = null;

            try
            {
                string query = "select sum(BrowserCounter),sum(CalculatorCounter),sum(PdfReaderCounter),sum(GamesCounter) from Login";
                
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    OABrowser.Visible = true;
                    OACalculator.Visible = true;
                    OAPdfreader.Visible = true;
                    OAGames.Visible = true;
                    OABrowser.Text = dt.Rows[0][0].ToString();
                    OACalculator.Text= dt.Rows[0][1].ToString();
                    OAPdfreader.Text= dt.Rows[0][2].ToString();
                    OAGames.Text= dt.Rows[0][3].ToString();
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            finally
            {
                conn.Close();
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeachersDashboardForm f = new TeachersDashboardForm();
            this.Hide();
            f.Show();
        }

        private void SdntStatForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GamesCounter_Click(object sender, EventArgs e)
        {

        }

        private void CalculatorCounter_Click(object sender, EventArgs e)
        {

        }

        private void BrowserCounter_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Notfound_label_Click(object sender, EventArgs e)
        {

        }

        private void PdfreaderCounter_Click(object sender, EventArgs e)
        {

        }

        private void Name_label_Click(object sender, EventArgs e)
        {

        }
    }
}
