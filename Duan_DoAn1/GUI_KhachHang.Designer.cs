﻿namespace DoAn1
{
    partial class GUI_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_KhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvkh = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbnu = new System.Windows.Forms.RadioButton();
            this.rdbnam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.vbtnlammoi = new DoAn1.VBButton();
            this.vbtnxoa = new DoAn1.VBButton();
            this.vbtnsua = new DoAn1.VBButton();
            this.vbtnthem = new DoAn1.VBButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dgvkh);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 285);
            this.panel2.TabIndex = 1;
            // 
            // dgvkh
            // 
            this.dgvkh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvkh.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkh.Location = new System.Drawing.Point(12, 6);
            this.dgvkh.Name = "dgvkh";
            this.dgvkh.RowHeadersWidth = 62;
            this.dgvkh.RowTemplate.Height = 28;
            this.dgvkh.Size = new System.Drawing.Size(1131, 276);
            this.dgvkh.TabIndex = 0;
            this.dgvkh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkh_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(0, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1155, 233);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txttenkh);
            this.groupBox1.Controls.Add(this.txtmakh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rdbnu);
            this.groupBox1.Controls.Add(this.rdbnam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.ForeColor = System.Drawing.Color.Black;
            this.txtdiachi.Location = new System.Drawing.Point(470, 167);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(595, 37);
            this.txtdiachi.TabIndex = 13;
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.ForeColor = System.Drawing.Color.Black;
            this.txtsdt.Location = new System.Drawing.Point(75, 167);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(319, 37);
            this.txtsdt.TabIndex = 12;
            // 
            // txttenkh
            // 
            this.txttenkh.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenkh.ForeColor = System.Drawing.Color.Black;
            this.txttenkh.Location = new System.Drawing.Point(471, 78);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(319, 37);
            this.txttenkh.TabIndex = 11;
            // 
            // txtmakh
            // 
            this.txtmakh.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakh.ForeColor = System.Drawing.Color.Black;
            this.txtmakh.Location = new System.Drawing.Point(75, 78);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(319, 37);
            this.txtmakh.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(465, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(919, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giới tính";
            // 
            // rdbnu
            // 
            this.rdbnu.AutoSize = true;
            this.rdbnu.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbnu.Location = new System.Drawing.Point(994, 83);
            this.rdbnu.Name = "rdbnu";
            this.rdbnu.Size = new System.Drawing.Size(71, 33);
            this.rdbnu.TabIndex = 7;
            this.rdbnu.TabStop = true;
            this.rdbnu.Text = "Nữ";
            this.rdbnu.UseVisualStyleBackColor = true;
            // 
            // rdbnam
            // 
            this.rdbnam.AutoSize = true;
            this.rdbnam.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbnam.Location = new System.Drawing.Point(876, 83);
            this.rdbnam.Name = "rdbnam";
            this.rdbnam.Size = new System.Drawing.Size(89, 33);
            this.rdbnam.TabIndex = 6;
            this.rdbnam.TabStop = true;
            this.rdbnam.Text = "Nam";
            this.rdbnam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(465, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã KH";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.txttimkiem);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(0, 336);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1155, 55);
            this.panel4.TabIndex = 3;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.ForeColor = System.Drawing.Color.Black;
            this.txttimkiem.Location = new System.Drawing.Point(601, 6);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(541, 37);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.vbtnlammoi);
            this.panel5.Controls.Add(this.vbtnxoa);
            this.panel5.Controls.Add(this.vbtnsua);
            this.panel5.Controls.Add(this.vbtnthem);
            this.panel5.Location = new System.Drawing.Point(0, 624);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1155, 79);
            this.panel5.TabIndex = 4;
            // 
            // vbtnlammoi
            // 
            this.vbtnlammoi.BackColor = System.Drawing.Color.MistyRose;
            this.vbtnlammoi.BackgroundColor = System.Drawing.Color.MistyRose;
            this.vbtnlammoi.BorderColor = System.Drawing.Color.LightSalmon;
            this.vbtnlammoi.BorderRadius = 10;
            this.vbtnlammoi.BorderSize = 2;
            this.vbtnlammoi.FlatAppearance.BorderSize = 0;
            this.vbtnlammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbtnlammoi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtnlammoi.ForeColor = System.Drawing.Color.Black;
            this.vbtnlammoi.Image = ((System.Drawing.Image)(resources.GetObject("vbtnlammoi.Image")));
            this.vbtnlammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vbtnlammoi.Location = new System.Drawing.Point(175, 12);
            this.vbtnlammoi.Name = "vbtnlammoi";
            this.vbtnlammoi.Size = new System.Drawing.Size(180, 57);
            this.vbtnlammoi.TabIndex = 7;
            this.vbtnlammoi.Text = "Làm mới";
            this.vbtnlammoi.TextColor = System.Drawing.Color.Black;
            this.vbtnlammoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vbtnlammoi.UseVisualStyleBackColor = false;
            this.vbtnlammoi.Click += new System.EventHandler(this.vbtnlammoi_Click);
            // 
            // vbtnxoa
            // 
            this.vbtnxoa.BackColor = System.Drawing.Color.MistyRose;
            this.vbtnxoa.BackgroundColor = System.Drawing.Color.MistyRose;
            this.vbtnxoa.BorderColor = System.Drawing.Color.LightSalmon;
            this.vbtnxoa.BorderRadius = 10;
            this.vbtnxoa.BorderSize = 2;
            this.vbtnxoa.FlatAppearance.BorderSize = 0;
            this.vbtnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbtnxoa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtnxoa.ForeColor = System.Drawing.Color.Black;
            this.vbtnxoa.Image = ((System.Drawing.Image)(resources.GetObject("vbtnxoa.Image")));
            this.vbtnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vbtnxoa.Location = new System.Drawing.Point(800, 12);
            this.vbtnxoa.Name = "vbtnxoa";
            this.vbtnxoa.Size = new System.Drawing.Size(171, 57);
            this.vbtnxoa.TabIndex = 6;
            this.vbtnxoa.Text = "Xóa";
            this.vbtnxoa.TextColor = System.Drawing.Color.Black;
            this.vbtnxoa.UseVisualStyleBackColor = false;
            this.vbtnxoa.Click += new System.EventHandler(this.vbtnxoa_Click);
            // 
            // vbtnsua
            // 
            this.vbtnsua.BackColor = System.Drawing.Color.MistyRose;
            this.vbtnsua.BackgroundColor = System.Drawing.Color.MistyRose;
            this.vbtnsua.BorderColor = System.Drawing.Color.LightSalmon;
            this.vbtnsua.BorderRadius = 10;
            this.vbtnsua.BorderSize = 2;
            this.vbtnsua.FlatAppearance.BorderSize = 0;
            this.vbtnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbtnsua.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtnsua.ForeColor = System.Drawing.Color.Black;
            this.vbtnsua.Image = ((System.Drawing.Image)(resources.GetObject("vbtnsua.Image")));
            this.vbtnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vbtnsua.Location = new System.Drawing.Point(593, 12);
            this.vbtnsua.Name = "vbtnsua";
            this.vbtnsua.Size = new System.Drawing.Size(171, 57);
            this.vbtnsua.TabIndex = 5;
            this.vbtnsua.Text = "Sửa";
            this.vbtnsua.TextColor = System.Drawing.Color.Black;
            this.vbtnsua.UseVisualStyleBackColor = false;
            this.vbtnsua.Click += new System.EventHandler(this.vbtnsua_Click);
            // 
            // vbtnthem
            // 
            this.vbtnthem.BackColor = System.Drawing.Color.MistyRose;
            this.vbtnthem.BackgroundColor = System.Drawing.Color.MistyRose;
            this.vbtnthem.BorderColor = System.Drawing.Color.LightSalmon;
            this.vbtnthem.BorderRadius = 10;
            this.vbtnthem.BorderSize = 2;
            this.vbtnthem.FlatAppearance.BorderSize = 0;
            this.vbtnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbtnthem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtnthem.ForeColor = System.Drawing.Color.Black;
            this.vbtnthem.Image = ((System.Drawing.Image)(resources.GetObject("vbtnthem.Image")));
            this.vbtnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vbtnthem.Location = new System.Drawing.Point(386, 12);
            this.vbtnthem.Name = "vbtnthem";
            this.vbtnthem.Size = new System.Drawing.Size(171, 57);
            this.vbtnthem.TabIndex = 4;
            this.vbtnthem.Text = "Thêm";
            this.vbtnthem.TextColor = System.Drawing.Color.Black;
            this.vbtnthem.UseVisualStyleBackColor = false;
            this.vbtnthem.Click += new System.EventHandler(this.vbtnthem_Click);
            // 
            // GUI_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::DoAn1.Properties.Resources.background___form;
            this.ClientSize = new System.Drawing.Size(1155, 703);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_KhachHang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.GUI_KhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvkh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbnam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbnu;
        private System.Windows.Forms.Label label7;
        private VBButton vbtnlammoi;
        private VBButton vbtnxoa;
        private VBButton vbtnsua;
        private VBButton vbtnthem;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txttenkh;
    }
}