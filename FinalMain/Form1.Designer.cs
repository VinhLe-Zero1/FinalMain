namespace FinalMain
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
            this.datlich = new System.Windows.Forms.Button();
            this.tintuc = new System.Windows.Forms.Button();
            this.chuandoan = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cntt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.patient_info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datlich
            // 
            this.datlich.BackColor = System.Drawing.Color.GhostWhite;
            this.datlich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datlich.Location = new System.Drawing.Point(12, 204);
            this.datlich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datlich.Name = "datlich";
            this.datlich.Size = new System.Drawing.Size(255, 100);
            this.datlich.TabIndex = 0;
            this.datlich.TabStop = false;
            this.datlich.Text = "Đặt lịch";
            this.datlich.UseVisualStyleBackColor = false;
            this.datlich.Click += new System.EventHandler(this.button1_Click);
            // 
            // tintuc
            // 
            this.tintuc.BackColor = System.Drawing.Color.GhostWhite;
            this.tintuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tintuc.Location = new System.Drawing.Point(273, 204);
            this.tintuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tintuc.Name = "tintuc";
            this.tintuc.Size = new System.Drawing.Size(255, 100);
            this.tintuc.TabIndex = 1;
            this.tintuc.Text = "Tin tức y tế";
            this.tintuc.UseVisualStyleBackColor = false;
            this.tintuc.Click += new System.EventHandler(this.tintuc_Click);
            // 
            // chuandoan
            // 
            this.chuandoan.BackColor = System.Drawing.Color.GhostWhite;
            this.chuandoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuandoan.Location = new System.Drawing.Point(533, 204);
            this.chuandoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chuandoan.Name = "chuandoan";
            this.chuandoan.Size = new System.Drawing.Size(255, 100);
            this.chuandoan.TabIndex = 2;
            this.chuandoan.Text = "Chuẩn đoán";
            this.chuandoan.UseVisualStyleBackColor = false;
            this.chuandoan.Click += new System.EventHandler(this.chuandoan_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.GhostWhite;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(133, 310);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(255, 100);
            this.button4.TabIndex = 3;
            this.button4.Text = "Lịch sử khám";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cntt
            // 
            this.cntt.BackColor = System.Drawing.Color.GhostWhite;
            this.cntt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntt.Location = new System.Drawing.Point(395, 310);
            this.cntt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cntt.Name = "cntt";
            this.cntt.Size = new System.Drawing.Size(255, 100);
            this.cntt.TabIndex = 4;
            this.cntt.Text = "Cập nhật thông tin";
            this.cntt.UseVisualStyleBackColor = false;
            this.cntt.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 181);
            this.label1.TabIndex = 7;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patient_info
            // 
            this.patient_info.BackColor = System.Drawing.Color.LightSkyBlue;
            this.patient_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_info.ForeColor = System.Drawing.Color.Black;
            this.patient_info.Location = new System.Drawing.Point(505, 12);
            this.patient_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patient_info.Name = "patient_info";
            this.patient_info.Size = new System.Drawing.Size(295, 112);
            this.patient_info.TabIndex = 8;
            this.patient_info.Text = "patient_info_label";
            this.patient_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.patient_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cntt);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chuandoan);
            this.Controls.Add(this.tintuc);
            this.Controls.Add(this.datlich);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button datlich;
        private System.Windows.Forms.Button tintuc;
        private System.Windows.Forms.Button chuandoan;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button cntt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label patient_info;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

