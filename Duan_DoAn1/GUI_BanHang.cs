using BUS;
using DoAn1.Properties;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DoAn1
{
    public partial class GUI_BanHang : Form
    {
        BUS_HDB bus_hdb = new BUS_HDB();
        BUS_BanHang bus_bh = new BUS_BanHang();
        DataTable dtNhanVien;
        DataTable dtKhachHang;
        DataTable dtSanPham;
        float tongTien = 0;
        public GUI_BanHang()
        {
            InitializeComponent();
            loadkh();
            loadsp();
            loadnv();
        }
        void loadnv()
        {
            dtNhanVien = bus_bh.GetNhanVien();
            cbomanv.DataSource = dtNhanVien;
            cbomanv.DisplayMember = "MaNhanVien";
            cbomanv.ValueMember = "TenNV";

            cbotennv.DataSource = dtNhanVien;
            cbotennv.DisplayMember = "TenNV";
            cbotennv.ValueMember = "MaNV";
        }
        void loadkh()
        {
            dtKhachHang = bus_bh.GetKhachHang();
            cbotenkh.DataSource = dtKhachHang;
            cbotenkh.DisplayMember = "TenKH";
            cbotenkh.ValueMember = "MaKH";

            cbomakh.DataSource = dtKhachHang;
            cbomakh.DisplayMember = "MaKH";
            cbomakh.ValueMember = "TenKH";
        }
        void loadsp()
        {
            dtSanPham = bus_bh.GetSanPham();
            cbotensp.DataSource = dtSanPham;
            cbotensp.DisplayMember = "TenSP";
            cbotensp.ValueMember = "MaSP";

            cbomasp.DataSource = dtSanPham;
            cbomasp.DisplayMember = "MaSP";
            cbomasp.ValueMember = "TenSP";
        }

        void loadhdb()
        {
            DataTable dt = bus_hdb.getHDB();
            dgvhdb.DataSource = dt;
            dgvhdb.Columns[0].HeaderText = "Mã hóa đơn";
            dgvhdb.Columns[1].HeaderText = "Mã nhân viên";
            dgvhdb.Columns[2].HeaderText = "Mã khách hàng";
            dgvhdb.Columns[3].HeaderText = "Ngày mua";
            dgvhdb.Columns[4].HeaderText = "Tổng tiền";
        }
        void loadcthdb(string maHDB)
        {
            DataTable dt = bus_hdb.getCTHDB(maHDB);
            dgvcthdb.DataSource = dt;
            dgvcthdb.Columns[0].HeaderText = "Mã hóa đơn";
            dgvcthdb.Columns[1].HeaderText = "Mã sản phẩm";
            dgvcthdb.Columns[2].HeaderText = "Số lượng";
            dgvcthdb.Columns[3].HeaderText = "Đơn giá";
            dgvcthdb.Columns[4].HeaderText = "Thành tiền";
        }

        // tabControl2

        private void dgvhdb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txthdxoa.Text = dgvhdb[0, i].Value.ToString().Trim();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvhdb.Rows[e.RowIndex];
                string maHDB = row.Cells["MaHDB"].Value.ToString();
                loadcthdb(maHDB);
            }
        }

            // tabControl2

        private void GUI_BanHang_Load(object sender, EventArgs e)
        {

            loadhdb();
            dgvhdb.CellClick += dgvhdb_CellClick;


            cbomakh.Text = string.Empty;
            cbotenkh.Text = string.Empty;
            cbomanv.Text = string.Empty;
            cbotennv.Text = string.Empty;
            cbomasp.Text = string.Empty;
            cbotensp.Text = string.Empty;
            txtgia.Text = string.Empty;
        }

        private void vbtnxoa_Click(object sender, EventArgs e)
        {
            string maHDB = txthdxoa.Text;
            if (!string.IsNullOrEmpty(maHDB))
            {
                if (bus_hdb.XoaHoaDon(maHDB))
                {
                    MessageBox.Show("Xóa hóa đơn thành công!");
                    loadhdb();
                    loadcthdb(maHDB);
                    // Thực hiện các hành động cần thiết sau khi xóa, nếu có
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!");
            }
        }

        private void vbtntim_Click(object sender, EventArgs e)
        {
            string keyword = txttimkiem.Text.Trim();
            DataTable dt = bus_hdb.TimKiemHoaDonBan(keyword);
            dgvhdb.DataSource = dt;
        }


        private void InitializeDgvspColumns()
        {
            if (dgvsp.Columns.Count == 0)
            {
                dgvsp.Columns.Add("MaHDB", "MaHDB");
                dgvsp.Columns.Add("MaNV", "MaNV");
                dgvsp.Columns.Add("MaKH", "MaKH");
                dgvsp.Columns.Add("MaSP", "MaSP");
                dgvsp.Columns.Add("TenSP", "TenSP");
                dgvsp.Columns.Add("Soluongban", "Soluongban");
                dgvsp.Columns.Add("Dongia", "Dongia");
                dgvsp.Columns.Add("Thanhtien", "Thanhtien");
            }
        }

        private void cbomanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNV = cbomanv.SelectedValue.ToString();
            DataRow[] rows = dtNhanVien.Select($"MaNV = '{maNV}'");
            if (rows.Length > 0)
            {
                cbotennv.Text = rows[0]["TenNV"].ToString();
            }
        }

        private void cbotenkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cbotenkh.SelectedItem;

            // Lấy mã khách hàng tương ứng và cập nhật giá trị của combobox mã khách hàng
            string maKH = row["MaKH"].ToString();
            cbomakh.SelectedValue = maKH;
        }

        private void cbotensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cbotensp.SelectedItem;
            txtgia.Text = row["Gia"].ToString();

            // Lấy mã sản phẩm tương ứng và cập nhật giá trị của combobox mã sản phẩm
            string maSP = row["MaSP"].ToString();
            cbomasp.SelectedValue = maSP;
        }
        private void cbomakh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy mã khách hàng được chọn và cập nhật giá trị của combobox tên khách hàng
            string maKH = cbomakh.SelectedValue.ToString();
            DataRow[] rows = dtKhachHang.Select($"MaKH = '{maKH}'");
            if (rows.Length > 0)
            {
                cbotenkh.Text = rows[0]["TenKH"].ToString();
            }
        }

        private void cbomasp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy mã sản phẩm được chọn và cập nhật giá trị của combobox tên sản phẩm
            string maSP = cbomasp.SelectedValue.ToString();
            DataRow[] rows = dtSanPham.Select($"MaSP = '{maSP}'");
            if (rows.Length > 0)
            {
                cbotensp.Text = rows[0]["TenSP"].ToString();
                txtgia.Text = rows[0]["Gia"].ToString();
            }
        }

        private void vbtnthem_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            float gia;
            bool isParsed = float.TryParse(txtgia.Text, out gia);
            int sluong;
            bool isParsed1 = int.TryParse(txtsl.Text, out sluong);
            if (bus_bh.kiemtramatrung(txtmahd.Text) == 1)
            {
                MessageBox.Show("Mã hóa đơn này đã tồn tại!! Vui lòng nhập lại mã.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (string.IsNullOrEmpty(txtmahd.Text) || string.IsNullOrEmpty(cbomanv.Text)
                    || string.IsNullOrEmpty(cbotennv.Text) || string.IsNullOrEmpty(cbomakh.Text)
                    || string.IsNullOrEmpty(cbotenkh.Text) || string.IsNullOrEmpty(cbomasp.Text)
                    || string.IsNullOrEmpty(cbotensp.Text) || string.IsNullOrEmpty(txtsl.Text)
                    || string.IsNullOrEmpty(txtgia.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!isParsed || gia <= 0)
            {
                MessageBox.Show("Giá phải là một số hợp lệ lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng thực hiện tiếp
            }
            sp.Gia = gia;
            if (!isParsed1 || sluong <= 0)
            {
                MessageBox.Show("Số lượng phải là một số hợp lệ lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng thực hiện tiếp
            }
            sp.Soluong = sluong;

            string maSP = cbotensp.SelectedValue.ToString();
            string tenSP = cbotensp.Text;
            int soLuongBan = int.Parse(txtsl.Text);
            float donGia = float.Parse(txtgia.Text);
            float thanhTien = soLuongBan * donGia;


            InitializeDgvspColumns();
            dgvsp.Rows.Add(txtmahd.Text, cbomanv.SelectedValue.ToString(), cbomakh.SelectedValue, maSP, tenSP, soLuongBan, donGia, thanhTien);
            tongTien += thanhTien;
            float tongTienFloat = float.Parse(tongTien.ToString());
            txttongtien.Text = tongTienFloat.ToString();

            // Làm mới các trường thông tin sản phẩm
            txtsl.Clear();
            txtgia.Clear();
            txtthanhtien.Clear();
        }

        private void dgvsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmahd.Text = dgvhdb[0, i].Value.ToString().Trim();
            cbomanv.Text = dgvhdb[1, i].Value.ToString().Trim();
            cbomakh.Text = dgvhdb[2, i].Value.ToString().Trim();
            cbomasp.Text = dgvhdb[3, i].Value.ToString().Trim();
            cbotensp.Text = dgvhdb[4, i].Value.ToString().Trim();
            txtsl.Text = dgvhdb[5, i].Value.ToString().Trim();
            txtgia.Text = dgvhdb[6, i].Value.ToString().Trim();
            txtthanhtien.Text = dgvhdb[7, i].Value.ToString().Trim();
        }

        private void vbtnxoasp_Click(object sender, EventArgs e)
        {
            if (dgvsp.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvsp.SelectedRows[0];
                float deletedProductTotal = Convert.ToSingle(selectedRow.Cells["Thanhtien"].Value);
                tongTien -= deletedProductTotal;
                txttongtien.Text = tongTien.ToString();

                dgvsp.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void vbtnlendon_Click(object sender, EventArgs e)
        {
            String maHDB = txtmahd.Text;
            String maNV = cbomanv.Text;
            String maKH = cbomakh.Text;
            if (bus_bh.InsertHoadonban(maHDB, maNV, maKH, tongTien))
            {
                foreach (DataGridViewRow row in dgvsp.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string maSP = row.Cells["MaSP"].Value.ToString();
                        int soLuongBan = int.Parse(row.Cells["Soluongban"].Value.ToString());
                        float donGia = float.Parse(row.Cells["Dongia"].Value.ToString());
                        float thanhTien = float.Parse(row.Cells["Thanhtien"].Value.ToString());

                        bus_bh.InsertChitiethoadonban(maHDB, maSP, soLuongBan, donGia, thanhTien);
                        loadcthdb(maHDB);

                        TruSoLuongSanPham(maSP, soLuongBan);
                    }
                }
                MessageBox.Show("Lưu hóa đơn thành công!");
                loadhdb();
            }
            else
            {
                MessageBox.Show("Lưu hóa đơn thất bại!");
            }
        }

        private void TruSoLuongSanPham(string maSP, int soLuongBan)
        {
            // Lấy số lượng sản phẩm hiện tại từ bảng sản phẩm
            int soLuongHienTai = bus_bh.LaySoLuongSanPham(maSP);

            // Trừ số lượng mua từ số lượng sản phẩm hiện tại
            int soLuongConLai = soLuongHienTai - soLuongBan;

            // Cập nhật số lượng mới vào bảng sản phẩm
            bus_bh.CapNhatSoLuongSanPham(maSP, soLuongConLai);
        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem cả hai trường số lượng và giá có dữ liệu không
            if (!string.IsNullOrEmpty(txtsl.Text) && !string.IsNullOrEmpty(txtgia.Text))
            {
                // Kiểm tra xem dữ liệu nhập vào có phải là số không
                if (int.TryParse(txtsl.Text, out int soLuongBan) && float.TryParse(txtgia.Text, out float donGia))
                {
                    // Tính toán thành tiền
                    float thanhTien = soLuongBan * donGia;
                    float thanhTienFloat = float.Parse(thanhTien.ToString());
                    // Hiển thị kết quả vào txtthanhtien
                    txtthanhtien.Text = thanhTienFloat.ToString();
                }
                else
                {
                    // Nếu dữ liệu không hợp lệ, có thể hiển thị thông báo hoặc xử lý khác tùy thuộc vào yêu cầu của bạn
                }
            }
            else
            {
                // Nếu một trong hai trường số lượng hoặc giá không có dữ liệu, có thể hiển thị thông báo hoặc xử lý khác tùy thuộc vào yêu cầu của bạn
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Image image = Resources.bill;
            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);
            e.Graphics.DrawString("Date: " + dtngay.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), 
                Brushes.Black, new Point(50, 310));
            e.Graphics.DrawString("Tên NV: " + cbotennv.Text.Trim(), new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(50, 340));
            e.Graphics.DrawString("Mã HD: " + txtmahd.Text.Trim(), new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(50, 370));
            e.Graphics.DrawString("Mã KH: " + cbomakh.Text.Trim(), new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(590, 340));
            e.Graphics.DrawString("Tên KH: " + cbotenkh.Text.Trim(), new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(590, 370));
            e.Graphics.DrawString("---------------------------------------------------------------------" +
                "--------------------------------------------------------------" 
                , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 410));
            e.Graphics.DrawString("Tên sản phẩm", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 440));
            e.Graphics.DrawString("Số lượng", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(440, 440));
            e.Graphics.DrawString("Đơn giá", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(570, 440));
            e.Graphics.DrawString("Thành tiền", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(690, 440));
            e.Graphics.DrawString("---------------------------------------------------------------------" +
                "--------------------------------------------------------------"
                , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 470));


            int yPos = 500;
            foreach (DataGridViewRow row in dgvsp.Rows)
            {
                // Kiểm tra xem hàng không phải là hàng mới được thêm vào
                if (!row.IsNewRow)
                {
                    // Lấy giá trị từ các ô dữ liệu và kiểm tra xem chúng không phải null
                    string tenSP = row.Cells["TenSP"].Value != null ? row.Cells["TenSP"].Value.ToString() : "";
                    string soLuong = row.Cells["Soluongban"].Value != null ? row.Cells["Soluongban"].Value.ToString() : "";
                    string donGia = row.Cells["Dongia"].Value != null ? row.Cells["Dongia"].Value.ToString() : "";
                    string thanhTien = row.Cells["Thanhtien"].Value != null ? row.Cells["Thanhtien"].Value.ToString() : "";

                    // Vẽ dữ liệu lên trang in
                    e.Graphics.DrawString(tenSP, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, yPos));
                    e.Graphics.DrawString(soLuong, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, yPos));
                    e.Graphics.DrawString(donGia, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(580, yPos));
                    e.Graphics.DrawString(thanhTien, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, yPos));

                    yPos += 30;
                }

            }
            e.Graphics.DrawString("---------------------------------------------------------------------" +
                "--------------------------------------------------------------"
                , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, yPos));
            e.Graphics.DrawString("Tổng tiền: " + txttongtien.Text.Trim(), new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(620, yPos + 30));

            System.Drawing.Image image1 = Resources.bill_down;
            // Xác định chiều cao của trang in và kích thước của hình ảnh
            int pageHeight = e.PageBounds.Height;
            int imageHeight = image1.Height;

            // Tính toán tọa độ y để hình ảnh được vẽ xuống cuối trang
            int imageY = pageHeight - imageHeight;

            // Vẽ hình ảnh image1 xuống cuối hóa đơn
            e.Graphics.DrawImage(image1, 0, imageY, image1.Width, image1.Height);
        }

        private void vbtnin_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void vbtndanhsach_Click(object sender, EventArgs e)
        {
            loadhdb();
        }

        private void vbtntaomoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox2.Controls)
            {
                if (ctr is TextBox || ctr is ComboBox || ctr is DataGridView)
                {
                    ctr.Text = "";
                }
            }
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr is TextBox || ctr is ComboBox || ctr is DateTimePicker)
                {
                    ctr.Text = "";
                }
            }
        }
    }
}
