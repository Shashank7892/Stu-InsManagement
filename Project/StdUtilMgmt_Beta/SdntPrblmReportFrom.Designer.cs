
namespace StdUtilMgmt_Beta
{
    partial class SdntPrblmReportFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SdntPrblmReportFrom));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Comboselect = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Report_btn = new System.Windows.Forms.Button();
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Monotype Corsiva", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(31, 112);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(384, 31);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Do you want to Reveal Your Identity?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Comboselect
            // 
            this.Comboselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comboselect.FormattingEnabled = true;
            this.Comboselect.Items.AddRange(new object[] {
            "Suggestion",
            "Problem",
            "Harassment",
            "Request",
            "Others"});
            this.Comboselect.Location = new System.Drawing.Point(106, 182);
            this.Comboselect.Name = "Comboselect";
            this.Comboselect.Size = new System.Drawing.Size(225, 26);
            this.Comboselect.TabIndex = 1;
            this.Comboselect.Text = "Select";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(44, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 26);
            this.textBox1.TabIndex = 2;
            // 
            // Report_btn
            // 
            this.Report_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.Report_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report_btn.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report_btn.ForeColor = System.Drawing.Color.White;
            this.Report_btn.Location = new System.Drawing.Point(162, 318);
            this.Report_btn.Name = "Report_btn";
            this.Report_btn.Size = new System.Drawing.Size(108, 40);
            this.Report_btn.TabIndex = 3;
            this.Report_btn.Text = "Report";
            this.Report_btn.UseVisualStyleBackColor = true;
            this.Report_btn.Click += new System.EventHandler(this.Report_btn_Click);
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dashboard_btn.BackgroundImage")));
            this.Dashboard_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard_btn.Location = new System.Drawing.Point(402, 12);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(39, 34);
            this.Dashboard_btn.TabIndex = 4;
            this.Dashboard_btn.UseVisualStyleBackColor = true;
            this.Dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // SdntPrblmReportFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(453, 423);
            this.Controls.Add(this.Dashboard_btn);
            this.Controls.Add(this.Report_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Comboselect);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SdntPrblmReportFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SdntPrblmReportFrom";
            this.Load += new System.EventHandler(this.SdntPrblmReportFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox Comboselect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Report_btn;
        private System.Windows.Forms.Button Dashboard_btn;
    }
}