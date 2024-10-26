using DTO;
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
using System.Runtime.CompilerServices;

namespace DoAn1
{
    public partial class GUI_SanPham : Form
    {
        BUS_SanPham bus_sanpham = new BUS_SanPham();
        BUS_NhaCungCap bus_ncc = new BUS_NhaCungCap();
        public GUI_SanPham()
        {
            InitializeComponent();
            txttimkiem.GotFocus += txttimkiem_Enter;
            txttimkiem.LostFocus += txttimkiem_Leave;
            txttimkiem.Text = "Tìm kiếm theo mã sp, tên sp, tên loại, mã ncc, xuất xứ, mô tả";
        }
        void loaddgv()
        {
            dgvSP.DataSource = bus_sanpham.getSanPham();
            dgvSP.Columns[0].HeaderText = "Mã sản phẩm";
            dgvSP.Columns[1].HeaderText = "Tên sản phẩm";
            dgvSP.Columns[2].HeaderText = "Tên loại";
            dgvSP.Columns[3].HeaderText = "Mã nhà cung cấp";
            dgvSP.Columns[4].HeaderText = "Kích thước";
            dgvSP.Columns[5].HeaderText = "Xuất xứ";
            dgvSP.Columns[6].HeaderText = "Giá";
            dgvSP.Columns[7].HeaderText = "Số lượng";
            dgvSP.Columns[8].HeaderText = "Mô tả";
            cbomancc.DataSource = bus_ncc.getNCC();
            cbomancc.DisplayMember = "MaNCC";
        }

