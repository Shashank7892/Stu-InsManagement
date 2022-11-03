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
    public partial class GamesForm : Form
    {
        public GamesForm()
        {

            InitializeComponent();
            Reset();
            

            
        }
        public void setval()
        {
            GameDef.val1 = 0;
            GameDef.val2 = 0;
            GameDef.val3 = 0;
            GameDef.val4 = 0;
            GameDef.val5 = 0;
            GameDef.val6 = 0;
            GameDef.val7 = 0;
            GameDef.val8 = 0;
            GameDef.val9 = 0;
            GameDef.count = 4;
            Random r = new Random();
            int a = r.Next(1, 3);
            int b = r.Next(3, 5);
            int c = r.Next(5, 8);
            int d = r.Next(8, 10);
            if (a == 1)
            {
                GameDef.val1 = 1;
            }
            else if (a == 2)
            {
                GameDef.val2 = 1;
            }          
            int v= 0;
            if (b == 3)
            {
                GameDef.val3 = 1;
            }
            else if (b == 4)
            {
                GameDef.val4 = 1;
            }
            v = 1;
            if (c == 5)
            {
                GameDef.val5 = 1;
            }
            else if (c == 6)
            {
                GameDef.val6 = 1;
            }
            else if (c == 7)
            {
                GameDef.val7 = 1;
            }
            v = 0;
            if (d == 8)
            {
                GameDef.val8 = 1;
            }
            else if (d == 9)
            {
                GameDef.val9 = 1;
            }
        }

        public void Reset()
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            setval();
        }

        private void GamesForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (GameDef.val1 == 1)
                {
                button1.BackColor = Color.Red;
                if(MessageBox.Show("Game OVER, Do you want to Continue?", "Message", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    Reset();
                }
                else
                {
                    this.Close();
                }
               
                }
                else
                {
                    button1.BackColor = Color.Green;
                    GameDef.count -= 1;
                if (GameDef.count == 0) {
                    if (MessageBox.Show("YOU WON!!! , Do you want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Reset();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                    
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GameDef.val2 == 1)
            {
                button2.BackColor = Color.Red;
                if (MessageBox.Show("Game OVER, Do you want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Reset();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                button2.BackColor = Color.Green;
                GameDef.count -= 1;
                if (GameDef.count == 0) {
                    if (MessageBox.Show("YOU WON!!! , Do you want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Reset();
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (GameDef.val3 == 1)
            {
                button3.BackColor = Color.Red;
                if (MessageBox.Show("Game OVER, Do you want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Reset();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                button3.BackColor = Color.Green;
                GameDef.count -= 1;
                if (GameDef.count == 0) {
                    if (MessageBox.Show("YOU WON!!! , Do you want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Reset();
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (GameDef.val4 == 1)
            {
                button4.BackColor = Color.Red;
                if (MessageBox.Show("Game OVER, Do you want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Reset();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                button4.BackColor = Color.Green;
                GameDef.count -= 1;
                if (GameDef.count == 0) {
                    if (MessageBox.Show("YOU WON!!! , Do you want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Reset();
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (GameDef.val5 == 1)
            {
                button5.BackColor = Color.Red;
                if (MessageBox.Show("Game OVER, Do you want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Reset();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                button5.BackColor = Color.Green;
                GameDef.count -= 1;
                if (GameDef.count == 0) {
                    if (MessageBox.Show("YOU WON!!! , Do you want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Reset();
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (GameDef.val6 == 1)
            {
                button6.BackColor = Color.Red;
                if (MessageBox.Show("Game OVER, Do you want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Reset();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                button6.BackColor = Color.Green;
                GameDef.count -= 1;
                if (GameDef.count == 0) {
                    if (MessageBox.Show("YOU WON!!! , Do you want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Reset();
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (GameDef.val7 == 1)
            {
                button7.BackColor = Color.Red;
                if (MessageBox.Show("Game OVER, Do you want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Reset();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                button7.BackColor = Color.Green;
                GameDef.count -= 1;
                if (GameDef.count == 0) {
                    if (MessageBox.Show("YOU WON!!! , Do you want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Reset();
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (GameDef.val8 == 1)
            {
                button8.BackColor = Color.Red;
                if (MessageBox.Show("Game OVER, Do you want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Reset();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                button8.BackColor = Color.Green;
                GameDef.count -= 1;
                if (GameDef.count == 0) {
                    if (MessageBox.Show("YOU WON!!! , Do you want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Reset();
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (GameDef.val9 == 1)
            {
                button9.BackColor = Color.Red;
                if (MessageBox.Show("Game OVER, Do you want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Reset();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                button9.BackColor = Color.Green;
                GameDef.count -= 1;
                if (GameDef.count == 0) {
                    if (MessageBox.Show("YOU WON!!! , Do you want to Continue?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Reset();
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are about 4 LandMines placed in the random locations, so Choose the other remaining Locations with your super natural senses without hiting the Landmine, if your successful for 4 times You Won else You Lose! ","INSTRUCTIONS");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DEVELOPED BY THARUN AND SHASHANK!","ABOUT");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
