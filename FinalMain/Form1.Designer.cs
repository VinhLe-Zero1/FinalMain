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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // datlich
            // 
            this.datlich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datlich.Location = new System.Drawing.Point(12, 132);
            this.datlich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datlich.Name = "datlich";
            this.datlich.Size = new System.Drawing.Size(255, 100);
            this.datlich.TabIndex = 0;
            this.datlich.TabStop = false;
            this.datlich.Text = "Đặt lịch";
            this.datlich.UseVisualStyleBackColor = true;
            this.datlich.Click += new System.EventHandler(this.button1_Click);
            // 
            // tintuc
            // 
            this.tintuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tintuc.Location = new System.Drawing.Point(273, 132);
            this.tintuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tintuc.Name = "tintuc";
            this.tintuc.Size = new System.Drawing.Size(255, 100);
            this.tintuc.TabIndex = 1;
            this.tintuc.Text = "Tin tức y tế";
            this.tintuc.UseVisualStyleBackColor = true;
            this.tintuc.Click += new System.EventHandler(this.tintuc_Click);
            // 
            // chuandoan
            // 
            this.chuandoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuandoan.Location = new System.Drawing.Point(533, 132);
            this.chuandoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chuandoan.Name = "chuandoan";
            this.chuandoan.Size = new System.Drawing.Size(255, 100);
            this.chuandoan.TabIndex = 2;
            this.chuandoan.Text = "Chẩn đoán";
            this.chuandoan.UseVisualStyleBackColor = true;
            this.chuandoan.Click += new System.EventHandler(this.chuandoan_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(133, 238);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(255, 100);
            this.button4.TabIndex = 3;
            this.button4.Text = "Lịch sử khám";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cntt
            // 
            this.cntt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntt.Location = new System.Drawing.Point(395, 238);
            this.cntt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cntt.Name = "cntt";
            this.cntt.Size = new System.Drawing.Size(255, 100);
            this.cntt.TabIndex = 4;
            this.cntt.Text = "Cập nhật thông tin";
            this.cntt.UseVisualStyleBackColor = true;
            this.cntt.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(-1, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(805, 121);
            this.label2.TabIndex = 7;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(603, 30);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(29, 17);
            this.IDLabel.TabIndex = 9;
            this.IDLabel.Text = "ID: ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(603, 71);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 17);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cntt);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chuandoan);
            this.Controls.Add(this.tintuc);
            this.Controls.Add(this.datlich);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Medical Care";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button datlich;
        private System.Windows.Forms.Button tintuc;
        private System.Windows.Forms.Button chuandoan;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button cntt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}

