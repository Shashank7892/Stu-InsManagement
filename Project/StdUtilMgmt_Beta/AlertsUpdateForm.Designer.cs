
namespace StdUtilMgmt_Beta
{
    partial class AlertsUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertsUpdateForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UpdateAlert_btn = new System.Windows.Forms.Button();
            this.RemoveAlert_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(574, 40);
            this.textBox1.TabIndex = 0;
            // 
            // UpdateAlert_btn
            // 
            this.UpdateAlert_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UpdateAlert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateAlert_btn.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAlert_btn.ForeColor = System.Drawing.Color.White;
            this.UpdateAlert_btn.Location = new System.Drawing.Point(230, 182);
            this.UpdateAlert_btn.Name = "UpdateAlert_btn";
            this.UpdateAlert_btn.Size = new System.Drawing.Size(142, 50);
            this.UpdateAlert_btn.TabIndex = 1;
            this.UpdateAlert_btn.Text = "Update Alert";
            this.UpdateAlert_btn.UseVisualStyleBackColor = true;
            this.UpdateAlert_btn.Click += new System.EventHandler(this.UpdateAlert_btn_Click);
            // 
            // RemoveAlert_btn
            // 
            this.RemoveAlert_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RemoveAlert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveAlert_btn.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveAlert_btn.ForeColor = System.Drawing.Color.White;
            this.RemoveAlert_btn.Location = new System.Drawing.Point(343, 270);
            this.RemoveAlert_btn.Name = "RemoveAlert_btn";
            this.RemoveAlert_btn.Size = new System.Drawing.Size(229, 35);
            this.RemoveAlert_btn.TabIndex = 2;
            this.RemoveAlert_btn.Text = "Remove Current Alert";
            this.RemoveAlert_btn.UseVisualStyleBackColor = true;
            this.RemoveAlert_btn.Click += new System.EventHandler(this.RemoveAlert_btn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(561, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 31);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlertsUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(619, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RemoveAlert_btn);
            this.Controls.Add(this.UpdateAlert_btn);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlertsUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlertsUpdateForm";
            this.Load += new System.EventHandler(this.AlertsUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button UpdateAlert_btn;
        private System.Windows.Forms.Button RemoveAlert_btn;
        private System.Windows.Forms.Button button1;
    }
}