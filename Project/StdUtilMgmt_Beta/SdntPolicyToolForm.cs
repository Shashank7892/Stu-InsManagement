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
    public partial class SdntPolicyToolForm : Form
    {
        public SdntPolicyToolForm()
        {
            InitializeComponent();
            EnableButton();
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            labelb.Visible = false;
            labelc.Visible = false;
            labelp.Visible = false;
            labelg.Visible = false;
            buttonb.Visible = false;
            buttonc.Visible = false;
            buttonp.Visible = false;
            buttong.Visible = false;
            temp.Visible = false;
            nf.Visible = false;
        }
        public void EnableButton()
        {
            string query = "select * from policyTable";


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

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        BrowserEnable_btn.Enabled = false;
                        BrowserDisable_btn.Enabled = true;
                    }
                    else
                    {
                        BrowserEnable_btn.Enabled = true;
                        BrowserDisable_btn.Enabled = false;
                    }

                    if (dt.Rows[0][1].ToString() == "1")
                    {
                        CalculatorEnable_btn.Enabled = false;
                        CalculatorDisable_btn.Enabled = true;
                    }
                    else
                    {
                        CalculatorEnable_btn.Enabled = true;
                        CalculatorDisable_btn.Enabled = false;
                    }

                    if (dt.Rows[0][2].ToString() == "1")
                    {
                        PdfReaderEnable_btn.Enabled = false;
                        PdfReaderDisable_btn.Enabled = true;
                    }
                    else
                    {
                        PdfReaderEnable_btn.Enabled = true;
                        PdfReaderDisable_btn.Enabled = false;
                    }

                    if (dt.Rows[0][3].ToString() == "1")
                    {
                        GamesEnable_btn.Enabled = false;
                        GamesDisable_btn.Enabled = true;
                    }
                    else
                    {
                        GamesEnable_btn.Enabled = true;
                        GamesDisable_btn.Enabled = false;
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
        private void BrowserDisable_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string query = "Update policyTable set Browser=0";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            EnableButton();
            conn = null;
            query = "Update Login set BrowserA=0";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void SdntPolicyToolForm_Load(object sender, EventArgs e)
        {

        }

        private void BrowserEnable_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string query = "Update policyTable set Browser=1";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            EnableButton();
            conn = null;
            query = "Update Login set BrowserA=1";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void CalculatorEnable_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string query = "Update policyTable set Calculator=1";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            EnableButton();
            conn = null;
            query = "Update Login set CalculatorA=1";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void CalculatorDisable_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string query = "Update policyTable set Calculator=0";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            EnableButton();
            conn = null;
            query = "Update Login set CalculatorA=0";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void PdfReaderEnable_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string query = "Update policyTable set PdfReader=1";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            EnableButton();
            conn = null;
            query = "Update Login set PdfReaderA=1";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void PdfReaderDisable_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string query = "Update policyTable set PdfReader=0";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            EnableButton();
            conn = null;
            query = "Update Login set PdfReaderA=0";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void GamesEnable_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string query = "Update policyTable set Games=1";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            EnableButton();
            conn = null;
            query = "Update Login set GamesA=1";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void GamesDisable_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string query = "Update policyTable set Games=0";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            EnableButton();
            conn = null;
            query = "Update Login set GamesA=0";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void gotoDash_btn_Click(object sender, EventArgs e)
        {
            TeachersDashboardForm f = new TeachersDashboardForm();
            this.Hide();
            f.Show();
        }



        private void buttonb_Click(object sender, EventArgs e)
        {

            SqlConnection conn = null;
            string query = "select BrowserA from Login where UserID=@UserID";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            temp.Text = dt.Rows[0][0].ToString();
            conn.Close();
            if (dt.Rows[0][0].ToString() == "1")
            {
                query = "update Login set BrowserA=0 WHERE UserID=@UserID";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                query = "select BrowserA,CalculatorA,PdfReaderA,GamesA from Login WHERE UserID=@UserID";
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.ExecuteNonQuery();
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    nf.Visible = false;
                    labelb.Text = dt.Rows[0][0].ToString();
                    labelc.Text = dt.Rows[0][1].ToString();
                    labelp.Text = dt.Rows[0][2].ToString();
                    labelg.Text = dt.Rows[0][3].ToString();
                }
                conn.Close();
            }
            else
            {
                query = "update Login set BrowserA=1 WHERE UserID=@UserID";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                query = "select BrowserA,CalculatorA,PdfReaderA,GamesA from Login WHERE UserID=@UserID";
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.ExecuteNonQuery();
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    nf.Visible = false;
                    labelb.Text = dt.Rows[0][0].ToString();
                    labelc.Text = dt.Rows[0][1].ToString();
                    labelp.Text = dt.Rows[0][2].ToString();
                    labelg.Text = dt.Rows[0][3].ToString();
                }
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                string query = "select BrowserA,CalculatorA,PdfReaderA,GamesA from Login WHERE UserID=@UserID";
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
                        nf.Visible = false;
                        labelb.Text = dt.Rows[0][0].ToString();
                        labelc.Text = dt.Rows[0][1].ToString();
                        labelp.Text = dt.Rows[0][2].ToString();
                        labelg.Text = dt.Rows[0][3].ToString();
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        label9.Visible = true;
                        labelb.Visible = true;
                        labelc.Visible = true;
                        labelg.Visible = true;
                        labelp.Visible = true;
                        buttonb.Visible = true;
                        buttonc.Visible = true;
                        buttonp.Visible = true;
                        buttong.Visible = true;

                    }
                    else
                    {
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        labelb.Visible = false;
                        labelc.Visible = false;
                        labelp.Visible = false;
                        labelg.Visible = false;
                        buttonb.Visible = false;
                        buttonc.Visible = false;
                        buttonp.Visible = false;
                        buttong.Visible = false;
                        nf.Visible = true;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
            else
            {
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                labelb.Visible = false;
                labelc.Visible = false;
                labelp.Visible = false;
                labelg.Visible = false;
                buttonb.Visible = false;
                buttonc.Visible = false;
                buttonp.Visible = false;
                buttong.Visible = false;
                temp.Visible = false;
                nf.Visible = false;
            }
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string query = "select CalculatorA from Login where UserID=@UserID";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            temp.Text = dt.Rows[0][0].ToString();
            conn.Close();
            if (dt.Rows[0][0].ToString() == "1")
            {
                query = "update Login set CalculatorA=0 WHERE UserID=@UserID";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                query = "select BrowserA,CalculatorA,PdfReaderA,GamesA from Login WHERE UserID=@UserID";
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.ExecuteNonQuery();
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    nf.Visible = false;
                    labelb.Text = dt.Rows[0][0].ToString();
                    labelc.Text = dt.Rows[0][1].ToString();
                    labelp.Text = dt.Rows[0][2].ToString();
                    labelg.Text = dt.Rows[0][3].ToString();
                }
                conn.Close();
            }
            else
            {
                query = "update Login set CalculatorA=1 WHERE UserID=@UserID";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                query = "select BrowserA,CalculatorA,PdfReaderA,GamesA from Login WHERE UserID=@UserID";
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.ExecuteNonQuery();
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    nf.Visible = false;
                    labelb.Text = dt.Rows[0][0].ToString();
                    labelc.Text = dt.Rows[0][1].ToString();
                    labelp.Text = dt.Rows[0][2].ToString();
                    labelg.Text = dt.Rows[0][3].ToString();
                }
                conn.Close();
            }
        }

        private void buttonp_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string query = "select PdfReaderA from Login where UserID=@UserID";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            temp.Text = dt.Rows[0][0].ToString();
            conn.Close();
            if (dt.Rows[0][0].ToString() == "1")
            {
                query = "update Login set PdfReaderA=0 WHERE UserID=@UserID";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                query = "select BrowserA,CalculatorA,PdfReaderA,GamesA from Login WHERE UserID=@UserID";
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.ExecuteNonQuery();
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    nf.Visible = false;
                    labelb.Text = dt.Rows[0][0].ToString();
                    labelc.Text = dt.Rows[0][1].ToString();
                    labelp.Text = dt.Rows[0][2].ToString();
                    labelg.Text = dt.Rows[0][3].ToString();
                }
                conn.Close();
            }
            else
            {
                query = "update Login set PdfReaderA=1 WHERE UserID=@UserID";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                query = "select BrowserA,CalculatorA,PdfReaderA,GamesA from Login WHERE UserID=@UserID";
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.ExecuteNonQuery();
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    nf.Visible = false;
                    labelb.Text = dt.Rows[0][0].ToString();
                    labelc.Text = dt.Rows[0][1].ToString();
                    labelp.Text = dt.Rows[0][2].ToString();
                    labelg.Text = dt.Rows[0][3].ToString();
                }
                conn.Close();
            }
        }

        private void buttong_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string query = "select GamesA from Login where UserID=@UserID";
            conn = sqlConnect.GetSqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            temp.Text = dt.Rows[0][0].ToString();
            conn.Close();
            if (dt.Rows[0][0].ToString() == "1")
            {
                query = "update Login set GamesA=0 WHERE UserID=@UserID";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                query = "select BrowserA,CalculatorA,PdfReaderA,GamesA from Login WHERE UserID=@UserID";
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.ExecuteNonQuery();
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    nf.Visible = false;
                    labelb.Text = dt.Rows[0][0].ToString();
                    labelc.Text = dt.Rows[0][1].ToString();
                    labelp.Text = dt.Rows[0][2].ToString();
                    labelg.Text = dt.Rows[0][3].ToString();
                }
                conn.Close();
            }
            else
            {
                query = "update Login set GamesA=1 WHERE UserID=@UserID";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                query = "select BrowserA,CalculatorA,PdfReaderA,GamesA from Login WHERE UserID=@UserID";
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.ExecuteNonQuery();
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    nf.Visible = false;
                    labelb.Text = dt.Rows[0][0].ToString();
                    labelc.Text = dt.Rows[0][1].ToString();
                    labelp.Text = dt.Rows[0][2].ToString();
                    labelg.Text = dt.Rows[0][3].ToString();
                }
                conn.Close();
            }
        }
    }
}
