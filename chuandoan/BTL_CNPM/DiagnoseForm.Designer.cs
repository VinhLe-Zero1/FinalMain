namespace T_chuandoan
{
    partial class DiagnoseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnoseForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.return_button = new System.Windows.Forms.Button();
            this.result_label = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dh1 = new System.Windows.Forms.ComboBox();
            this.dh4 = new System.Windows.Forms.ComboBox();
            this.dh3 = new System.Windows.Forms.ComboBox();
            this.dh2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPhongGio = new System.Windows.Forms.Label();
            this.lbBacSi = new System.Windows.Forms.Label();
            this.lbChuyenKhoa = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.return_button);
            this.groupBox1.Controls.Add(this.result_label);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dh1);
            this.groupBox1.Controls.Add(this.dh4);
            this.groupBox1.Controls.Add(this.dh3);
            this.groupBox1.Controls.Add(this.dh2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbPhongGio);
            this.groupBox1.Controls.Add(this.lbBacSi);
            this.groupBox1.Controls.Add(this.lbChuyenKhoa);
            this.groupBox1.Font = new System.Drawing.Font("Castellar", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 380);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // return_button
            // 
            this.return_button.AllowDrop = true;
            this.return_button.BackColor = System.Drawing.Color.GhostWhite;
            this.return_button.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.return_button.FlatAppearance.BorderSize = 0;
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.return_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_button.ForeColor = System.Drawing.Color.DodgerBlue;
            this.return_button.Location = new System.Drawing.Point(239, 178);
            this.return_button.Margin = new System.Windows.Forms.Padding(2);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(72, 29);
            this.return_button.TabIndex = 42;
            this.return_button.Text = "Trở về";
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Visible = false;
            this.return_button.Click += new System.EventHandler(this.b_thongbao_Click);
            // 
            // result_label
            // 
            this.result_label.ActiveLinkColor = System.Drawing.Color.PapayaWhip;
            this.result_label.BackColor = System.Drawing.Color.DodgerBlue;
            this.result_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result_label.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.result_label.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.result_label.LinkColor = System.Drawing.Color.GhostWhite;
            this.result_label.Location = new System.Drawing.Point(152, 113);
            this.result_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(257, 109);
            this.result_label.TabIndex = 41;
            this.result_label.TabStop = true;
            this.result_label.Text = "Chọn ít nhất một dấu hiệu để có thể chuẩn đoán!";
            this.result_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.result_label.Visible = false;
            this.result_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.thongbao_LinkClicked);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(300, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 1);
            this.label6.TabIndex = 40;
            this.label6.Text = "label6";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(29, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 1);
            this.label4.TabIndex = 39;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(300, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 1);
            this.label5.TabIndex = 38;
            this.label5.Text = "label5";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 1);
            this.label2.TabIndex = 36;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 15F);
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(27, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 32);
            this.label3.TabIndex = 35;
            this.label3.Text = "Dấu hiệu 1:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.GhostWhite;
            this.button1.Location = new System.Drawing.Point(3, 334);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(554, 43);
            this.button1.TabIndex = 34;
            this.button1.Text = "Kết quả";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dh1
            // 
            this.dh1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dh1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dh1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dh1.FormattingEnabled = true;
            this.dh1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dh1.Items.AddRange(new object[] {
            "Bạc tóc",
            "Bầm tím",
            "Bệnh tiêu chảy",
            "Béo phì",
            "Bong gân",
            "Cáu gắt",
            "Chảy nước mắt",
            "Chảy nước mũi",
            "Chóng mặt",
            "Chuột rút",
            "Có đờm",
            "Có máu trong đờm",
            "Có người thân bị bệnh",
            "Cơ thể thay đổi",
            "Cứng cổ",
            "Cường giáp",
            "Đa niệu",
            "Đau bụng",
            "Đau cơ",
            "Đau cổ",
            "Đau đầu gối",
            "Đau khi đi lại",
            "Đau khi vận động",
            "Đau khớp hông",
            "Đau lồng ngực",
            "Đau lưng",
            "Đau mắt đỏ",
            "Đau ngực",
            "Đau ở vùng hậu môn",
            "Đau quanh dạ dày",
            "Đau quanh mũi",
            "Di chuyển khó khăn",
            "Di chuyển lảo đảo",
            "Đi tiểu nhiều",
            "Đờm lỏng",
            "Giãn tĩnh máu",
            "Hối hả, lo âu",
            "Hôn mê",
            "Khàn giọng",
            "Khó chịu",
            "Khó chịu bàng quang",
            "Khó chịu hậu môn",
            "Khô môi",
            "Khó tiêu",
            "Không ổn định",
            "Kinh nguyệt thất thường",
            "Lao lực",
            "Lõm nhỏ ở móng tay",
            "Mất cân bằng",
            "Mất khứu giác",
            "Mất tập trung",
            "Mau đói",
            "Mờ mắt",
            "Móng tay giòn",
            "Mụn đầu đen",
            "Mụn mủ",
            "Ngứa bên trong",
            "Nhịp tim cao",
            "Nổi đốm đỏ ",
            "Nói lắp",
            "Nổi tĩnh mạch trên chân",
            "Nổi vảy",
            "Nước tiểu nặng mùi",
            "Nước tiểu vàng",
            "Phân có máu",
            "Phiền muộn",
            "Rối loạn thị giác",
            "Rộp da",
            "Run tay chân",
            "Sốt nhẹ",
            "Sưng hạch bạch huyết",
            "Sưng khớp",
            "Sưng mặt",
            "Sưng tấy",
            "Suy gan cấp",
            "Tắc nghẽn động mạch",
            "Táo bón",
            "Thèm ăn",
            "Tiêu cực",
            "Tiêu thụ đồ uống có cồn",
            "Tràn dịch vị",
            "Tróc da",
            "Trực tràng",
            "Trướng bụng",
            "Trương dạ dày",
            "Từng được truyền máu",
            "Từng tiêm thuốc",
            "Vàng mắt",
            "Viêm họng",
            "Viêm ở móng tay",
            "Viêm xoang",
            "Xì hơi nhiều",
            "Xuất huyết dạ dày",
            "Yếu cơ",
            "Yếu một bên cơ thể"});
            this.dh1.Location = new System.Drawing.Point(31, 94);
            this.dh1.Margin = new System.Windows.Forms.Padding(2);
            this.dh1.Name = "dh1";
            this.dh1.Size = new System.Drawing.Size(187, 23);
            this.dh1.TabIndex = 27;
            this.dh1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dh4
            // 
            this.dh4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dh4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dh4.FormattingEnabled = true;
            this.dh4.Items.AddRange(new object[] {
            "Bạc tóc",
            "Bầm tím",
            "Bệnh tiêu chảy",
            "Béo phì",
            "Bong gân",
            "Cáu gắt",
            "Chảy nước mắt",
            "Chảy nước mũi",
            "Chóng mặt",
            "Chuột rút",
            "Có đờm",
            "Có máu trong đờm",
            "Có người thân bị bệnh",
            "Cơ thể thay đổi",
            "Cứng cổ",
            "Cường giáp",
            "Đa niệu",
            "Đau bụng",
            "Đau cơ",
            "Đau cổ",
            "Đau đầu gối",
            "Đau khi đi lại",
            "Đau khi vận động",
            "Đau khớp hông",
            "Đau lồng ngực",
            "Đau lưng",
            "Đau mắt đỏ",
            "Đau ngực",
            "Đau ở vùng hậu môn",
            "Đau quanh dạ dày",
            "Đau quanh mũi",
            "Di chuyển khó khăn",
            "Di chuyển lảo đảo",
            "Đi tiểu nhiều",
            "Đờm lỏng",
            "Giãn tĩnh máu",
            "Hối hả, lo âu",
            "Hôn mê",
            "Khàn giọng",
            "Khó chịu",
            "Khó chịu bàng quang",
            "Khó chịu hậu môn",
            "Khô môi",
            "Khó tiêu",
            "Không ổn định",
            "Kinh nguyệt thất thường",
            "Lao lực",
            "Lõm nhỏ ở móng tay",
            "Mất cân bằng",
            "Mất khứu giác",
            "Mất tập trung",
            "Mau đói",
            "Mờ mắt",
            "Móng tay giòn",
            "Mụn đầu đen",
            "Mụn mủ",
            "Ngứa bên trong",
            "Nhịp tim cao",
            "Nổi đốm đỏ ",
            "Nói lắp",
            "Nổi tĩnh mạch trên chân",
            "Nổi vảy",
            "Nước tiểu nặng mùi",
            "Nước tiểu vàng",
            "Phân có máu",
            "Phiền muộn",
            "Rối loạn thị giác",
            "Rộp da",
            "Run tay chân",
            "Sốt nhẹ",
            "Sưng hạch bạch huyết",
            "Sưng khớp",
            "Sưng mặt",
            "Sưng tấy",
            "Suy gan cấp",
            "Tắc nghẽn động mạch",
            "Táo bón",
            "Thèm ăn",
            "Tiêu cực",
            "Tiêu thụ đồ uống có cồn",
            "Tràn dịch vị",
            "Tróc da",
            "Trực tràng",
            "Trướng bụng",
            "Trương dạ dày",
            "Từng được truyền máu",
            "Từng tiêm thuốc",
            "Vàng mắt",
            "Viêm họng",
            "Viêm ở móng tay",
            "Viêm xoang",
            "Xì hơi nhiều",
            "Xuất huyết dạ dày",
            "Yếu cơ",
            "Yếu một bên cơ thể"});
            this.dh4.Location = new System.Drawing.Point(302, 232);
            this.dh4.Margin = new System.Windows.Forms.Padding(2);
            this.dh4.Name = "dh4";
            this.dh4.Size = new System.Drawing.Size(187, 23);
            this.dh4.TabIndex = 30;
            // 
            // dh3
            // 
            this.dh3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dh3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dh3.FormattingEnabled = true;
            this.dh3.Items.AddRange(new object[] {
            "Bạc tóc",
            "Bầm tím",
            "Bệnh tiêu chảy",
            "Béo phì",
            "Bong gân",
            "Cáu gắt",
            "Chảy nước mắt",
            "Chảy nước mũi",
            "Chóng mặt",
            "Chuột rút",
            "Có đờm",
            "Có máu trong đờm",
            "Có người thân bị bệnh",
            "Cơ thể thay đổi",
            "Cứng cổ",
            "Cường giáp",
            "Đa niệu",
            "Đau bụng",
            "Đau cơ",
            "Đau cổ",
            "Đau đầu gối",
            "Đau khi đi lại",
            "Đau khi vận động",
            "Đau khớp hông",
            "Đau lồng ngực",
            "Đau lưng",
            "Đau mắt đỏ",
            "Đau ngực",
            "Đau ở vùng hậu môn",
            "Đau quanh dạ dày",
            "Đau quanh mũi",
            "Di chuyển khó khăn",
            "Di chuyển lảo đảo",
            "Đi tiểu nhiều",
            "Đờm lỏng",
            "Giãn tĩnh máu",
            "Hối hả, lo âu",
            "Hôn mê",
            "Khàn giọng",
            "Khó chịu",
            "Khó chịu bàng quang",
            "Khó chịu hậu môn",
            "Khô môi",
            "Khó tiêu",
            "Không ổn định",
            "Kinh nguyệt thất thường",
            "Lao lực",
            "Lõm nhỏ ở móng tay",
            "Mất cân bằng",
            "Mất khứu giác",
            "Mất tập trung",
            "Mau đói",
            "Mờ mắt",
            "Móng tay giòn",
            "Mụn đầu đen",
            "Mụn mủ",
            "Ngứa bên trong",
            "Nhịp tim cao",
            "Nổi đốm đỏ ",
            "Nói lắp",
            "Nổi tĩnh mạch trên chân",
            "Nổi vảy",
            "Nước tiểu nặng mùi",
            "Nước tiểu vàng",
            "Phân có máu",
            "Phiền muộn",
            "Rối loạn thị giác",
            "Rộp da",
            "Run tay chân",
            "Sốt nhẹ",
            "Sưng hạch bạch huyết",
            "Sưng khớp",
            "Sưng mặt",
            "Sưng tấy",
            "Suy gan cấp",
            "Tắc nghẽn động mạch",
            "Táo bón",
            "Thèm ăn",
            "Tiêu cực",
            "Tiêu thụ đồ uống có cồn",
            "Tràn dịch vị",
            "Tróc da",
            "Trực tràng",
            "Trướng bụng",
            "Trương dạ dày",
            "Từng được truyền máu",
            "Từng tiêm thuốc",
            "Vàng mắt",
            "Viêm họng",
            "Viêm ở móng tay",
            "Viêm xoang",
            "Xì hơi nhiều",
            "Xuất huyết dạ dày",
            "Yếu cơ",
            "Yếu một bên cơ thể"});
            this.dh3.Location = new System.Drawing.Point(31, 232);
            this.dh3.Margin = new System.Windows.Forms.Padding(2);
            this.dh3.Name = "dh3";
            this.dh3.Size = new System.Drawing.Size(187, 23);
            this.dh3.TabIndex = 29;
            // 
            // dh2
            // 
            this.dh2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dh2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dh2.FormattingEnabled = true;
            this.dh2.Items.AddRange(new object[] {
            "Bạc tóc",
            "Bầm tím",
            "Bệnh tiêu chảy",
            "Béo phì",
            "Bong gân",
            "Cáu gắt",
            "Chảy nước mắt",
            "Chảy nước mũi",
            "Chóng mặt",
            "Chuột rút",
            "Có đờm",
            "Có máu trong đờm",
            "Có người thân bị bệnh",
            "Cơ thể thay đổi",
            "Cứng cổ",
            "Cường giáp",
            "Đa niệu",
            "Đau bụng",
            "Đau cơ",
            "Đau cổ",
            "Đau đầu gối",
            "Đau khi đi lại",
            "Đau khi vận động",
            "Đau khớp hông",
            "Đau lồng ngực",
            "Đau lưng",
            "Đau mắt đỏ",
            "Đau ngực",
            "Đau ở vùng hậu môn",
            "Đau quanh dạ dày",
            "Đau quanh mũi",
            "Di chuyển khó khăn",
            "Di chuyển lảo đảo",
            "Đi tiểu nhiều",
            "Đờm lỏng",
            "Giãn tĩnh máu",
            "Hối hả, lo âu",
            "Hôn mê",
            "Khàn giọng",
            "Khó chịu",
            "Khó chịu bàng quang",
            "Khó chịu hậu môn",
            "Khô môi",
            "Khó tiêu",
            "Không ổn định",
            "Kinh nguyệt thất thường",
            "Lao lực",
            "Lõm nhỏ ở móng tay",
            "Mất cân bằng",
            "Mất khứu giác",
            "Mất tập trung",
            "Mau đói",
            "Mờ mắt",
            "Móng tay giòn",
            "Mụn đầu đen",
            "Mụn mủ",
            "Ngứa bên trong",
            "Nhịp tim cao",
            "Nổi đốm đỏ ",
            "Nói lắp",
            "Nổi tĩnh mạch trên chân",
            "Nổi vảy",
            "Nước tiểu nặng mùi",
            "Nước tiểu vàng",
            "Phân có máu",
            "Phiền muộn",
            "Rối loạn thị giác",
            "Rộp da",
            "Run tay chân",
            "Sốt nhẹ",
            "Sưng hạch bạch huyết",
            "Sưng khớp",
            "Sưng mặt",
            "Sưng tấy",
            "Suy gan cấp",
            "Tắc nghẽn động mạch",
            "Táo bón",
            "Thèm ăn",
            "Tiêu cực",
            "Tiêu thụ đồ uống có cồn",
            "Tràn dịch vị",
            "Tróc da",
            "Trực tràng",
            "Trướng bụng",
            "Trương dạ dày",
            "Từng được truyền máu",
            "Từng tiêm thuốc",
            "Vàng mắt",
            "Viêm họng",
            "Viêm ở móng tay",
            "Viêm xoang",
            "Xì hơi nhiều",
            "Xuất huyết dạ dày",
            "Yếu cơ",
            "Yếu một bên cơ thể"});
            this.dh2.Location = new System.Drawing.Point(302, 94);
            this.dh2.Margin = new System.Windows.Forms.Padding(2);
            this.dh2.Name = "dh2";
            this.dh2.Size = new System.Drawing.Size(187, 23);
            this.dh2.TabIndex = 28;
            this.dh2.SelectedIndexChanged += new System.EventHandler(this.dh2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-2, 328);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 1);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // lbPhongGio
            // 
            this.lbPhongGio.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhongGio.Image = ((System.Drawing.Image)(resources.GetObject("lbPhongGio.Image")));
            this.lbPhongGio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPhongGio.Location = new System.Drawing.Point(305, 189);
            this.lbPhongGio.Name = "lbPhongGio";
            this.lbPhongGio.Size = new System.Drawing.Size(142, 32);
            this.lbPhongGio.TabIndex = 11;
            this.lbPhongGio.Text = "Dấu hiệu 4:";
            this.lbPhongGio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPhongGio.Click += new System.EventHandler(this.lbPhongGio_Click);
            // 
            // lbBacSi
            // 
            this.lbBacSi.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBacSi.Image = ((System.Drawing.Image)(resources.GetObject("lbBacSi.Image")));
            this.lbBacSi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbBacSi.Location = new System.Drawing.Point(27, 197);
            this.lbBacSi.Name = "lbBacSi";
            this.lbBacSi.Size = new System.Drawing.Size(142, 32);
            this.lbBacSi.TabIndex = 8;
            this.lbBacSi.Text = "Dấu hiệu 3:";
            this.lbBacSi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbChuyenKhoa
            // 
            this.lbChuyenKhoa.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChuyenKhoa.Image = ((System.Drawing.Image)(resources.GetObject("lbChuyenKhoa.Image")));
            this.lbChuyenKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbChuyenKhoa.Location = new System.Drawing.Point(305, 56);
            this.lbChuyenKhoa.Name = "lbChuyenKhoa";
            this.lbChuyenKhoa.Size = new System.Drawing.Size(142, 32);
            this.lbChuyenKhoa.TabIndex = 5;
            this.lbChuyenKhoa.Text = "Dấu hiệu 2:";
            this.lbChuyenKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.SeaShell;
            this.linkLabel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.linkLabel2.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Snow;
            this.linkLabel2.Location = new System.Drawing.Point(0, -1);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(560, 72);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Chẩn đoán sơ bộ";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiagnoseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 446);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "DiagnoseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.SystemColors.ButtonHighlight;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbPhongGio;
        private System.Windows.Forms.Label lbBacSi;
        private System.Windows.Forms.Label lbChuyenKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dh1;
        private System.Windows.Forms.ComboBox dh4;
        private System.Windows.Forms.ComboBox dh3;
        private System.Windows.Forms.ComboBox dh2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel result_label;
        private System.Windows.Forms.Button return_button;
    }
}

