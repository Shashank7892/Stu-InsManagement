
namespace StdUtilMgmt_Beta
{
    partial class SdntStatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SdntStatForm));
            this.Name_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Notfound_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BrowserCounter = new System.Windows.Forms.Label();
            this.CalculatorCounter = new System.Windows.Forms.Label();
            this.GamesCounter = new System.Windows.Forms.Label();
            this.PdfreaderCounter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.OABrowser = new System.Windows.Forms.Label();
            this.OACalculator = new System.Windows.Forms.Label();
            this.OAGames = new System.Windows.Forms.Label();
            this.OAPdfreader = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.ForeColor = System.Drawing.Color.White;
            this.Name_label.Location = new System.Drawing.Point(146, 189);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(51, 16);
            this.Name_label.TabIndex = 0;
            this.Name_label.Text = "label1";
            this.Name_label.Visible = false;
            this.Name_label.Click += new System.EventHandler(this.Name_label_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(71, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Search_btn
            // 
            this.Search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.Location = new System.Drawing.Point(329, 133);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(95, 32);
            this.Search_btn.TabIndex = 2;
            this.Search_btn.Text = "Find";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Notfound_label
            // 
            this.Notfound_label.AutoSize = true;
            this.Notfound_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notfound_label.ForeColor = System.Drawing.Color.White;
            this.Notfound_label.Location = new System.Drawing.Point(118, 189);
            this.Notfound_label.Name = "Notfound_label";
            this.Notfound_label.Size = new System.Drawing.Size(120, 16);
            this.Notfound_label.TabIndex = 3;
            this.Notfound_label.Text = "User Not Found!";
            this.Notfound_label.Click += new System.EventHandler(this.Notfound_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Browser";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(136, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Calculator";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(358, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Games";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(245, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pdf Reader";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BrowserCounter
            // 
            this.BrowserCounter.AutoSize = true;
            this.BrowserCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowserCounter.ForeColor = System.Drawing.Color.White;
            this.BrowserCounter.Location = new System.Drawing.Point(67, 340);
            this.BrowserCounter.Name = "BrowserCounter";
            this.BrowserCounter.Size = new System.Drawing.Size(57, 20);
            this.BrowserCounter.TabIndex = 8;
            this.BrowserCounter.Text = "label5";
            this.BrowserCounter.Click += new System.EventHandler(this.BrowserCounter_Click);
            // 
            // CalculatorCounter
            // 
            this.CalculatorCounter.AutoSize = true;
            this.CalculatorCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorCounter.ForeColor = System.Drawing.Color.White;
            this.CalculatorCounter.Location = new System.Drawing.Point(158, 340);
            this.CalculatorCounter.Name = "CalculatorCounter";
            this.CalculatorCounter.Size = new System.Drawing.Size(57, 20);
            this.CalculatorCounter.TabIndex = 9;
            this.CalculatorCounter.Text = "label6";
            this.CalculatorCounter.Click += new System.EventHandler(this.CalculatorCounter_Click);
            // 
            // GamesCounter
            // 
            this.GamesCounter.AutoSize = true;
            this.GamesCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamesCounter.ForeColor = System.Drawing.Color.White;
            this.GamesCounter.Location = new System.Drawing.Point(367, 340);
            this.GamesCounter.Name = "GamesCounter";
            this.GamesCounter.Size = new System.Drawing.Size(57, 20);
            this.GamesCounter.TabIndex = 10;
            this.GamesCounter.Text = "label7";
            this.GamesCounter.Click += new System.EventHandler(this.GamesCounter_Click);
            // 
            // PdfreaderCounter
            // 
            this.PdfreaderCounter.AutoSize = true;
            this.PdfreaderCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PdfreaderCounter.ForeColor = System.Drawing.Color.White;
            this.PdfreaderCounter.Location = new System.Drawing.Point(258, 340);
            this.PdfreaderCounter.Name = "PdfreaderCounter";
            this.PdfreaderCounter.Size = new System.Drawing.Size(57, 20);
            this.PdfreaderCounter.TabIndex = 11;
            this.PdfreaderCounter.Text = "label8";
            this.PdfreaderCounter.Click += new System.EventHandler(this.PdfreaderCounter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(580, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(329, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "OVERALL STUDENT\'S STATISTICS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(658, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Browser";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(642, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Calculator";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(666, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Games";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(632, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pdf Reader";
            // 
            // OABrowser
            // 
            this.OABrowser.AutoSize = true;
            this.OABrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OABrowser.ForeColor = System.Drawing.Color.White;
            this.OABrowser.Location = new System.Drawing.Point(763, 209);
            this.OABrowser.Name = "OABrowser";
            this.OABrowser.Size = new System.Drawing.Size(67, 20);
            this.OABrowser.TabIndex = 17;
            this.OABrowser.Text = "label10";
            // 
            // OACalculator
            // 
            this.OACalculator.AutoSize = true;
            this.OACalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OACalculator.ForeColor = System.Drawing.Color.White;
            this.OACalculator.Location = new System.Drawing.Point(763, 263);
            this.OACalculator.Name = "OACalculator";
            this.OACalculator.Size = new System.Drawing.Size(67, 20);
            this.OACalculator.TabIndex = 18;
            this.OACalculator.Text = "label11";
            // 
            // OAGames
            // 
            this.OAGames.AutoSize = true;
            this.OAGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OAGames.ForeColor = System.Drawing.Color.White;
            this.OAGames.Location = new System.Drawing.Point(763, 358);
            this.OAGames.Name = "OAGames";
            this.OAGames.Size = new System.Drawing.Size(67, 20);
            this.OAGames.TabIndex = 19;
            this.OAGames.Text = "label12";
            // 
            // OAPdfreader
            // 
            this.OAPdfreader.AutoSize = true;
            this.OAPdfreader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OAPdfreader.ForeColor = System.Drawing.Color.White;
            this.OAPdfreader.Location = new System.Drawing.Point(763, 313);
            this.OAPdfreader.Name = "OAPdfreader";
            this.OAPdfreader.Size = new System.Drawing.Size(67, 20);
            this.OAPdfreader.TabIndex = 20;
            this.OAPdfreader.Text = "label13";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(877, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 37);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SdntStatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(959, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OAPdfreader);
            this.Controls.Add(this.OAGames);
            this.Controls.Add(this.OACalculator);
            this.Controls.Add(this.OABrowser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PdfreaderCounter);
            this.Controls.Add(this.GamesCounter);
            this.Controls.Add(this.CalculatorCounter);
            this.Controls.Add(this.BrowserCounter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Notfound_label);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Name_label);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SdntStatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SdntStatForm";
            this.Load += new System.EventHandler(this.SdntStatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Label Notfound_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BrowserCounter;
        private System.Windows.Forms.Label CalculatorCounter;
        private System.Windows.Forms.Label GamesCounter;
        private System.Windows.Forms.Label PdfreaderCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label OABrowser;
        private System.Windows.Forms.Label OACalculator;
        private System.Windows.Forms.Label OAGames;
        private System.Windows.Forms.Label OAPdfreader;
        private System.Windows.Forms.Button button1;
    }
}