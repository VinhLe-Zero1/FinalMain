namespace T_benhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbNgayKham = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_thongbao = new System.Windows.Forms.Button();
            this.thongbao = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dando = new System.Windows.Forms.TextBox();
            this.donthuoc = new System.Windows.Forms.TextBox();
            this.chuandoan = new System.Windows.Forms.TextBox();
            this.maso = new System.Windows.Forms.TextBox();
            this.luu = new System.Windows.Forms.Button();
            this.lbPhongGio = new System.Windows.Forms.Label();
            this.lbBacSi = new System.Windows.Forms.Label();
            this.lbChuyenKhoa = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNgayKham
            // 
            this.lbNgayKham.Font = new System.Drawing.Font("Calibri", 18F);
            this.lbNgayKham.ForeColor = System.Drawing.Color.Black;
            this.lbNgayKham.Image = ((System.Drawing.Image)(resources.GetObject("lbNgayKham.Image")));
            this.lbNgayKham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNgayKham.Location = new System.Drawing.Point(35, 40);
            this.lbNgayKham.Name = "lbNgayKham";
            this.lbNgayKham.Size = new System.Drawing.Size(189, 32);
            this.lbNgayKham.TabIndex = 2;
            this.lbNgayKham.Text = "ID bệnh nhân:";
            this.lbNgayKham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.b_thongbao);
            this.groupBox1.Controls.Add(this.thongbao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dando);
            this.groupBox1.Controls.Add(this.donthuoc);
            this.groupBox1.Controls.Add(this.chuandoan);
            this.groupBox1.Controls.Add(this.maso);
            this.groupBox1.Controls.Add(this.luu);
            this.groupBox1.Controls.Add(this.lbPhongGio);
            this.groupBox1.Controls.Add(this.lbBacSi);
            this.groupBox1.Controls.Add(this.lbChuyenKhoa);
            this.groupBox1.Controls.Add(this.lbNgayKham);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBox1.Location = new System.Drawing.Point(-1, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 451);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // b_thongbao
            // 
            this.b_thongbao.AllowDrop = true;
            this.b_thongbao.BackColor = System.Drawing.Color.GhostWhite;
            this.b_thongbao.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.b_thongbao.FlatAppearance.BorderSize = 0;
            this.b_thongbao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.b_thongbao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_thongbao.ForeColor = System.Drawing.Color.DodgerBlue;
            this.b_thongbao.Location = new System.Drawing.Point(254, 179);
            this.b_thongbao.Margin = new System.Windows.Forms.Padding(2);
            this.b_thongbao.Name = "b_thongbao";
            this.b_thongbao.Size = new System.Drawing.Size(72, 29);
            this.b_thongbao.TabIndex = 50;
            this.b_thongbao.Text = "Trở về";
            this.b_thongbao.UseVisualStyleBackColor = false;
            this.b_thongbao.Visible = false;
            this.b_thongbao.Click += new System.EventHandler(this.b_thongbao_Click);
            // 
            // thongbao
            // 
            this.thongbao.ActiveLinkColor = System.Drawing.Color.PapayaWhip;
            this.thongbao.BackColor = System.Drawing.Color.DodgerBlue;
            this.thongbao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thongbao.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.thongbao.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.thongbao.LinkColor = System.Drawing.Color.GhostWhite;
            this.thongbao.Location = new System.Drawing.Point(188, 112);
            this.thongbao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thongbao.Name = "thongbao";
            this.thongbao.Size = new System.Drawing.Size(210, 117);
            this.thongbao.TabIndex = 49;
            this.thongbao.TabStop = true;
            this.thongbao.Text = "Bạn đã nhập sai. Vui lòng nhập lại! ";
            this.thongbao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.thongbao.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(40, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 1);
            this.label5.TabIndex = 39;
            this.label5.Text = "label5";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1, 384);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 1);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // dando
            // 
            this.dando.BackColor = System.Drawing.Color.White;
            this.dando.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dando.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dando.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dando.Location = new System.Drawing.Point(348, 251);
            this.dando.Multiline = true;
            this.dando.Name = "dando";
            this.dando.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dando.Size = new System.Drawing.Size(231, 92);
            this.dando.TabIndex = 4;
            // 
            // donthuoc
            // 
            this.donthuoc.BackColor = System.Drawing.Color.White;
            this.donthuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.donthuoc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donthuoc.ForeColor = System.Drawing.SystemColors.Desktop;
            this.donthuoc.Location = new System.Drawing.Point(40, 251);
            this.donthuoc.Multiline = true;
            this.donthuoc.Name = "donthuoc";
            this.donthuoc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.donthuoc.Size = new System.Drawing.Size(231, 92);
            this.donthuoc.TabIndex = 3;
            // 
            // chuandoan
            // 
            this.chuandoan.BackColor = System.Drawing.Color.White;
            this.chuandoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chuandoan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuandoan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chuandoan.Location = new System.Drawing.Point(350, 80);
            this.chuandoan.Multiline = true;
            this.chuandoan.Name = "chuandoan";
            this.chuandoan.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.chuandoan.Size = new System.Drawing.Size(229, 105);
            this.chuandoan.TabIndex = 2;
            this.chuandoan.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // maso
            // 
            this.maso.BackColor = System.Drawing.Color.LightSteelBlue;
            this.maso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maso.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maso.ForeColor = System.Drawing.SystemColors.Desktop;
            this.maso.Location = new System.Drawing.Point(40, 76);
            this.maso.Name = "maso";
            this.maso.Size = new System.Drawing.Size(231, 20);
            this.maso.TabIndex = 1;
            this.maso.TextChanged += new System.EventHandler(this.maso_TextChanged);
            // 
            // luu
            // 
            this.luu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.luu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.luu.FlatAppearance.BorderSize = 0;
            this.luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luu.Location = new System.Drawing.Point(3, 388);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(594, 60);
            this.luu.TabIndex = 18;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = false;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // lbPhongGio
            // 
            this.lbPhongGio.Font = new System.Drawing.Font("Calibri", 18F);
            this.lbPhongGio.Image = ((System.Drawing.Image)(resources.GetObject("lbPhongGio.Image")));
            this.lbPhongGio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPhongGio.Location = new System.Drawing.Point(344, 206);
            this.lbPhongGio.Name = "lbPhongGio";
            this.lbPhongGio.Size = new System.Drawing.Size(129, 40);
            this.lbPhongGio.TabIndex = 11;
            this.lbPhongGio.Text = "Dặn dò:";
            this.lbPhongGio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPhongGio.Click += new System.EventHandler(this.lbPhongGio_Click);
            // 
            // lbBacSi
            // 
            this.lbBacSi.Font = new System.Drawing.Font("Calibri", 18F);
            this.lbBacSi.Image = ((System.Drawing.Image)(resources.GetObject("lbBacSi.Image")));
            this.lbBacSi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbBacSi.Location = new System.Drawing.Point(32, 209);
            this.lbBacSi.Name = "lbBacSi";
            this.lbBacSi.Size = new System.Drawing.Size(160, 32);
            this.lbBacSi.TabIndex = 8;
            this.lbBacSi.Text = "Đơn thuốc:";
            this.lbBacSi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbChuyenKhoa
            // 
            this.lbChuyenKhoa.Font = new System.Drawing.Font("Calibri", 18F);
            this.lbChuyenKhoa.Image = ((System.Drawing.Image)(resources.GetObject("lbChuyenKhoa.Image")));
            this.lbChuyenKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbChuyenKhoa.Location = new System.Drawing.Point(342, 35);
            this.lbChuyenKhoa.Name = "lbChuyenKhoa";
            this.lbChuyenKhoa.Size = new System.Drawing.Size(161, 42);
            this.lbChuyenKhoa.TabIndex = 5;
            this.lbChuyenKhoa.Text = "Chẩn đoán:";
            this.lbChuyenKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbChuyenKhoa.Click += new System.EventHandler(this.lbChuyenKhoa_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.GhostWhite;
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(599, 98);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cập nhập bệnh án";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 537);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbNgayKham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPhongGio;
        private System.Windows.Forms.Label lbBacSi;
        private System.Windows.Forms.Label lbChuyenKhoa;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.TextBox chuandoan;
        private System.Windows.Forms.TextBox donthuoc;
        private System.Windows.Forms.TextBox dando;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maso;
        private System.Windows.Forms.Button b_thongbao;
        private System.Windows.Forms.LinkLabel thongbao;
    }
}

