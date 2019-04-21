namespace Tin
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
            //this.allDoctorDataSet = new Tin.AllDoctorDataSet();
            this.allDoctorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.allDoctorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDoctorDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Date_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Datlich
            // 
            this.Datlich.BackColor = System.Drawing.Color.DarkGreen;
            this.Datlich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Datlich.Dock = System.Windows.Forms.DockStyle.Top;
            this.Datlich.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Datlich.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datlich.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Datlich.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Datlich.Location = new System.Drawing.Point(0, 0);
            this.Datlich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Datlich.Name = "Datlich";
            this.Datlich.Size = new System.Drawing.Size(901, 52);
            this.Datlich.TabIndex = 0;
            this.Datlich.Text = "Đặt Lịch Hẹn";
            this.Datlich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.SandyBrown;
            this.Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.Location = new System.Drawing.Point(211, 585);
            this.Confirm.Margin = new System.Windows.Forms.Padding(4);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(687, 53);
            this.Confirm.TabIndex = 18;
            this.Confirm.Text = "Đặt Khám";
            this.Confirm.UseVisualStyleBackColor = false;
            // 
            // allDoctorDataSet
            // 
            this.allDoctorDataSet.DataSetName = "AllDoctorDataSet";
            this.allDoctorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allDoctorDataSetBindingSource
            // 
            this.allDoctorDataSetBindingSource.DataSource = this.allDoctorDataSet;
            this.allDoctorDataSetBindingSource.Position = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
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
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(901, 642);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbMajor
            // 
            this.cbMajor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMajor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Location = new System.Drawing.Point(348, 209);
            this.cbMajor.Margin = new System.Windows.Forms.Padding(4);
            this.cbMajor.Name = "cbMajor";
            this.cbMajor.Size = new System.Drawing.Size(505, 33);
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
            this.label11.Image = global::Tin.Properties.Resources.rsz_time;
            this.label11.Location = new System.Drawing.Point(249, 396);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 62);
            this.label11.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Image = global::Tin.Properties.Resources.rsz_bacsi;
            this.label7.Location = new System.Drawing.Point(249, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 62);
            this.label7.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Image = global::Tin.Properties.Resources.rsz_khoa;
            this.label5.Location = new System.Drawing.Point(249, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 62);
            this.label5.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Image = global::Tin.Properties.Resources.rsz_ngay;
            this.label3.Location = new System.Drawing.Point(249, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 62);
            this.label3.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(343, 502);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(396, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "Vui lòng chọn đối tượng BHYT";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No.Location = new System.Drawing.Point(592, 537);
            this.No.Margin = new System.Windows.Forms.Padding(4);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(77, 24);
            this.No.TabIndex = 17;
            this.No.TabStop = true;
            this.No.Text = "Không";
            this.No.UseVisualStyleBackColor = true;
            // 
            // Yes
            // 
            this.Yes.AutoSize = true;
            this.Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes.Location = new System.Drawing.Point(440, 537);
            this.Yes.Margin = new System.Windows.Forms.Padding(4);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(51, 24);
            this.Yes.TabIndex = 16;
            this.Yes.TabStop = true;
            this.Yes.Text = "Có";
            this.Yes.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(343, 534);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "BHYT:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(348, 464);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(503, 1);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtTime.Location = new System.Drawing.Point(348, 430);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(503, 31);
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
            this.lbPhongGio.Location = new System.Drawing.Point(347, 393);
            this.lbPhongGio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhongGio.Name = "lbPhongGio";
            this.lbPhongGio.Size = new System.Drawing.Size(288, 34);
            this.lbPhongGio.TabIndex = 11;
            this.lbPhongGio.Text = "Phòng khám và giờ khám";
            this.lbPhongGio.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(352, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(503, 1);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // txtDoctor
            // 
            this.txtDoctor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctor.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtDoctor.Location = new System.Drawing.Point(352, 322);
            this.txtDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctor.Multiline = true;
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(503, 31);
            this.txtDoctor.TabIndex = 9;
            this.txtDoctor.TabStop = false;
            this.txtDoctor.Text = "Chọn Bác Sĩ";
            this.txtDoctor.Click += new System.EventHandler(this.txtDoctor_Click);
            // 
            // lbBacSi
            // 
            this.lbBacSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBacSi.Location = new System.Drawing.Point(352, 278);
            this.lbBacSi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBacSi.Name = "lbBacSi";
            this.lbBacSi.Size = new System.Drawing.Size(71, 33);
            this.lbBacSi.TabIndex = 8;
            this.lbBacSi.Text = "Bác sĩ";
            this.lbBacSi.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbBacSi.Visible = false;
            this.lbBacSi.Click += new System.EventHandler(this.lbBacSi_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(348, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 1);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // lbChuyenKhoa
            // 
            this.lbChuyenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChuyenKhoa.Location = new System.Drawing.Point(347, 162);
            this.lbChuyenKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChuyenKhoa.Name = "lbChuyenKhoa";
            this.lbChuyenKhoa.Size = new System.Drawing.Size(141, 39);
            this.lbChuyenKhoa.TabIndex = 5;
            this.lbChuyenKhoa.Text = "Chuyên Khoa";
            this.lbChuyenKhoa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbChuyenKhoa.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(348, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 1);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtDate.Location = new System.Drawing.Point(352, 107);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(499, 34);
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
            this.lbNgayKham.Location = new System.Drawing.Point(347, 63);
            this.lbNgayKham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayKham.Name = "lbNgayKham";
            this.lbNgayKham.Size = new System.Drawing.Size(127, 31);
            this.lbNgayKham.TabIndex = 2;
            this.lbNgayKham.Text = "Ngày Khám";
            this.lbNgayKham.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbNgayKham.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 642);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.updateinfor);
            this.panel2.Controls.Add(this.promote);
            this.panel2.Controls.Add(this.help);
            this.panel2.Location = new System.Drawing.Point(4, 249);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 63);
            this.panel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tìm Hiểu Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateinfor
            // 
            this.updateinfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateinfor.Location = new System.Drawing.Point(15, 71);
            this.updateinfor.Margin = new System.Windows.Forms.Padding(4);
            this.updateinfor.Name = "updateinfor";
            this.updateinfor.Size = new System.Drawing.Size(161, 66);
            this.updateinfor.TabIndex = 1;
            this.updateinfor.Text = "Cập nhật tài khoản";
            this.updateinfor.UseVisualStyleBackColor = true;
            // 
            // promote
            // 
            this.promote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promote.Location = new System.Drawing.Point(15, 145);
            this.promote.Margin = new System.Windows.Forms.Padding(4);
            this.promote.Name = "promote";
            this.promote.Size = new System.Drawing.Size(161, 66);
            this.promote.TabIndex = 2;
            this.promote.Text = "Ưu đãi";
            this.promote.UseVisualStyleBackColor = true;
            // 
            // help
            // 
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.Location = new System.Drawing.Point(15, 220);
            this.help.Margin = new System.Windows.Forms.Padding(4);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(161, 66);
            this.help.TabIndex = 3;
            this.help.Text = "Trợ giúp";
            this.help.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.DarkGreen;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.name.Location = new System.Drawing.Point(16, 155);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(187, 55);
            this.name.TabIndex = 5;
            this.name.Text = "Đức Tín";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(4, 325);
            this.logout.Margin = new System.Windows.Forms.Padding(4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(203, 66);
            this.logout.TabIndex = 4;
            this.logout.Text = "Thoát";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tin.Properties.Resources.tải_xuống;
            this.pictureBox1.Location = new System.Drawing.Point(16, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Date_panel
            // 
            this.Date_panel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Date_panel.Controls.Add(this.monthCalendar1);
            this.Date_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Date_panel.Location = new System.Drawing.Point(211, 52);
            this.Date_panel.Margin = new System.Windows.Forms.Padding(4);
            this.Date_panel.Name = "Date_panel";
            this.Date_panel.Size = new System.Drawing.Size(690, 12);
            this.Date_panel.TabIndex = 19;
            this.Date_panel.Visible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.BackColor = System.Drawing.Color.DarkRed;
            this.monthCalendar1.Location = new System.Drawing.Point(203, 105);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.MaxSelectionCount = 1;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 694);
            this.Controls.Add(this.Date_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Datlich);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.allDoctorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDoctorDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource allDoctorDataSetBindingSource;
        //private AllDoctorDataSet allDoctorDataSet;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button promote;
        private System.Windows.Forms.Button updateinfor;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

