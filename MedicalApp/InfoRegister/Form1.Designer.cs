namespace InfoRegister
{
    partial class formRegister
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tLPInfo = new System.Windows.Forms.TableLayoutPanel();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fLPSex = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.labelMissing2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.CMNDBox = new System.Windows.Forms.TextBox();
            this.adrBox = new System.Windows.Forms.TextBox();
            this.phoneNumBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.fLPDate = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.labelMissing = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.homeTownBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.tLPInfo.SuspendLayout();
            this.fLPSex.SuspendLayout();
            this.fLPDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tLPInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRegister, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.963099F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(519, 421);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelTop.ColumnCount = 2;
            this.panelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.panelTop.Controls.Add(this.btnClose, 1, 0);
            this.panelTop.Controls.Add(this.label1, 0, 0);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.RowCount = 1;
            this.panelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelTop.Size = new System.Drawing.Size(519, 39);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClose.BackgroundImage = global::InfoRegister.Properties.Resources.CloseIcon5;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(496, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(23, 39);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo mới hồ sơ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tLPInfo
            // 
            this.tLPInfo.ColumnCount = 2;
            this.tLPInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 383F));
            this.tLPInfo.Controls.Add(this.label12, 0, 8);
            this.tLPInfo.Controls.Add(this.firstNameBox, 1, 1);
            this.tLPInfo.Controls.Add(this.label2, 0, 0);
            this.tLPInfo.Controls.Add(this.label3, 0, 1);
            this.tLPInfo.Controls.Add(this.fLPSex, 1, 3);
            this.tLPInfo.Controls.Add(this.label4, 0, 2);
            this.tLPInfo.Controls.Add(this.label5, 0, 3);
            this.tLPInfo.Controls.Add(this.label6, 0, 4);
            this.tLPInfo.Controls.Add(this.label7, 0, 5);
            this.tLPInfo.Controls.Add(this.label8, 0, 6);
            this.tLPInfo.Controls.Add(this.label9, 0, 7);
            this.tLPInfo.Controls.Add(this.lastNameBox, 1, 0);
            this.tLPInfo.Controls.Add(this.CMNDBox, 1, 4);
            this.tLPInfo.Controls.Add(this.adrBox, 1, 5);
            this.tLPInfo.Controls.Add(this.phoneNumBox, 1, 6);
            this.tLPInfo.Controls.Add(this.emailBox, 1, 7);
            this.tLPInfo.Controls.Add(this.fLPDate, 1, 2);
            this.tLPInfo.Controls.Add(this.homeTownBox, 1, 8);
            this.tLPInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPInfo.Location = new System.Drawing.Point(3, 42);
            this.tLPInfo.Name = "tLPInfo";
            this.tLPInfo.RowCount = 9;
            this.tLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLPInfo.Size = new System.Drawing.Size(513, 346);
            this.tLPInfo.TabIndex = 1;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.firstNameBox.Location = new System.Drawing.Point(133, 47);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(377, 20);
            this.firstNameBox.TabIndex = 1;
            this.firstNameBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseLeft);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ và tên lót";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên bệnh nhân";
            // 
            // fLPSex
            // 
            this.fLPSex.Controls.Add(this.radioButtonMale);
            this.fLPSex.Controls.Add(this.radioButtonFemale);
            this.fLPSex.Controls.Add(this.labelMissing2);
            this.fLPSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPSex.Location = new System.Drawing.Point(133, 117);
            this.fLPSex.Name = "fLPSex";
            this.fLPSex.Size = new System.Drawing.Size(377, 32);
            this.fLPSex.TabIndex = 3;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(3, 3);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(47, 17);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Nam";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnRadioBtnMouseLeft);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(56, 3);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(39, 17);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Nữ";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnRadioBtnMouseLeft);
            // 
            // labelMissing2
            // 
            this.labelMissing2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMissing2.AutoSize = true;
            this.labelMissing2.BackColor = System.Drawing.Color.Yellow;
            this.labelMissing2.Font = new System.Drawing.Font("Montserrat Subrayada", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMissing2.ForeColor = System.Drawing.Color.Red;
            this.labelMissing2.Location = new System.Drawing.Point(101, 2);
            this.labelMissing2.Name = "labelMissing2";
            this.labelMissing2.Size = new System.Drawing.Size(12, 18);
            this.labelMissing2.TabIndex = 2;
            this.labelMissing2.Text = "!";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày tháng năm sinh";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "CMND";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Số điện thoại";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastNameBox.Location = new System.Drawing.Point(133, 9);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(377, 20);
            this.lastNameBox.TabIndex = 0;
            this.lastNameBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseLeft);
            // 
            // CMNDBox
            // 
            this.CMNDBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CMNDBox.Location = new System.Drawing.Point(133, 161);
            this.CMNDBox.Name = "CMNDBox";
            this.CMNDBox.Size = new System.Drawing.Size(377, 20);
            this.CMNDBox.TabIndex = 4;
            this.CMNDBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseLeft);
            // 
            // adrBox
            // 
            this.adrBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.adrBox.Location = new System.Drawing.Point(133, 199);
            this.adrBox.Name = "adrBox";
            this.adrBox.Size = new System.Drawing.Size(377, 20);
            this.adrBox.TabIndex = 5;
            this.adrBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseLeft);
            // 
            // phoneNumBox
            // 
            this.phoneNumBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phoneNumBox.Location = new System.Drawing.Point(133, 237);
            this.phoneNumBox.Name = "phoneNumBox";
            this.phoneNumBox.Size = new System.Drawing.Size(377, 20);
            this.phoneNumBox.TabIndex = 6;
            this.phoneNumBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseLeft);
            // 
            // emailBox
            // 
            this.emailBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailBox.Location = new System.Drawing.Point(133, 275);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(377, 20);
            this.emailBox.TabIndex = 7;
            this.emailBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseLeft);
            // 
            // fLPDate
            // 
            this.fLPDate.Controls.Add(this.comboBoxDay);
            this.fLPDate.Controls.Add(this.label10);
            this.fLPDate.Controls.Add(this.comboBoxMonth);
            this.fLPDate.Controls.Add(this.label11);
            this.fLPDate.Controls.Add(this.comboBoxYear);
            this.fLPDate.Controls.Add(this.labelMissing);
            this.fLPDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPDate.Location = new System.Drawing.Point(133, 79);
            this.fLPDate.Name = "fLPDate";
            this.fLPDate.Size = new System.Drawing.Size(377, 32);
            this.fLPDate.TabIndex = 2;
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
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
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxDay.Location = new System.Drawing.Point(3, 3);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(85, 21);
            this.comboBoxDay.TabIndex = 0;
            this.comboBoxDay.Text = "  Ngày";
            this.comboBoxDay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnComboBoxMouseLeft);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(94, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "/";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "Một",
            "Hai",
            "Ba",
            "Tư",
            "Năm",
            "Sáu",
            "Bảy",
            "Tám",
            "Chín",
            "Mười",
            "Mười một ",
            "Mười hai"});
            this.comboBoxMonth.Location = new System.Drawing.Point(119, 3);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(80, 21);
            this.comboBoxMonth.TabIndex = 1;
            this.comboBoxMonth.Text = " Tháng";
            this.comboBoxMonth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnComboBoxMouseLeft);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(205, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "/";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.comboBoxYear.Location = new System.Drawing.Point(230, 3);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(97, 21);
            this.comboBoxYear.TabIndex = 2;
            this.comboBoxYear.Text = " Năm";
            this.comboBoxYear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnComboBoxMouseLeft);
            // 
            // labelMissing
            // 
            this.labelMissing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMissing.AutoSize = true;
            this.labelMissing.BackColor = System.Drawing.Color.Yellow;
            this.labelMissing.Font = new System.Drawing.Font("Montserrat Subrayada", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMissing.ForeColor = System.Drawing.Color.Red;
            this.labelMissing.Location = new System.Drawing.Point(340, 4);
            this.labelMissing.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.labelMissing.Name = "labelMissing";
            this.labelMissing.Size = new System.Drawing.Size(12, 18);
            this.labelMissing.TabIndex = 3;
            this.labelMissing.Text = "!";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.Location = new System.Drawing.Point(441, 394);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Tạo hồ sơ";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Quê quán";
            // 
            // homeTownBox
            // 
            this.homeTownBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.homeTownBox.Location = new System.Drawing.Point(133, 315);
            this.homeTownBox.Name = "homeTownBox";
            this.homeTownBox.Size = new System.Drawing.Size(377, 20);
            this.homeTownBox.TabIndex = 9;
            // 
            // formRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(519, 421);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formRegister";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tLPInfo.ResumeLayout(false);
            this.tLPInfo.PerformLayout();
            this.fLPSex.ResumeLayout(false);
            this.fLPSex.PerformLayout();
            this.fLPDate.ResumeLayout(false);
            this.fLPDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tLPInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox CMNDBox;
        private System.Windows.Forms.TextBox adrBox;
        private System.Windows.Forms.TextBox phoneNumBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.FlowLayoutPanel fLPDate;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.FlowLayoutPanel fLPSex;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label labelMissing;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label labelMissing2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox homeTownBox;
    }
}

