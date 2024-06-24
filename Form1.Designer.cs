namespace CSharp_DinhDang_Formater_
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapten = new System.Windows.Forms.TextBox();
            this.grbMau = new System.Windows.Forms.GroupBox();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.grbFont = new System.Windows.Forms.GroupBox();
            this.chkGachchan = new System.Windows.Forms.CheckBox();
            this.chkNghien = new System.Windows.Forms.CheckBox();
            this.chkDam = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbllaptrinh = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbMau.SuspendLayout();
            this.grbFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên";
            // 
            // txtNhapten
            // 
            this.txtNhapten.Location = new System.Drawing.Point(151, 42);
            this.txtNhapten.Name = "txtNhapten";
            this.txtNhapten.Size = new System.Drawing.Size(163, 26);
            this.txtNhapten.TabIndex = 1;
            this.txtNhapten.Text = "Tín";
            this.txtNhapten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grbMau
            // 
            this.grbMau.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grbMau.Controls.Add(this.rdbBlack);
            this.grbMau.Controls.Add(this.rdbBlue);
            this.grbMau.Controls.Add(this.rdbGreen);
            this.grbMau.Controls.Add(this.rdbRed);
            this.grbMau.Location = new System.Drawing.Point(80, 126);
            this.grbMau.Name = "grbMau";
            this.grbMau.Size = new System.Drawing.Size(200, 197);
            this.grbMau.TabIndex = 2;
            this.grbMau.TabStop = false;
            this.grbMau.Text = "Màu";
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Location = new System.Drawing.Point(6, 156);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(59, 22);
            this.rdbBlack.TabIndex = 0;
            this.rdbBlack.TabStop = true;
            this.rdbBlack.Text = "Black";
            this.rdbBlack.UseVisualStyleBackColor = true;
            this.rdbBlack.CheckedChanged += new System.EventHandler(this.rdbBlack_CheckedChanged);
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.ForeColor = System.Drawing.Color.Blue;
            this.rdbBlue.Location = new System.Drawing.Point(6, 115);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(53, 22);
            this.rdbBlue.TabIndex = 0;
            this.rdbBlue.TabStop = true;
            this.rdbBlue.Text = "Blue";
            this.rdbBlue.UseVisualStyleBackColor = true;
            this.rdbBlue.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdbGreen.Location = new System.Drawing.Point(6, 74);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(65, 22);
            this.rdbGreen.TabIndex = 0;
            this.rdbGreen.TabStop = true;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            this.rdbGreen.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.ForeColor = System.Drawing.Color.Red;
            this.rdbRed.Location = new System.Drawing.Point(6, 33);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(51, 22);
            this.rdbRed.TabIndex = 0;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Red";
            this.rdbRed.UseVisualStyleBackColor = true;
            this.rdbRed.CheckedChanged += new System.EventHandler(this.rdbRed_CheckedChanged);
            // 
            // grbFont
            // 
            this.grbFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grbFont.Controls.Add(this.chkGachchan);
            this.grbFont.Controls.Add(this.chkNghien);
            this.grbFont.Controls.Add(this.chkDam);
            this.grbFont.Location = new System.Drawing.Point(394, 126);
            this.grbFont.Name = "grbFont";
            this.grbFont.Size = new System.Drawing.Size(322, 197);
            this.grbFont.TabIndex = 3;
            this.grbFont.TabStop = false;
            this.grbFont.Text = "Font";
            // 
            // chkGachchan
            // 
            this.chkGachchan.AutoSize = true;
            this.chkGachchan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGachchan.ForeColor = System.Drawing.Color.Blue;
            this.chkGachchan.Location = new System.Drawing.Point(22, 156);
            this.chkGachchan.Name = "chkGachchan";
            this.chkGachchan.Size = new System.Drawing.Size(119, 27);
            this.chkGachchan.TabIndex = 0;
            this.chkGachchan.Text = "Gạch chân";
            this.chkGachchan.UseVisualStyleBackColor = true;
            this.chkGachchan.CheckedChanged += new System.EventHandler(this.chkGachchan_CheckedChanged);
            // 
            // chkNghien
            // 
            this.chkNghien.AutoSize = true;
            this.chkNghien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNghien.ForeColor = System.Drawing.Color.Blue;
            this.chkNghien.Location = new System.Drawing.Point(22, 94);
            this.chkNghien.Name = "chkNghien";
            this.chkNghien.Size = new System.Drawing.Size(135, 27);
            this.chkNghien.TabIndex = 0;
            this.chkNghien.Text = "Nghiên Italic";
            this.chkNghien.UseVisualStyleBackColor = true;
            this.chkNghien.CheckedChanged += new System.EventHandler(this.chkNghien_CheckedChanged);
            // 
            // chkDam
            // 
            this.chkDam.AutoSize = true;
            this.chkDam.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDam.ForeColor = System.Drawing.Color.Blue;
            this.chkDam.Location = new System.Drawing.Point(22, 33);
            this.chkDam.Name = "chkDam";
            this.chkDam.Size = new System.Drawing.Size(110, 27);
            this.chkDam.TabIndex = 0;
            this.chkDam.Text = "Đậm Bold";
            this.chkDam.UseVisualStyleBackColor = true;
            this.chkDam.CheckedChanged += new System.EventHandler(this.chkDam_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lập trình bởi";
            // 
            // lbllaptrinh
            // 
            this.lbllaptrinh.AutoSize = true;
            this.lbllaptrinh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbllaptrinh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllaptrinh.Location = new System.Drawing.Point(159, 390);
            this.lbllaptrinh.Name = "lbllaptrinh";
            this.lbllaptrinh.Size = new System.Drawing.Size(36, 23);
            this.lbllaptrinh.TabIndex = 4;
            this.lbllaptrinh.Text = "Tín";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(416, 362);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(286, 75);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 623);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lbllaptrinh);
            this.Controls.Add(this.grbFont);
            this.Controls.Add(this.grbMau);
            this.Controls.Add(this.txtNhapten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbMau.ResumeLayout(false);
            this.grbMau.PerformLayout();
            this.grbFont.ResumeLayout(false);
            this.grbFont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapten;
        private System.Windows.Forms.GroupBox grbMau;
        private System.Windows.Forms.RadioButton rdbBlack;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.GroupBox grbFont;
        private System.Windows.Forms.CheckBox chkGachchan;
        private System.Windows.Forms.CheckBox chkNghien;
        private System.Windows.Forms.CheckBox chkDam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbllaptrinh;
        private System.Windows.Forms.Button btnThoat;
    }
}

