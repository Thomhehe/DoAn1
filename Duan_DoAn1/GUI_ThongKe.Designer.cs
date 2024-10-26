namespace DoAn1
{
    partial class GUI_ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbldonhang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbldoanhthu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblloinhuan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vbtnthangnay = new DoAn1.VBButton();
            this.vbtn30ntr = new DoAn1.VBButton();
            this.vbtn7ntr = new DoAn1.VBButton();
            this.vbtnhnay = new DoAn1.VBButton();
            this.vbtncustom = new DoAn1.VBButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 205);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(689, 267);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(725, 276);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(418, 352);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.lbldonhang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(307, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 76);
            this.panel1.TabIndex = 2;
            // 
            // lbldonhang
            // 
            this.lbldonhang.AutoSize = true;
            this.lbldonhang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldonhang.Location = new System.Drawing.Point(61, 45);
            this.lbldonhang.Name = "lbldonhang";
            this.lbldonhang.Size = new System.Drawing.Size(24, 27);
            this.lbldonhang.TabIndex = 9;
            this.lbldonhang.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số đơn hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.lbldoanhthu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(592, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 76);
            this.panel2.TabIndex = 3;
            // 
            // lbldoanhthu
            // 
            this.lbldoanhthu.AutoSize = true;
            this.lbldoanhthu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoanhthu.Location = new System.Drawing.Point(64, 41);
            this.lbldoanhthu.Name = "lbldoanhthu";
            this.lbldoanhthu.Size = new System.Drawing.Size(24, 27);
            this.lbldoanhthu.TabIndex = 11;
            this.lbldoanhthu.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Doanh thu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.lblloinhuan);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(877, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 76);
            this.panel3.TabIndex = 3;
            // 
            // lblloinhuan
            // 
            this.lblloinhuan.AutoSize = true;
            this.lblloinhuan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloinhuan.Location = new System.Drawing.Point(64, 42);
            this.lblloinhuan.Name = "lblloinhuan";
            this.lblloinhuan.Size = new System.Drawing.Size(24, 27);
            this.lblloinhuan.TabIndex = 12;
            this.lblloinhuan.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lợi nhuận";
            // 
            // vbtnthangnay
            // 
            this.vbtnthangnay.BackColor = System.Drawing.Color.MistyRose;
            this.vbtnthangnay.BackgroundColor = System.Drawing.Color.MistyRose;
            this.vbtnthangnay.BorderColor = System.Drawing.Color.LightSalmon;
            this.vbtnthangnay.BorderRadius = 0;
            this.vbtnthangnay.BorderSize = 2;
            this.vbtnthangnay.FlatAppearance.BorderSize = 0;
            this.vbtnthangnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbtnthangnay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtnthangnay.ForeColor = System.Drawing.Color.Black;
            this.vbtnthangnay.Location = new System.Drawing.Point(994, 0);
            this.vbtnthangnay.Name = "vbtnthangnay";
            this.vbtnthangnay.Size = new System.Drawing.Size(162, 47);
            this.vbtnthangnay.TabIndex = 4;
            this.vbtnthangnay.Text = "Tháng này";
            this.vbtnthangnay.TextColor = System.Drawing.Color.Black;
            this.vbtnthangnay.UseVisualStyleBackColor = false;
            this.vbtnthangnay.Click += new System.EventHandler(this.vbtnthangnay_Click);
            // 
            // vbtn30ntr
            // 
            this.vbtn30ntr.BackColor = System.Drawing.Color.MistyRose;
            this.vbtn30ntr.BackgroundColor = System.Drawing.Color.MistyRose;
            this.vbtn30ntr.BorderColor = System.Drawing.Color.LightSalmon;
            this.vbtn30ntr.BorderRadius = 0;
            this.vbtn30ntr.BorderSize = 2;
            this.vbtn30ntr.FlatAppearance.BorderSize = 0;
            this.vbtn30ntr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbtn30ntr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtn30ntr.ForeColor = System.Drawing.Color.Black;
            this.vbtn30ntr.Location = new System.Drawing.Point(827, 0);
            this.vbtn30ntr.Name = "vbtn30ntr";
            this.vbtn30ntr.Size = new System.Drawing.Size(171, 47);
            this.vbtn30ntr.TabIndex = 5;
            this.vbtn30ntr.Text = "30 ngày trước";
            this.vbtn30ntr.TextColor = System.Drawing.Color.Black;
            this.vbtn30ntr.UseVisualStyleBackColor = false;
            this.vbtn30ntr.Click += new System.EventHandler(this.vbtn30ntr_Click);
            // 
            // vbtn7ntr
            // 
            this.vbtn7ntr.BackColor = System.Drawing.Color.MistyRose;
            this.vbtn7ntr.BackgroundColor = System.Drawing.Color.MistyRose;
            this.vbtn7ntr.BorderColor = System.Drawing.Color.LightSalmon;
            this.vbtn7ntr.BorderRadius = 0;
            this.vbtn7ntr.BorderSize = 2;
            this.vbtn7ntr.FlatAppearance.BorderSize = 0;
            this.vbtn7ntr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbtn7ntr.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.vbtn7ntr.ForeColor = System.Drawing.Color.Black;
            this.vbtn7ntr.Location = new System.Drawing.Point(653, 0);
            this.vbtn7ntr.Name = "vbtn7ntr";
            this.vbtn7ntr.Size = new System.Drawing.Size(178, 47);
            this.vbtn7ntr.TabIndex = 6;
            this.vbtn7ntr.Text = "7 ngày trước";
            this.vbtn7ntr.TextColor = System.Drawing.Color.Black;
            this.vbtn7ntr.UseVisualStyleBackColor = false;
            this.vbtn7ntr.Click += new System.EventHandler(this.vbtn7ntr_Click);
            // 
            // vbtnhnay
            // 
            this.vbtnhnay.BackColor = System.Drawing.Color.MistyRose;
            this.vbtnhnay.BackgroundColor = System.Drawing.Color.MistyRose;
            this.vbtnhnay.BorderColor = System.Drawing.Color.LightSalmon;
            this.vbtnhnay.BorderRadius = 0;
            this.vbtnhnay.BorderSize = 2;
            this.vbtnhnay.FlatAppearance.BorderSize = 0;
            this.vbtnhnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbtnhnay.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.vbtnhnay.ForeColor = System.Drawing.Color.Black;
            this.vbtnhnay.Location = new System.Drawing.Point(485, 0);
            this.vbtnhnay.Name = "vbtnhnay";
            this.vbtnhnay.Size = new System.Drawing.Size(172, 47);
            this.vbtnhnay.TabIndex = 7;
            this.vbtnhnay.Text = "Hôm nay";
            this.vbtnhnay.TextColor = System.Drawing.Color.Black;
            this.vbtnhnay.UseVisualStyleBackColor = false;
            this.vbtnhnay.Click += new System.EventHandler(this.vbtnhnay_Click);
            // 
            // vbtncustom
            // 
            this.vbtncustom.BackColor = System.Drawing.Color.MistyRose;
            this.vbtncustom.BackgroundColor = System.Drawing.Color.MistyRose;
            this.vbtncustom.BorderColor = System.Drawing.Color.LightSalmon;
            this.vbtncustom.BorderRadius = 0;
            this.vbtncustom.BorderSize = 2;
            this.vbtncustom.FlatAppearance.BorderSize = 0;
            this.vbtncustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbtncustom.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.vbtncustom.ForeColor = System.Drawing.Color.Black;
            this.vbtncustom.Location = new System.Drawing.Point(307, 0);
            this.vbtncustom.Name = "vbtncustom";
            this.vbtncustom.Size = new System.Drawing.Size(181, 47);
            this.vbtncustom.TabIndex = 8;
            this.vbtncustom.Text = "Custom";
            this.vbtncustom.TextColor = System.Drawing.Color.Black;
            this.vbtncustom.UseVisualStyleBackColor = false;
            this.vbtncustom.Click += new System.EventHandler(this.vbtncustom_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(47, 75);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(780, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sản phẩm bán chạy nhất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Doanh thu theo ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(393, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sản phẩm bán được nhiều nhất";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(1, 540);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(718, 163);
            this.panel4.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(689, 151);
            this.dataGridView1.TabIndex = 12;
            // 
            // GUI_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn1.Properties.Resources.background___form;
            this.ClientSize = new System.Drawing.Size(1155, 703);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.vbtncustom);
            this.Controls.Add(this.vbtnhnay);
            this.Controls.Add(this.vbtn7ntr);
            this.Controls.Add(this.vbtn30ntr);
            this.Controls.Add(this.vbtnthangnay);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "GUI_ThongKe";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.GUI_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private VBButton vbtnthangnay;
        private VBButton vbtn30ntr;
        private VBButton vbtn7ntr;
        private VBButton vbtnhnay;
        private VBButton vbtncustom;
        private System.Windows.Forms.Label lbldonhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldoanhthu;
        private System.Windows.Forms.Label lblloinhuan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}