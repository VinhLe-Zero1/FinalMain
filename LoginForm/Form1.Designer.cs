namespace LoginForm
{
    partial class formLogin
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
            this.tableForm = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.regBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.boxPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.boxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.forgetBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableForm.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableForm
            // 
            this.tableForm.BackColor = System.Drawing.Color.Transparent;
            this.tableForm.ColumnCount = 2;
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.Controls.Add(this.panelTop, 0, 0);
            this.tableForm.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableForm.Controls.Add(this.pictureBox2, 0, 1);
            this.tableForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableForm.Location = new System.Drawing.Point(0, 0);
            this.tableForm.Name = "tableForm";
            this.tableForm.RowCount = 2;
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.997743F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.00226F));
            this.tableForm.Size = new System.Drawing.Size(700, 476);
            this.tableForm.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.AutoSize = true;
            this.panelTop.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tableForm.SetColumnSpan(this.panelTop, 2);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelTop.Size = new System.Drawing.Size(700, 30);
            this.panelTop.TabIndex = 0;
            this.panelTop.WrapContents = false;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::LoginForm.Properties.Resources.CloseIcon5;
            this.btnClose.Location = new System.Drawing.Point(669, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.regBtn, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnLogin, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.forgetBtn, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(353, 36);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.29748F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.551487F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(344, 437);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // regBtn
            // 
            this.regBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.regBtn.Location = new System.Drawing.Point(95, 367);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(153, 23);
            this.regBtn.TabIndex = 8;
            this.regBtn.Text = "Tạo tài khoản";
            this.regBtn.UseVisualStyleBackColor = false;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.65497F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.34503F));
            this.tableLayoutPanel4.Controls.Add(this.boxPwd, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 253);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(338, 58);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // boxPwd
            // 
            this.boxPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxPwd.Location = new System.Drawing.Point(118, 19);
            this.boxPwd.Margin = new System.Windows.Forms.Padding(0);
            this.boxPwd.Name = "boxPwd";
            this.boxPwd.PasswordChar = '*';
            this.boxPwd.Size = new System.Drawing.Size(197, 20);
            this.boxPwd.TabIndex = 1;
            this.boxPwd.Click += new System.EventHandler(this.boxPwd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LoginForm.Properties.Resources.trans2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.65497F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.34503F));
            this.tableLayoutPanel3.Controls.Add(this.boxLogin, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 189);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(338, 58);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // boxLogin
            // 
            this.boxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxLogin.Location = new System.Drawing.Point(118, 19);
            this.boxLogin.Margin = new System.Windows.Forms.Padding(0);
            this.boxLogin.Name = "boxLogin";
            this.boxLogin.Size = new System.Drawing.Size(197, 20);
            this.boxLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.Location = new System.Drawing.Point(95, 324);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(153, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // forgetBtn
            // 
            this.forgetBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.forgetBtn.FlatAppearance.BorderSize = 0;
            this.forgetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgetBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.forgetBtn.Location = new System.Drawing.Point(235, 407);
            this.forgetBtn.Name = "forgetBtn";
            this.forgetBtn.Size = new System.Drawing.Size(106, 23);
            this.forgetBtn.TabIndex = 9;
            this.forgetBtn.Text = "Quên mật khẩu";
            this.forgetBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::LoginForm.Properties.Resources.Front;
            this.pictureBox2.Location = new System.Drawing.Point(3, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 437);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::LoginForm.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(700, 476);
            this.Controls.Add(this.tableForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formLogin";
            this.Text = "Form1";
            this.tableForm.ResumeLayout(false);
            this.tableForm.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableForm;
        private System.Windows.Forms.FlowLayoutPanel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox boxLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox boxPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button forgetBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

