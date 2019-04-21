namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchHisBtn = new System.Windows.Forms.Button();
            this.searchbookBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Minh Hoàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.user_circle_1048392;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(119, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 228);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // searchHisBtn
            // 
            this.searchHisBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.searchHisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchHisBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchHisBtn.Image = global::WindowsFormsApp1.Properties.Resources.paperwork_512;
            this.searchHisBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchHisBtn.Location = new System.Drawing.Point(418, 158);
            this.searchHisBtn.Name = "searchHisBtn";
            this.searchHisBtn.Size = new System.Drawing.Size(334, 82);
            this.searchHisBtn.TabIndex = 3;
            this.searchHisBtn.Text = "Tra cứu lịch khám chữa bệnh";
            this.searchHisBtn.UseVisualStyleBackColor = false;
            this.searchHisBtn.Click += new System.EventHandler(this.searchHisBtn_Click);
            // 
            // searchbookBtn
            // 
            this.searchbookBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.searchbookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchbookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbookBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbookBtn.Image = global::WindowsFormsApp1.Properties.Resources.paperwork_512;
            this.searchbookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbookBtn.Location = new System.Drawing.Point(418, 24);
            this.searchbookBtn.Name = "searchbookBtn";
            this.searchbookBtn.Size = new System.Drawing.Size(335, 77);
            this.searchbookBtn.TabIndex = 2;
            this.searchbookBtn.Text = "Tra cứu lịch sử khám bệnh";
            this.searchbookBtn.UseVisualStyleBackColor = false;
            this.searchbookBtn.Click += new System.EventHandler(this.searchbookBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.back_button_clipart_1;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backBtn.Size = new System.Drawing.Size(80, 80);
            this.backBtn.TabIndex = 1;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchHisBtn);
            this.Controls.Add(this.searchbookBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "Form1";
            this.Text = "Health Care System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button searchbookBtn;
        private System.Windows.Forms.Button searchHisBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

