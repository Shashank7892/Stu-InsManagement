
namespace StdUtilMgmt_Beta
{
    partial class BrowserForm
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
            System.Windows.Forms.Button home_btn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserForm));
            this.goback_btn = new System.Windows.Forms.Button();
            this.gofront_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.Encyclopedia_btn = new System.Windows.Forms.Button();
            this.Wikipedia_btn = new System.Windows.Forms.Button();
            this.GoogleScholar_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button3 = new System.Windows.Forms.Button();
            home_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // home_btn
            // 
            home_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home_btn.BackgroundImage")));
            home_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            home_btn.FlatAppearance.BorderSize = 0;
            home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            home_btn.ForeColor = System.Drawing.Color.White;
            home_btn.Location = new System.Drawing.Point(328, 17);
            home_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            home_btn.Name = "home_btn";
            home_btn.Size = new System.Drawing.Size(59, 44);
            home_btn.TabIndex = 4;
            home_btn.UseVisualStyleBackColor = true;
            home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // goback_btn
            // 
            this.goback_btn.FlatAppearance.BorderSize = 0;
            this.goback_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goback_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goback_btn.ForeColor = System.Drawing.Color.White;
            this.goback_btn.Location = new System.Drawing.Point(47, 17);
            this.goback_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.goback_btn.Name = "goback_btn";
            this.goback_btn.Size = new System.Drawing.Size(81, 53);
            this.goback_btn.TabIndex = 2;
            this.goback_btn.Text = "<";
            this.goback_btn.UseVisualStyleBackColor = true;
            this.goback_btn.Click += new System.EventHandler(this.goback_btn_Click);
            // 
            // gofront_btn
            // 
            this.gofront_btn.FlatAppearance.BorderSize = 0;
            this.gofront_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gofront_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gofront_btn.ForeColor = System.Drawing.Color.White;
            this.gofront_btn.Location = new System.Drawing.Point(172, 17);
            this.gofront_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gofront_btn.Name = "gofront_btn";
            this.gofront_btn.Size = new System.Drawing.Size(81, 53);
            this.gofront_btn.TabIndex = 3;
            this.gofront_btn.Text = ">";
            this.gofront_btn.UseVisualStyleBackColor = true;
            this.gofront_btn.Click += new System.EventHandler(this.gofront_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh_btn.BackgroundImage")));
            this.refresh_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refresh_btn.FlatAppearance.BorderSize = 0;
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Location = new System.Drawing.Point(461, 17);
            this.refresh_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(56, 48);
            this.refresh_btn.TabIndex = 5;
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // Encyclopedia_btn
            // 
            this.Encyclopedia_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.Encyclopedia_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encyclopedia_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encyclopedia_btn.ForeColor = System.Drawing.Color.White;
            this.Encyclopedia_btn.Location = new System.Drawing.Point(119, 208);
            this.Encyclopedia_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Encyclopedia_btn.Name = "Encyclopedia_btn";
            this.Encyclopedia_btn.Size = new System.Drawing.Size(499, 293);
            this.Encyclopedia_btn.TabIndex = 6;
            this.Encyclopedia_btn.Text = "Encyclopedia";
            this.Encyclopedia_btn.UseVisualStyleBackColor = true;
            this.Encyclopedia_btn.Click += new System.EventHandler(this.Encyclopedia_btn_Click);
            // 
            // Wikipedia_btn
            // 
            this.Wikipedia_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.Wikipedia_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wikipedia_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wikipedia_btn.ForeColor = System.Drawing.Color.White;
            this.Wikipedia_btn.Location = new System.Drawing.Point(695, 208);
            this.Wikipedia_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Wikipedia_btn.Name = "Wikipedia_btn";
            this.Wikipedia_btn.Size = new System.Drawing.Size(515, 293);
            this.Wikipedia_btn.TabIndex = 7;
            this.Wikipedia_btn.Text = "Wikipedia";
            this.Wikipedia_btn.UseVisualStyleBackColor = true;
            this.Wikipedia_btn.Click += new System.EventHandler(this.Wikipedia_btn_Click);
            // 
            // GoogleScholar_btn
            // 
            this.GoogleScholar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.GoogleScholar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoogleScholar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoogleScholar_btn.ForeColor = System.Drawing.Color.White;
            this.GoogleScholar_btn.Location = new System.Drawing.Point(1267, 208);
            this.GoogleScholar_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoogleScholar_btn.Name = "GoogleScholar_btn";
            this.GoogleScholar_btn.Size = new System.Drawing.Size(504, 293);
            this.GoogleScholar_btn.TabIndex = 10;
            this.GoogleScholar_btn.Text = "Google Scholar";
            this.GoogleScholar_btn.UseVisualStyleBackColor = true;
            this.GoogleScholar_btn.Click += new System.EventHandler(this.GoogleScholar_btn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(2485, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(-1, 89);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(2587, 853);
            this.webBrowser1.TabIndex = 16;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1876, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 47);
            this.button3.TabIndex = 18;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1942, 906);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoogleScholar_btn);
            this.Controls.Add(this.Wikipedia_btn);
            this.Controls.Add(this.Encyclopedia_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(home_btn);
            this.Controls.Add(this.gofront_btn);
            this.Controls.Add(this.goback_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BrowserForm";
            this.Text = "BrowserForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Browser_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button goback_btn;
        private System.Windows.Forms.Button gofront_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button Encyclopedia_btn;
        private System.Windows.Forms.Button Wikipedia_btn;
        private System.Windows.Forms.Button GoogleScholar_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button3;
    }
}