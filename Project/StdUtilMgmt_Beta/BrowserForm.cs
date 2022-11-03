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
    public partial class BrowserForm : Form
    {
        public BrowserForm()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Visible = false;
            
        }

        private void Browser_Load(object sender, EventArgs e)
        {

        }

        private void GOTODASHBOARD_Click(object sender, EventArgs e)
        {
            TeachersDashboardForm f = new TeachersDashboardForm();
            this.Hide();
            f.Show();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void goback_btn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void gofront_btn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            webBrowser1.Navigate("");
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            
        }

        private void Encyclopedia_btn_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            webBrowser1.Navigate("https://www.encyclopedia.com/");
        }

        private void Wikipedia_btn_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            webBrowser1.Navigate("https://www.wikipedia.org/");
        }

        private void GoogleScholar_btn_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            webBrowser1.Navigate("https://scholar.google.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
