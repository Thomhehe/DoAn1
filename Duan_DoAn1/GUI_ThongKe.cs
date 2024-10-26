using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAn1
{
    public partial class GUI_ThongKe : Form
    {
        BUS_ThongKe bus_thongke = new BUS_ThongKe();
        public GUI_ThongKe()
        {
            InitializeComponent();
        }

        private void GUI_ThongKe_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            SetData(today, today);
        }

        private void SetData(DateTime startDate, DateTime endDate)
        {
            DataTable salesAndPurchaseData = bus_thongke.LayDoanhThu(startDate, endDate);

            if (salesAndPurchaseData.Rows.Count == 0)
            {
                return;
            }
            chart1.Series.Clear();

            var seriesSales = new Series
            {
                Name = "Sales",
                ChartType = SeriesChartType.Column
            };

            var seriesPurchase = new Series
            {
                Name = "Purchase",
                ChartType = SeriesChartType.Column
            };

            chart1.Series.Add(seriesSales);
            chart1.Series.Add(seriesPurchase);

            foreach (DataRow row in salesAndPurchaseData.Rows)
            {
                seriesSales.Points.AddXY(row["Date"], row["TotalSalesAmount"]);
                seriesPurchase.Points.AddXY(row["Date"], row["TotalPurchaseAmount"]);
            }

            DataTable bestSellingProducts = bus_thongke.SanPhamBanChay(startDate, endDate);




            chart2.Series[0].Points.Clear();
            foreach (DataRow row in bestSellingProducts.Rows)
            {
                chart2.Series[0].Points.AddXY(row["TenSP"], row["TongBan"]);
            }


            DataTable leastSellingProducts = bus_thongke.SanPhamTonKho(startDate, endDate);

            dataGridView1.DataSource = leastSellingProducts;


            int donHang = bus_thongke.SoDonHang(startDate, endDate);
            lbldonhang.Text = donHang.ToString();

            decimal doanhThu = bus_thongke.GetTongDoanhThu(startDate, endDate);
            lbldoanhthu.Text = doanhThu.ToString("C");

            decimal loiNhuan = bus_thongke.GetTongLoiNhuan(startDate, endDate);
            lblloinhuan.Text = loiNhuan.ToString("C");
        }

        private void vbtncustom_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            SetData(startDate, endDate);
        }

        private void vbtnhnay_Click(object sender, EventArgs e)
        {
            DateTime Today = DateTime.Today;
            SetData(Today, Today);
        }

        private void vbtn7ntr_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Today.AddDays(-7);
            DateTime endDate = DateTime.Today;
            SetData(startDate, endDate);
        }

        private void vbtn30ntr_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Today.AddDays(-7);
            DateTime endDate = DateTime.Today;
            SetData(startDate, endDate);
        }

        private void vbtnthangnay_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime endDate = DateTime.Today;
            SetData(startDate, endDate);
        }
    }
}
