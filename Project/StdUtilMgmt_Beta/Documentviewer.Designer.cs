namespace StdUtilMgmt_Beta
{
    partial class Documentviewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Documentviewer));
            this.DgvDocuments = new System.Windows.Forms.DataGridView();
            this.Btnopen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDocuments
            // 
            this.DgvDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDocuments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDocuments.Location = new System.Drawing.Point(32, 96);
            this.DgvDocuments.Margin = new System.Windows.Forms.Padding(2);
            this.DgvDocuments.Name = "DgvDocuments";
            this.DgvDocuments.RowHeadersWidth = 51;
            this.DgvDocuments.RowTemplate.Height = 24;
            this.DgvDocuments.Size = new System.Drawing.Size(905, 382);
            this.DgvDocuments.TabIndex = 0;
            // 
            // Btnopen
            // 
            this.Btnopen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Btnopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnopen.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnopen.ForeColor = System.Drawing.Color.White;
            this.Btnopen.Location = new System.Drawing.Point(43, 507);
            this.Btnopen.Margin = new System.Windows.Forms.Padding(2);
            this.Btnopen.Name = "Btnopen";
            this.Btnopen.Size = new System.Drawing.Size(105, 49);
            this.Btnopen.TabIndex = 1;
            this.Btnopen.Text = "Open";
            this.Btnopen.UseVisualStyleBackColor = true;
            this.Btnopen.Click += new System.EventHandler(this.Btnopen_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(904, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 34);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Documentviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(972, 585);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btnopen);
            this.Controls.Add(this.DgvDocuments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Documentviewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentviewer";
            this.Load += new System.EventHandler(this.Documentviewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocuments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDocuments;
        private System.Windows.Forms.Button Btnopen;
        private System.Windows.Forms.Button button1;
    }
}