namespace LookupAndFeedback
{
    partial class FLookupHis
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
            this.CmtBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DonthuocTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.IdRB = new System.Windows.Forms.RadioButton();
            this.PreRB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // CmtBtn
            // 
            this.CmtBtn.Image = global::LookupAndFeedback.Properties.Resources.write_black;
            this.CmtBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmtBtn.Location = new System.Drawing.Point(425, 15);
            this.CmtBtn.Name = "CmtBtn";
            this.CmtBtn.Size = new System.Drawing.Size(80, 41);
            this.CmtBtn.TabIndex = 3;
            this.CmtBtn.Text = "Nhận xét";
            this.CmtBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmtBtn.UseVisualStyleBackColor = true;
            this.CmtBtn.Click += new System.EventHandler(this.CmtBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LookupAndFeedback.Properties.Resources.user_circle_1048392;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(511, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(262, 15);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 41);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Tìm kiếm";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 309);
            this.panel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(423, 309);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(12, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 41);
            this.panel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Từ khóa:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DonthuocTxt);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(444, 228);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(199, 91);
            this.panel5.TabIndex = 9;
            // 
            // DonthuocTxt
            // 
            this.DonthuocTxt.Location = new System.Drawing.Point(3, 16);
            this.DonthuocTxt.Multiline = true;
            this.DonthuocTxt.Name = "DonthuocTxt";
            this.DonthuocTxt.ReadOnly = true;
            this.DonthuocTxt.Size = new System.Drawing.Size(196, 74);
            this.DonthuocTxt.TabIndex = 1;
            this.DonthuocTxt.TextChanged += new System.EventHandler(this.DonthuocTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn thuốc:";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(343, 15);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(76, 41);
            this.RefreshBtn.TabIndex = 10;
            this.RefreshBtn.Text = "Tải lại";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID:";
            // 
            // IDTxt
            // 
            this.IDTxt.Location = new System.Drawing.Point(474, 202);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.ReadOnly = true;
            this.IDTxt.Size = new System.Drawing.Size(169, 20);
            this.IDTxt.TabIndex = 12;
            this.IDTxt.TextChanged += new System.EventHandler(this.IDTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dặn dò:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(447, 343);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(195, 60);
            this.textBox2.TabIndex = 15;
            // 
            // IdRB
            // 
            this.IdRB.AutoSize = true;
            this.IdRB.Location = new System.Drawing.Point(29, 72);
            this.IdRB.Name = "IdRB";
            this.IdRB.Size = new System.Drawing.Size(80, 17);
            this.IdRB.TabIndex = 16;
            this.IdRB.TabStop = true;
            this.IdRB.Text = "Tìm theo ID";
            this.IdRB.UseVisualStyleBackColor = true;
            // 
            // PreRB
            // 
            this.PreRB.AutoSize = true;
            this.PreRB.Location = new System.Drawing.Point(139, 72);
            this.PreRB.Name = "PreRB";
            this.PreRB.Size = new System.Drawing.Size(118, 17);
            this.PreRB.TabIndex = 17;
            this.PreRB.TabStop = true;
            this.PreRB.Text = "Tìm theo đơn thuốc";
            this.PreRB.UseVisualStyleBackColor = true;
            // 
            // FLookupHis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 416);
            this.Controls.Add(this.PreRB);
            this.Controls.Add(this.IdRB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.CmtBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FLookupHis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu lịch sử khám bệnh";
            this.Load += new System.EventHandler(this.FLookupBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmtBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox DonthuocTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton IdRB;
        private System.Windows.Forms.RadioButton PreRB;
    }
}