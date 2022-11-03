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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            imgloc.Visible = false;
            imgloc.Text = "";
        }

        private void Sign_up_btn_Click(object sender, EventArgs e)
        {
            bool checkuser = checkUser();
            if(checkuser == true)
            {
                MessageBox.Show("User Exist");
                UserID_textbox.Text = "";
                Password_textBox.Text = "";
            }
            else
            {
                signUp();
            }
            
        }

        public void signUp()
        {
            int b=0,c=0,p=0,g=0;
            string q= "select * from policyTable";
            string name = Name_textBox.Text;
            string gender = "";
            
            SqlConnection conn = null;
            
                try
                {
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        b = 1;
                    }
                    else
                    {
                        b = 0;
                    }

                    if (dt.Rows[0][1].ToString() == "1")
                    {
                        c = 1;
                    }
                    else
                    {
                        c = 0;
                    }

                    if (dt.Rows[0][2].ToString() == "1")
                    {
                        p = 1;
                    }
                    else
                    {
                        p = 0;
                    }

                    if (dt.Rows[0][3].ToString() == "1")
                    {
                        g = 1;
                    }
                    else
                    {
                        g = 0;
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

            if (Male_radioButton.Checked)
            {
                gender = "Male";
            }
            else if(Female_radioButton.Checked)
            {
                gender = "Female";
            }
            string father = FatherName_textBox.Text;
            string mother = MotherName_textBox.Text;
            string phone = PhNo_textBox.Text;

            string userid = UserID_textbox.Text;
            string password = Password_textBox.Text;
            string standard = Stndcmb.Text;
            Random r = new Random();
            int rc=r.Next(10000, 99999);
                string query = "insert into Login (UserID, Name, DOB, Gender, Father, Mother, Phone, Password, Standard, BrowserCounter, CalculatorCounter, PdfReaderCounter, GamesCounter, BrowserA, CalculatorA, PdfReaderA, GamesA,RecoveryCode, Astatus,Picture) values (@UserID, @Name, '" + dateTimePicker1.Text.ToString() + " ', @Gender, @Father, @Mother, @Phone, @Password, @Standard,0,0,0,0, @BrowserA, @CalculatorA, @PdfReaderA, @GamesA, @RecoveryCode, 0, @Picture)";
                using (Stream stream = File.OpenRead(imgloc.Text))
                {
                    byte[] files = new byte[stream.Length];
                    stream.Read(files, 0, files.Length);
                    conn = null;
                    try
                    {
                        conn = sqlConnect.GetSqlConnect();
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@USerID", userid);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Father", father);
                        cmd.Parameters.AddWithValue("@Mother", mother);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Standard", standard);
                        cmd.Parameters.AddWithValue("@BrowserA", b);
                        cmd.Parameters.AddWithValue("@CalculatorA", c);
                        cmd.Parameters.AddWithValue("@PdfReaderA", p);
                        cmd.Parameters.AddWithValue("@GamesA", g);
                        cmd.Parameters.AddWithValue("@RecoveryCode", rc);
                        cmd.Parameters.AddWithValue("@Picture", files);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(rc+" is Your Recovery Code, Use it when you Forget the Credentials");
                        
                        conn.Close();
                    clear();
                        cgpains();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        conn.Close();
                    }
                }
            
            
            imgloc.Text = "";
            

            // string date = dateTimePicker1.Value.ToString();
            

            
            
        }

        public bool checkUser()
        {
            string user = UserID_textbox.Text;
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
                if(dt.Rows.Count > 0)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

            return check;
        }

        public void cgpains()
        {
            string query= "insert into CGPATable (UserID, CGPA) values (@UserID, @CGPA)";
            string userid = UserID_textbox.Text;
            string cgpa = "Not Updated";
            SqlConnection conn = null;

            try
            {
                conn = sqlConnect.GetSqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@USerID", userid);
                cmd.Parameters.AddWithValue("@CGPA",cgpa);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }


        private void Goto_Login_btn_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            this.Hide();
            f.Show();       
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Male_radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            imgloc.Text = dlg.FileName;
            imgloc.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        void clear()
        {
            Name_textBox.Text = UserID_textbox.Text = Password_textBox.Text = PhNo_textBox.Text = FatherName_textBox.Text = MotherName_textBox.Text = "";
        }
    }
}
