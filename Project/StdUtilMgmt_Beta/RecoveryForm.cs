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
    public partial class RecoveryForm : Form
    {
        public RecoveryForm()
        {
            InitializeComponent();
            nouserf.Visible = false;
            ruserid.Visible = false;
            pm.Visible = false;
            pnm.Visible = false;
            textBox4.UseSystemPasswordChar = true;
            textBox5.UseSystemPasswordChar = true;
            button2.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void Search_Click(object sender, EventArgs e)
        {
            double ph;
            string query = "select UserID from Login where Phone=@Phone";
            if (textBox1.TextLength > 0)
            {
                ph = double.Parse(textBox1.Text);
                SqlConnection conn = null;

                try
                {
                    conn = sqlConnect.GetSqlConnect();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Phone", ph);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        ruserid.Text = dt.Rows[0][0].ToString();
                        ruserid.Visible = true;
                        nouserf.Visible = false;
                        conn.Close();
                    }
                    else
                    {
                        ruserid.Visible = false;
                        nouserf.Visible = true;
                        conn.Close();
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                nouserf.Visible = false;
                ruserid.Visible = false;
            }
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            string usd = textBox2.Text;
            int rcd = int.Parse(textBox3.Text);
            string query = "select * from Login where UserID=@UserID and RecoveryCode=@RecoveryCode";
            string qr = "";
            SqlConnection conn = null;
            try
            {
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", usd);
                cmd.Parameters.AddWithValue("@RecoveryCode", rcd);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    if (pm.Visible == true)
                    {
                        conn.Close();
                        qr = "Update Login SET Password=@Password WHERE UserID=@UserID";
                        conn.Open();
                        cmd = new SqlCommand(qr, conn);
                        cmd.Parameters.AddWithValue("@Password", textBox4.Text);
                        cmd.Parameters.AddWithValue("@UserID", usd);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("sucessfully updated");
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password Doesn't Match");
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Details!");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if(textBox5.TextLength>0)
            {
                if (textBox4.Text == textBox5.Text)
                {
                    pm.Visible = true;
                    pnm.Visible = false;
                }
                else
                {
                    pm.Visible = false;
                    pnm.Visible = true;
                }
            }
            else
            {
                pm.Visible = false;
                pnm.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           textBox4.UseSystemPasswordChar = false;
            button2.Visible = true;
            button1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnm_Click(object sender, EventArgs e)
        {

        }

        private void pm_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.UseSystemPasswordChar = true;
            button2.Visible = false;
            button1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            this.Hide();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
