using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StdUtilMgmt_Beta
{
    public partial class TeachersDashboardForm : Form
    {
        public TeachersDashboardForm()
        {
            InitializeComponent();
        }

        private void StudentPolicyTool_btn_Click(object sender, EventArgs e)
        {
            SdntPolicyToolForm f = new SdntPolicyToolForm();
            this.Hide();
            f.Show();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            this.Hide();
            f.Show();
        }

        private void StudentStatistics_btn_Click(object sender, EventArgs e)
        {
            SdntStatForm f = new SdntStatForm();
            this.Hide();
            f.Show();
        }

        private void StudentConfidentialData_btn_Click(object sender, EventArgs e)
        {
            SdntConfDataForm f = new SdntConfDataForm();
            this.Hide();
            f.Show();
        }

        private void Browser_btn_Click(object sender, EventArgs e)
        {
            BrowserForm f = new BrowserForm();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SdntReportViewerForm f = new SdntReportViewerForm();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlertsUpdateForm f = new AlertsUpdateForm();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CGPAForm f = new CGPAForm();
            this.Hide();
            f.Show();
        }

        private void Calculator_btn_Click(object sender, EventArgs e)
        {
            CalculatorForm f = new CalculatorForm();
            f.Show();
        }

        private void Games_btn_Click(object sender, EventArgs e)
        {
            GamesForm f = new GamesForm();           
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SdntApprovalfm f = new SdntApprovalfm();
            this.Hide();
            f.Show();
        }

        private void PdfReader_btn_Click(object sender, EventArgs e)
        {
           

        }

        private void PdfFileUploader_btn_Click(object sender, EventArgs e)
        {
            Documentuploader f = new Documentuploader();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageSdnt f = new ManageSdnt();
            this.Hide();
            f.Show();
        }
    }
}
