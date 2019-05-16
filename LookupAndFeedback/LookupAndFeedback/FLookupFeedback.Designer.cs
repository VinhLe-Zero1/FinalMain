namespace LookupAndFeedback
{
    partial class FLookupFeedback
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
            this.LookupBookingBtn = new System.Windows.Forms.Button();
            this.LookupHisBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // LookupBookingBtn
            // 
            this.LookupBookingBtn.Image = global::LookupAndFeedback.Properties.Resources.paperwork_512;
            this.LookupBookingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LookupBookingBtn.Location = new System.Drawing.Point(216, 30);
            this.LookupBookingBtn.Name = "LookupBookingBtn";
            this.LookupBookingBtn.Size = new System.Drawing.Size(209, 64);
            this.LookupBookingBtn.TabIndex = 3;
            this.LookupBookingBtn.Text = "Tra cứu lịch khám đã đặt";
            this.LookupBookingBtn.UseVisualStyleBackColor = true;
            this.LookupBookingBtn.Click += new System.EventHandler(this.LookupBookingBtn_Click);
            // 
            // LookupHisBtn
            // 
            this.LookupHisBtn.Image = global::LookupAndFeedback.Properties.Resources.paperwork_512;
            this.LookupHisBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LookupHisBtn.Location = new System.Drawing.Point(216, 134);
            this.LookupHisBtn.Name = "LookupHisBtn";
            this.LookupHisBtn.Size = new System.Drawing.Size(209, 64);
            this.LookupHisBtn.TabIndex = 2;
            this.LookupHisBtn.Text = "Tra cứu lịch sử khám bệnh";
            this.LookupHisBtn.UseVisualStyleBackColor = true;
            this.LookupHisBtn.Click += new System.EventHandler(this.LookupHisBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LookupAndFeedback.Properties.Resources.user_circle_1048392;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(18, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 139);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FLookupFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 227);
            this.Controls.Add(this.LookupBookingBtn);
            this.Controls.Add(this.LookupHisBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FLookupFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu lịch khám bệnh và Nhận xét";
            this.Load += new System.EventHandler(this.FLookupFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LookupHisBtn;
        private System.Windows.Forms.Button LookupBookingBtn;
    }
}

