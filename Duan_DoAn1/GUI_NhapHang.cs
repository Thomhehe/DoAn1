using BUS;
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

namespace DoAn1
{
    public partial class GUI_NhapHang : Form
    {
        BUS_NhapHang bus_nhaphang = new BUS_NhapHang();
        BUS_HDN bus_hdn = new BUS_HDN();
        DataTable dtNhanVien;
        DataTable dtNCC;
        DataTable dtSanPham;

        public GUI_NhapHang()
        {
            InitializeComponent();
            loadncc();
            loadsp();
            loadnv();
        }
        void loadnv()
        {
            dtNhanVien = bus_nhaphang.GetNhanVien();
            cbomanv.DataSource = dtNhanVien;
            cbomanv.DisplayMember = "MaNV";
            cbomanv.ValueMember = "MaNV";

            cbotennv.DataSource = dtNhanVien;
            cbotennv.DisplayMember = "TenNV";
            cbotennv.ValueMember = "MaNV";
        }
        void loadncc()
        {
            dtNCC = bus_nhaphang.GetNCC();
            cbomancc.DataSource = dtNCC;
            cbomancc.DisplayMember = "MaNCC";
            cbomancc.ValueMember = "MaNCC";

            cbotenncc.DataSource = dtNCC;
            cbotenncc.DisplayMember = "TenNCC";
            cbotenncc.ValueMember = "MaNCC";
        }
        void loadsp()
        {
            dtSanPham = bus_nhaphang.GetSanPham();
            cbotensp.DataSource = dtSanPham;
            cbotensp.DisplayMember = "TenSP";
            cbotensp.ValueMember = "MaSP";

            cbomasp.DataSource = dtSanPham;
            cbomasp.DisplayMember = "MaSP";
            cbomasp.ValueMember = "MaSP";
        }

        void loadhdn()
        {
            DataTable dt = bus_hdn.getHDN();
            dgvhdn.DataSource = dt;
            dgvhdn.Columns[0].HeaderText = "Mã hóa đơn";
            dgvhdn.Columns[1].HeaderText = "Mã nhân viên";
            dgvhdn.Columns[2].HeaderText = "Mã NCC";
            dgvhdn.Columns[3].HeaderText = "Tổng tiền";
            dgvhdn.Columns[4].HeaderText = "Ngày nhập";
        }
        void loadcthdn(string maHDN)
        {
            DataTable dt = bus_hdn.getCTHDN(maHDN);
            dgvcthdn.DataSource = dt;
            dgvcthdn.Columns[0].HeaderText = "Mã hóa đơn";
            dgvcthdn.Columns[1].HeaderText = "Mã sản phẩm";
            dgvcthdn.Columns[2].HeaderText = "Số lượng";
            dgvcthdn.Columns[3].HeaderText = "Đơn giá";
            dgvcthdn.Columns[4].HeaderText = "Thành tiền";
        }