        private void GUI_SanPham_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmasp.Text = dgvSP[0, i].Value.ToString().Trim();
            txttensp.Text = dgvSP[1, i].Value.ToString().Trim();
            cbotenloai.Text = dgvSP[2, i].Value.ToString().Trim();
            cbomancc.Text = dgvSP[3, i].Value.ToString().Trim();
            txtkichthuoc.Text = dgvSP[4, i].Value.ToString().Trim();
            cboxuatxu.Text = dgvSP[5, i].Value.ToString().Trim();
            txtgia.Text = dgvSP[6, i].Value.ToString().Trim();
            txtsl.Text = dgvSP[7, i].Value.ToString().Trim();
            txtmota.Text = dgvSP[8, i].Value.ToString().Trim();
        }
        private void vbtnlammoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr is TextBox || ctr is ComboBox)
                {
                    ctr.Text = "";
                }
            }
        }

        private void vbtnthem_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = txtmasp.Text;
            sp.TenSP = txttensp.Text;
            sp.Tenloai = cbotenloai.Text;
            sp.MaNCC = cbomancc.Text;
            sp.Kichthuoc = txtkichthuoc.Text;
            sp.Xuatxu = cboxuatxu.Text;
            sp.Gia = float.Parse(txtgia.Text);
            sp.Soluong = int.Parse(txtsl.Text);
            sp.Mota = txtmota.Text;
            float gia;
            bool isParsed = float.TryParse(txtgia.Text, out gia);
            int sluong;
            bool isParsed1 = int.TryParse(txtsl.Text, out sluong);
            if (bus_sanpham.kiemtramatrung(txtmasp.Text) == 1)
            {
                MessageBox.Show("Mã sản phẩm này đã tồn tại!! Vui lòng nhập lại mã.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(txtmasp.Text) || string.IsNullOrEmpty(txttensp.Text)
                    || string.IsNullOrEmpty(cbotenloai.Text) || string.IsNullOrEmpty(cbomancc.Text)
                    || string.IsNullOrEmpty(txtkichthuoc.Text) || string.IsNullOrEmpty(cboxuatxu.Text))
                {
                    MessageBox.Show("Thông tin không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng thực hiện tiếp
                }
                if (!isParsed || gia <= 0)
                {
                    MessageBox.Show("Giá phải là một số hợp lệ lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng thực hiện tiếp
                }
                sp.Gia = gia;
                if (!isParsed1 || sluong < 0)
                {
                    MessageBox.Show("Số lượng phải là một số hợp lệ lớn hơn hoặc bằng 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng thực hiện tiếp
                }
                sp.Soluong = sluong;
                if (bus_sanpham.ThemSanPham(sp) == true)
                {
                    MessageBox.Show("Thêm sản phẩm mới thành công.");
                    loaddgv();
                }
            }
        }

        private void vbtnsua_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = txtmasp.Text;
            sp.TenSP = txttensp.Text;
            sp.Tenloai = cbotenloai.Text;
            sp.MaNCC = cbomancc.Text;
            sp.Kichthuoc = txtkichthuoc.Text;
            sp.Xuatxu = cboxuatxu.Text;
            sp.Gia = float.Parse(txtgia.Text);
            sp.Mota = txtmota.Text;
            float gia;
            bool isParsed = float.TryParse(txtgia.Text, out gia);
            int sluong;
            bool isParsed1 = int.TryParse(txtsl.Text, out sluong);
            if (string.IsNullOrEmpty(txtmasp.Text) || string.IsNullOrEmpty(txttensp.Text)
                    || string.IsNullOrEmpty(cbotenloai.Text) || string.IsNullOrEmpty(cbomancc.Text)
                    || string.IsNullOrEmpty(txtkichthuoc.Text) || string.IsNullOrEmpty(cboxuatxu.Text))
            {
                MessageBox.Show("Thông tin không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng thực hiện tiếp
            }
            if (!isParsed || gia <= 0)
            {
                MessageBox.Show("Giá phải là một số hợp lệ lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng thực hiện tiếp
            }
            sp.Gia = gia;
            if (!isParsed1 || sluong < 0)
            {
                MessageBox.Show("Số lượng phải là một số hợp lệ lớn hơn hoặc bằng 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng thực hiện tiếp
            }
            sp.Soluong = sluong;
            if (bus_sanpham.SuaSanPham(sp) == true)
            {
                MessageBox.Show("Sửa thông tin sản phẩm thành công.");
                loaddgv();
            }
        }

        private void vbtnxoa_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = txtmasp.Text;
            sp.TenSP = txttensp.Text;
            sp.Tenloai = cbotenloai.Text;
            sp.MaNCC = cbomancc.Text;
            sp.Kichthuoc = txtkichthuoc.Text;
            sp.Xuatxu = cboxuatxu.Text;
            sp.Gia = float.Parse(txtgia.Text);
            sp.Mota = txtmota.Text;
            if (bus_sanpham.XoaSanPham(sp) == true)
            {
                MessageBox.Show("Xóa sản phẩm thành công.");
                loaddgv();
            }
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            GUI_SanPham_Load(sender, e);
            string searchText = txttimkiem.Text.Trim().ToUpperInvariant();

            for (int i = dgvSP.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue0 = dgvSP[0, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue1 = dgvSP[1, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue2 = dgvSP[2, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue3 = dgvSP[3, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue5 = dgvSP[5, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue7 = dgvSP[7, i].Value?.ToString().Trim().ToUpperInvariant();

                bool containsSearchText = (!string.IsNullOrEmpty(cellValue0) && cellValue0.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue2) && cellValue2.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue3) && cellValue3.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue5) && cellValue5.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue7) && cellValue7.Contains(searchText));

                if (!containsSearchText)
                {
                    dgvSP.Rows.RemoveAt(i);
                }
            }
        }
        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Tìm kiếm theo mã sp, tên sp, tên loại, mã ncc, xuất xứ, mô tả")
            {
                txttimkiem.Text = "";
            }
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttimkiem.Text))
            {
                txttimkiem.Text = "Tìm kiếm theo mã sp, tên sp, tên loại, mã ncc, xuất xứ, mô tả";
            }
            loaddgv();
        }
    }
}
