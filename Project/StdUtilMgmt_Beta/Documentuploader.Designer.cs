namespace StdUtilMgmt_Beta
{
    partial class Documentuploader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Documentuploader));
            this.Filepath = new System.Windows.Forms.Label();
            this.Browsebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.SelectStandard = new System.Windows.Forms.ComboBox();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.Openbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // Filepath
            // 
            this.Filepath.AutoSize = true;
            this.Filepath.BackColor = System.Drawing.Color.Black;
            this.Filepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filepath.ForeColor = System.Drawing.Color.White;
            this.Filepath.Location = new System.Drawing.Point(60, 121);
            this.Filepath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Filepath.Name = "Filepath";
            this.Filepath.Size = new System.Drawing.Size(40, 18);
            this.Filepath.TabIndex = 0;
            this.Filepath.Text = "path";
            // 
            // Browsebtn
            // 
            this.Browsebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Browsebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browsebtn.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browsebtn.ForeColor = System.Drawing.Color.White;
            this.Browsebtn.Location = new System.Drawing.Point(653, 106);
            this.Browsebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Browsebtn.Name = "Browsebtn";
            this.Browsebtn.Size = new System.Drawing.Size(104, 33);
            this.Browsebtn.TabIndex = 1;
            this.Browsebtn.Text = "Browse";
            this.Browsebtn.UseVisualStyleBackColor = true;
            this.Browsebtn.Click += new System.EventHandler(this.Browsebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.ForeColor = System.Drawing.Color.White;
            this.Savebtn.Location = new System.Drawing.Point(705, 158);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(132, 34);
            this.Savebtn.TabIndex = 2;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // SelectStandard
            // 
            this.SelectStandard.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectStandard.FormattingEnabled = true;
            this.SelectStandard.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.SelectStandard.Location = new System.Drawing.Point(787, 106);
            this.SelectStandard.Margin = new System.Windows.Forms.Padding(2);
            this.SelectStandard.Name = "SelectStandard";
            this.SelectStandard.Size = new System.Drawing.Size(102, 30);
            this.SelectStandard.TabIndex = 3;
            this.SelectStandard.Text = "Standard";
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocuments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.Location = new System.Drawing.Point(36, 220);
            this.dgvDocuments.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.RowHeadersWidth = 51;
            this.dgvDocuments.RowTemplate.Height = 24;
            this.dgvDocuments.Size = new System.Drawing.Size(873, 286);
            this.dgvDocuments.TabIndex = 4;
            // 
            // Openbtn
            // 
            this.Openbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Openbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Openbtn.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Openbtn.ForeColor = System.Drawing.Color.White;
            this.Openbtn.Location = new System.Drawing.Point(36, 529);
            this.Openbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Openbtn.Name = "Openbtn";
            this.Openbtn.Size = new System.Drawing.Size(139, 46);
            this.Openbtn.TabIndex = 5;
            this.Openbtn.Text = "Open";
            this.Openbtn.UseVisualStyleBackColor = true;
            this.Openbtn.Click += new System.EventHandler(this.Openbtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(895, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 32);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Documentuploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(957, 598);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Openbtn);
            this.Controls.Add(this.dgvDocuments);
            this.Controls.Add(this.SelectStandard);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Browsebtn);
            this.Controls.Add(this.Filepath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Documentuploader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentuploader";
            this.Load += new System.EventHandler(this.Documentuploader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Filepath;
        private System.Windows.Forms.Button Browsebtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.ComboBox SelectStandard;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.Button Openbtn;
        private System.Windows.Forms.Button button1;
    }
}