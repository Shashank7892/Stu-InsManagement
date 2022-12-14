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
    public partial class CalculatorForm : Form
    {
        Double value;
        bool operate;
        string operation;
        public CalculatorForm()
        {
            InitializeComponent();
            equation.Text = "";
        }
        

        private void button_click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operate))
            {
                result.Clear();
            }
            operate = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button_operation(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operate = true;
            equation.Text = value + operation;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            equation.Text = "";
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            equation.Text = value + operation + result.Text;
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            result.Text = "";
        }
    }
}