        private void dgvhdn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txthdxoa.Text = dgvhdn[0, i].Value.ToString().Trim();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvhdn.Rows[e.RowIndex];
                string maHDN = row.Cells["MaHDN"].Value.ToString();
                loadcthdn(maHDN);
            }
        }
        private void GUI_NhapHang_Load(object sender, EventArgs e)
        {
            loadhdn();
            dgvhdn.CellClick += dgvhdn_CellClick;

            cbomanv.Text = string.Empty;
            cbotennv.Text = string.Empty;
            cbomancc.Text = string.Empty;
            cbotenncc.Text = string.Empty;
            cbomasp.Text = string.Empty;
            cbotensp.Text = string.Empty;
            txtgia.Text = string.Empty;
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

        private void cbotennv_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cbotennv.SelectedItem;

            // Lấy mã nhân viên tương ứng và cập nhật giá trị của combobox mã nhân viên
            string maNV = row["MaNV"].ToString();
            cbomanv.SelectedValue = maNV;
        }

        private void cbomancc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNCC = cbomancc.SelectedValue.ToString();
            DataRow[] rows = dtNCC.Select($"MaNCC = '{maNCC}'");
            if (rows.Length > 0)
            {
                cbotenncc.Text = rows[0]["TenNCC"].ToString();
            }
        }

        private void cbotenncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cbotenncc.SelectedItem;

            string maNCC = row["MaNCC"].ToString();
            cbomancc.SelectedValue = maNCC;
        }

        private void cbomasp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy mã sản phẩm được chọn và cập nhật giá trị của combobox tên sản phẩm
            string maSP = cbomasp.SelectedValue.ToString();
            DataRow[] rows = dtSanPham.Select($"MaSP = '{maSP}'");
            if (rows.Length > 0)
            {
                cbotensp.Text = rows[0]["TenSP"].ToString();
            }
        }

        private void cbotensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cbotensp.SelectedItem;

            // Lấy mã sản phẩm tương ứng và cập nhật giá trị của combobox mã sản phẩm
            string maSP = row["MaSP"].ToString();
            cbomasp.SelectedValue = maSP;
        }
        private void InitializeDgvspColumns()
        {
            if (dgvsp.Columns.Count == 0)
            {
                dgvsp.Columns.Add("MaHDN", "MaHDN");
                dgvsp.Columns.Add("MaNV", "MaNV");
                dgvsp.Columns.Add("MaCC", "MaNCC");
                dgvsp.Columns.Add("MaSP", "MaSP");
                dgvsp.Columns.Add("TenSP", "TenSP");
                dgvsp.Columns.Add("Soluongnhap", "Soluongnhap");
                dgvsp.Columns.Add("Gianhap", "Gianhap");
                dgvsp.Columns.Add("Thanhtien", "Thanhtien");
            }
        }
        private float tongTien = 0;
        private void vbtnthemsp_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            float gia;
            bool isParsed = float.TryParse(txtgia.Text, out gia);
            int sluong;
            bool isParsed1 = int.TryParse(txtsl.Text, out sluong);
            if (bus_nhaphang.kiemtramatrung(txtmahd.Text) == 1)
            {
                MessageBox.Show("Mã hóa đơn này đã tồn tại!! Vui lòng nhập lại mã.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (string.IsNullOrEmpty(txtmahd.Text) || string.IsNullOrEmpty(cbomanv.Text)
                    || string.IsNullOrEmpty(cbotennv.Text) || string.IsNullOrEmpty(cbomancc.Text)
                    || string.IsNullOrEmpty(cbotenncc.Text) || string.IsNullOrEmpty(cbomasp.Text)
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
            int soLuongNhap = int.Parse(txtsl.Text);
            float giaNhap = float.Parse(txtgia.Text);
            float thanhTien = soLuongNhap * giaNhap;

            InitializeDgvspColumns();
            dgvsp.Rows.Add(txtmahd.Text, cbomanv.SelectedValue.ToString(), cbomancc.SelectedValue, maSP, tenSP, soLuongNhap, giaNhap, thanhTien);
            tongTien += thanhTien;
            float tongTienFloat = float.Parse(tongTien.ToString());
            txttongtien.Text = tongTienFloat.ToString();


            // Làm mới các trường thông tin sản phẩm
            txtsl.Clear();
            txtgia.Clear();
            txtthanhtien.Clear();
        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu số lượng và giá đều hợp lệ
            if (int.TryParse(txtsl.Text, out int soLuongNhap) && float.TryParse(txtgia.Text, out float giaNhap))
            {
                // Tính toán thành tiền
                float thanhTien = soLuongNhap * giaNhap;
                float thanhTienFloat = float.Parse(thanhTien.ToString());
                // Hiển thị kết quả vào txtthanhtien
                txtthanhtien.Text = thanhTienFloat.ToString();
            }
            else
            {
                // Nếu dữ liệu không hợp lệ, xóa nội dung của txtThanhTien
                txtthanhtien.Text = string.Empty;
            }
        }

        private void vbtnxoa_Click(object sender, EventArgs e)
        {
            string maHDN = txthdxoa.Text;
            if (!string.IsNullOrEmpty(maHDN))
            {
                if (bus_hdn.XoaHoaDonNhap(maHDN))
                {
                    MessageBox.Show("Xóa hóa đơn thành công!");
                    loadhdn();
                    loadcthdn(maHDN);
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

        private void vbtnlendon_Click(object sender, EventArgs e)
        {
            String maHDN = txtmahd.Text;
            String maNV = cbomanv.Text;
            String maNCC = cbomancc.Text;
            if (bus_nhaphang.InsertHoadonnhap(maHDN, maNV, maNCC, tongTien))
            {
                foreach (DataGridViewRow row in dgvsp.Rows)
                {
                    if (!row.IsNewRow) 
                    {
                        string maSP = row.Cells["MaSP"].Value.ToString();
                        int soLuongNhap = int.Parse(row.Cells["Soluongnhap"].Value.ToString());
                        float giaNhap = float.Parse(row.Cells["Gianhap"].Value.ToString());
                        float thanhTien = float.Parse(row.Cells["Thanhtien"].Value.ToString());

                        bus_nhaphang.InsertChitiethoadonnhap(txtmahd.Text, maSP, soLuongNhap, giaNhap, thanhTien);

                        CongSoLuongSanPham(maSP, soLuongNhap);
                    }
                }
                MessageBox.Show("Lưu hóa đơn thành công!");
                loadhdn();
                loadcthdn(maHDN);
            }
            else
            {
                MessageBox.Show("Lưu hóa đơn thất bại!");
            }
        }

        private void CongSoLuongSanPham(string maSP, int soLuongNhap)
        {
            // Lấy số lượng sản phẩm hiện tại từ bảng sản phẩm
            int soLuongHienTai = bus_nhaphang.LaySoLuongSanPham(maSP);

            int soLuongMoi = soLuongHienTai + soLuongNhap;

            // Cập nhật số lượng mới vào bảng sản phẩm
            bus_nhaphang.CapNhatSoLuongSanPham(maSP, soLuongMoi);
        }

        private void dgvsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmahd.Text = dgvsp[0, i].Value.ToString().Trim();
            cbomanv.Text = dgvsp[1, i].Value.ToString().Trim();
            cbomancc.Text = dgvsp[2, i].Value.ToString().Trim();
            cbomasp.Text = dgvsp[3, i].Value.ToString().Trim();
            cbotensp.Text = dgvsp[4, i].Value.ToString().Trim();
            txtsl.Text = dgvsp[5, i].Value.ToString().Trim();
            txtgia.Text = dgvsp[6, i].Value.ToString().Trim();
            txtthanhtien.Text = dgvsp[7, i].Value.ToString().Trim();
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

        private void vbtntaomoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr is TextBox || ctr is ComboBox || ctr is DataGridView)
                {
                    ctr.Text = "";
                }
            }
            foreach (Control ctr in this.groupBox2.Controls)
            {
                if (ctr is TextBox || ctr is ComboBox || ctr is DateTimePicker)
                {
                    ctr.Text = "";
                }
            }
        }
    }
}
