namespace Datlich
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
            this.components = new System.ComponentModel.Container();
            this.Datlich = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMajor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.RadioButton();
            this.Yes = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lbPhongGio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.lbBacSi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbChuyenKhoa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lbNgayKham = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.email1 = new System.Windows.Forms.Label();
            this.mabn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.updateinfor = new System.Windows.Forms.Button();
            this.promote = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Date_panel = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Date_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Datlich
            // 
            this.Datlich.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Datlich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Datlich.Dock = System.Windows.Forms.DockStyle.Top;
            this.Datlich.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Datlich.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datlich.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Datlich.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Datlich.Location = new System.Drawing.Point(0, 0);
            this.Datlich.Name = "Datlich";
            this.Datlich.Size = new System.Drawing.Size(676, 43);
            this.Datlich.TabIndex = 0;
            this.Datlich.Text = "Đặt Lịch Hẹn";
            this.Datlich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.SandyBrown;
            this.Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.Location = new System.Drawing.Point(158, 475);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(515, 43);
            this.Confirm.TabIndex = 18;
            this.Confirm.Text = "Đặt Khám";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.cbMajor);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Confirm);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.No);
            this.groupBox1.Controls.Add(this.Yes);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.lbPhongGio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDoctor);
            this.groupBox1.Controls.Add(this.lbBacSi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbChuyenKhoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.lbNgayKham);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 521);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbMajor
            // 
            this.cbMajor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbMajor.Enabled = false;
            this.cbMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMajor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Location = new System.Drawing.Point(261, 170);
            this.cbMajor.Name = "cbMajor";
            this.cbMajor.Size = new System.Drawing.Size(380, 28);
            this.cbMajor.TabIndex = 25;
            this.cbMajor.TabStop = false;
            this.cbMajor.Text = "Chọn Chuyên Khoa";
            this.cbMajor.SelectedIndexChanged += new System.EventHandler(this.cbMajor_SelectedIndexChanged);
            this.cbMajor.TextUpdate += new System.EventHandler(this.cbMajor_TextUpdate);
            this.cbMajor.DataSourceChanged += new System.EventHandler(this.cbMajor_DataSourceChanged);
            this.cbMajor.SelectedValueChanged += new System.EventHandler(this.cbMajor_SelectedValueChanged);
            this.cbMajor.TextChanged += new System.EventHandler(this.cbMajor_TextChanged);
            this.cbMajor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbMajor_MouseClick);
            // 
            // label11
            // 
            this.label11.Image = global::Datlich.Properties.Resources.rsz_time;
            this.label11.Location = new System.Drawing.Point(187, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 50);
            this.label11.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Image = global::Datlich.Properties.Resources.rsz_bacsi;
            this.label7.Location = new System.Drawing.Point(187, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 50);
            this.label7.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Image = global::Datlich.Properties.Resources.rsz_khoa;
            this.label5.Location = new System.Drawing.Point(187, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 50);
            this.label5.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Image = global::Datlich.Properties.Resources.rsz_ngay;
            this.label3.Location = new System.Drawing.Point(187, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 50);
            this.label3.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(257, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Vui lòng chọn đối tượng BHYT";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No.Location = new System.Drawing.Point(444, 436);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(67, 21);
            this.No.TabIndex = 17;
            this.No.TabStop = true;
            this.No.Text = "Không";
            this.No.UseVisualStyleBackColor = true;
            this.No.CheckedChanged += new System.EventHandler(this.No_CheckedChanged);
            // 
            // Yes
            // 
            this.Yes.AutoSize = true;
            this.Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes.Location = new System.Drawing.Point(330, 436);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(43, 21);
            this.Yes.TabIndex = 16;
            this.Yes.TabStop = true;
            this.Yes.Text = "Có";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.CheckedChanged += new System.EventHandler(this.Yes_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(257, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "BHYT:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(261, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(377, 1);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtTime.Location = new System.Drawing.Point(261, 349);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(377, 25);
            this.txtTime.TabIndex = 12;
            this.txtTime.TabStop = false;
            this.txtTime.Text = "Chọn Giờ Khám";
            this.txtTime.Click += new System.EventHandler(this.txtTime_Click);
            this.txtTime.ReadOnlyChanged += new System.EventHandler(this.txtTime_ReadOnlyChanged);
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            this.txtTime.DragOver += new System.Windows.Forms.DragEventHandler(this.txtTime_DragOver);
            this.txtTime.Validating += new System.ComponentModel.CancelEventHandler(this.txtTime_Validating);
            // 
            // lbPhongGio
            // 
            this.lbPhongGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhongGio.Location = new System.Drawing.Point(260, 319);
            this.lbPhongGio.Name = "lbPhongGio";
            this.lbPhongGio.Size = new System.Drawing.Size(216, 28);
            this.lbPhongGio.TabIndex = 11;
            this.lbPhongGio.Text = "Phòng khám và giờ khám";
            this.lbPhongGio.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(264, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 1);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // txtDoctor
            // 
            this.txtDoctor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDoctor.Enabled = false;
            this.txtDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctor.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtDoctor.Location = new System.Drawing.Point(264, 262);
            this.txtDoctor.Multiline = true;
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(377, 25);
            this.txtDoctor.TabIndex = 9;
            this.txtDoctor.TabStop = false;
            this.txtDoctor.Text = "Chọn Bác Sĩ";
            this.txtDoctor.Click += new System.EventHandler(this.txtDoctor_Click);
            this.txtDoctor.TextChanged += new System.EventHandler(this.txtDoctor_TextChanged);
            // 
            // lbBacSi
            // 
            this.lbBacSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBacSi.Location = new System.Drawing.Point(264, 226);
            this.lbBacSi.Name = "lbBacSi";
            this.lbBacSi.Size = new System.Drawing.Size(53, 27);
            this.lbBacSi.TabIndex = 8;
            this.lbBacSi.Text = "Bác sĩ";
            this.lbBacSi.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbBacSi.Visible = false;
            this.lbBacSi.Click += new System.EventHandler(this.lbBacSi_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(261, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 1);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // lbChuyenKhoa
            // 
            this.lbChuyenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChuyenKhoa.Location = new System.Drawing.Point(260, 132);
            this.lbChuyenKhoa.Name = "lbChuyenKhoa";
            this.lbChuyenKhoa.Size = new System.Drawing.Size(106, 32);
            this.lbChuyenKhoa.TabIndex = 5;
            this.lbChuyenKhoa.Text = "Chuyên Khoa";
            this.lbChuyenKhoa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbChuyenKhoa.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(261, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 1);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtDate.Location = new System.Drawing.Point(264, 87);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(374, 28);
            this.txtDate.TabIndex = 3;
            this.txtDate.TabStop = false;
            this.txtDate.Text = "Chọn Ngày Khám";
            this.txtDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Ngay_MouseClick);
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // lbNgayKham
            // 
            this.lbNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayKham.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbNgayKham.Location = new System.Drawing.Point(260, 51);
            this.lbNgayKham.Name = "lbNgayKham";
            this.lbNgayKham.Size = new System.Drawing.Size(95, 25);
            this.lbNgayKham.TabIndex = 2;
            this.lbNgayKham.Text = "Ngày Khám";
            this.lbNgayKham.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbNgayKham.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.email1);
            this.panel1.Controls.Add(this.mabn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 521);
            this.panel1.TabIndex = 19;
            // 
            // email1
            // 
            this.email1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email1.Location = new System.Drawing.Point(0, 179);
            this.email1.Name = "email1";
            this.email1.Size = new System.Drawing.Size(155, 23);
            this.email1.TabIndex = 8;
            this.email1.Text = "tin.duongduc@hcmut.edu.vn";
            this.email1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mabn
            // 
            this.mabn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mabn.ForeColor = System.Drawing.SystemColors.Control;
            this.mabn.Location = new System.Drawing.Point(12, 156);
            this.mabn.Name = "mabn";
            this.mabn.Size = new System.Drawing.Size(140, 23);
            this.mabn.TabIndex = 7;
            this.mabn.Text = "1710332";
            this.mabn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mabn.Click += new System.EventHandler(this.mabn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.updateinfor);
            this.panel2.Controls.Add(this.promote);
            this.panel2.Controls.Add(this.help);
            this.panel2.Location = new System.Drawing.Point(3, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 51);
            this.panel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tìm Hiểu Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateinfor
            // 
            this.updateinfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateinfor.Location = new System.Drawing.Point(11, 58);
            this.updateinfor.Name = "updateinfor";
            this.updateinfor.Size = new System.Drawing.Size(121, 54);
            this.updateinfor.TabIndex = 1;
            this.updateinfor.Text = "Cập nhật tài khoản";
            this.updateinfor.UseVisualStyleBackColor = true;
            // 
            // promote
            // 
            this.promote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promote.Location = new System.Drawing.Point(11, 118);
            this.promote.Name = "promote";
            this.promote.Size = new System.Drawing.Size(121, 54);
            this.promote.TabIndex = 2;
            this.promote.Text = "Ưu đãi";
            this.promote.UseVisualStyleBackColor = true;
            // 
            // help
            // 
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.Location = new System.Drawing.Point(11, 179);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(121, 54);
            this.help.TabIndex = 3;
            this.help.Text = "Trợ giúp";
            this.help.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Lavender;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(12, 126);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(140, 30);
            this.name.TabIndex = 5;
            this.name.Text = "Đức Tín";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(3, 264);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(152, 54);
            this.logout.TabIndex = 4;
            this.logout.Text = "Thoát";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Datlich.Properties.Resources.tải_xuống;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Date_panel
            // 
            this.Date_panel.BackColor = System.Drawing.Color.Lavender;
            this.Date_panel.Controls.Add(this.monthCalendar1);
            this.Date_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Date_panel.Location = new System.Drawing.Point(158, 43);
            this.Date_panel.Name = "Date_panel";
            this.Date_panel.Size = new System.Drawing.Size(518, 10);
            this.Date_panel.TabIndex = 19;
            this.Date_panel.Visible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.BackColor = System.Drawing.Color.DarkRed;
            this.monthCalendar1.Location = new System.Drawing.Point(156, 102);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2019, 4, 26, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 564);
            this.Controls.Add(this.Date_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Datlich);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Date_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Datlich;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel Date_panel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        public System.Windows.Forms.ComboBox cbMajor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton No;
        private System.Windows.Forms.RadioButton Yes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lbPhongGio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.Label lbBacSi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbChuyenKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lbNgayKham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label mabn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updateinfor;
        private System.Windows.Forms.Button promote;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Label email1;
    }
}

