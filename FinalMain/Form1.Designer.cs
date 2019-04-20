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
            this.datlich = new System.Windows.Forms.Button();
            this.tintuc = new System.Windows.Forms.Button();
            this.chuandoan = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cntt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datlich
            // 
            this.datlich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datlich.Location = new System.Drawing.Point(12, 132);
            this.datlich.Name = "datlich";
            this.datlich.Size = new System.Drawing.Size(255, 100);
            this.datlich.TabIndex = 0;
            this.datlich.Text = "Đặt lịch";
            this.datlich.UseVisualStyleBackColor = true;
            this.datlich.Click += new System.EventHandler(this.button1_Click);
            // 
            // tintuc
            // 
            this.tintuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tintuc.Location = new System.Drawing.Point(273, 132);
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
            this.chuandoan.Location = new System.Drawing.Point(534, 132);
            this.chuandoan.Name = "chuandoan";
            this.chuandoan.Size = new System.Drawing.Size(255, 100);
            this.chuandoan.TabIndex = 2;
            this.chuandoan.Text = "Chuẩn đoán";
            this.chuandoan.UseVisualStyleBackColor = true;
            this.chuandoan.Click += new System.EventHandler(this.chuandoan_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(134, 238);
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
            this.cntt.Name = "cntt";
            this.cntt.Size = new System.Drawing.Size(255, 100);
            this.cntt.TabIndex = 4;
            this.cntt.Text = "Cập nhật thông tin";
            this.cntt.UseVisualStyleBackColor = true;
            this.cntt.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.cntt);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chuandoan);
            this.Controls.Add(this.tintuc);
            this.Controls.Add(this.datlich);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button datlich;
        private System.Windows.Forms.Button tintuc;
        private System.Windows.Forms.Button chuandoan;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button cntt;
    }
}

