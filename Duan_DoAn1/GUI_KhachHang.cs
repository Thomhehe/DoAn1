﻿using BUS;
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
    public partial class GUI_KhachHang : Form
    {
        BUS_KhachHang bus_khachhang = new BUS_KhachHang();
        public GUI_KhachHang()
        {
            InitializeComponent();
        }
        void loaddgv()
        {
            dgvkh.DataSource = bus_khachhang.getKhachHang();
            dgvkh.Columns[0].HeaderText = "Mã khách hàng";
            dgvkh.Columns[1].HeaderText = "Tên khách hàng";
            dgvkh.Columns[2].HeaderText = "Giới tính";
            dgvkh.Columns[3].HeaderText = "Địa chỉ";
            dgvkh.Columns[4].HeaderText = "Số điện thoại";
        }
        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmakh.Text = dgvkh[0, i].Value.ToString().Trim();
            txttenkh.Text = dgvkh[1, i].Value.ToString().Trim();
            txtdiachi.Text = dgvkh[3, i].Value.ToString().Trim();
            txtsdt.Text = dgvkh[4, i].Value.ToString().Trim();
            string gt = dgvkh.Rows[i].Cells[2].Value.ToString().Trim();
            if (gt == "Nam")
            {
                rdbnam.Checked = true;
            }
            else
            {
                rdbnu.Checked = true;
            }
        }
        private void vbtnlammoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
        }

        private void vbtnthem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = txtmakh.Text;
            kh.TenKH = txttenkh.Text;
            kh.Gioitinh = "";
            // Duyệt qua tất cả các điều khiển trong GroupBox
            foreach (Control ctr in this.groupBox1.Controls)
            {
                // Kiểm tra nếu điều khiển là RadioButton và nó đang được chọn
                if (ctr is RadioButton && rdbnam.Checked)
                {
                    // Lấy giá trị của RadioButton
                    kh.Gioitinh = rdbnam.Text;
                    break; // Thoát khỏi vòng lặp khi tìm thấy RadioButton được chọn
                }
                else if (ctr is RadioButton && rdbnu.Checked)
                {
                    kh.Gioitinh = rdbnu.Text;
                    break;
                }
            }
            kh.Diachi = txtdiachi.Text;
            kh.Sdt = txtsdt.Text;
            if (bus_khachhang.kiemtramatrung(txtmakh.Text) == 1)
            {
                MessageBox.Show("Mã khách hàng này đã tồn tại!! Vui lòng nhập lại mã.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(txtmakh.Text) || string.IsNullOrEmpty(txttenkh.Text) 
                    || string.IsNullOrEmpty(txtdiachi.Text) || string.IsNullOrEmpty(txtsdt.Text))
                {
                    MessageBox.Show("Thông tin không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng thực hiện tiếp
                }
                if (kh.Sdt.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải chứa đúng 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng thực hiện tiếp
                }
                if (bus_khachhang.ThemKhachHang(kh) == true)
                {
                    MessageBox.Show("Thêm khách hàng mới thành công.");
                    loaddgv();
                }
            }
        }

        private void vbtnsua_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = txtmakh.Text;
            kh.TenKH = txttenkh.Text;
            kh.Gioitinh = "";
            // Duyệt qua tất cả các điều khiển trong GroupBox
            foreach (Control ctr in this.groupBox1.Controls)
            {
                // Kiểm tra nếu điều khiển là RadioButton và nó đang được chọn
                if (ctr is RadioButton && rdbnam.Checked)
                {
                    // Lấy giá trị của RadioButton
                    kh.Gioitinh = rdbnam.Text;
                    break; // Thoát khỏi vòng lặp khi tìm thấy RadioButton được chọn
                }
                else if (ctr is RadioButton && rdbnu.Checked)
                {
                    kh.Gioitinh = rdbnu.Text;
                    break;
                }
            }
            kh.Diachi = txtdiachi.Text;
            kh.Sdt = txtsdt.Text;
            if (string.IsNullOrEmpty(txtmakh.Text) || string.IsNullOrEmpty(txttenkh.Text)
                    || string.IsNullOrEmpty(txtdiachi.Text) || string.IsNullOrEmpty(txtsdt.Text))
            {
                MessageBox.Show("Thông tin không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng thực hiện tiếp
            }
            if (kh.Sdt.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải chứa đúng 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng thực hiện tiếp
            }
            if (bus_khachhang.SuaKhachHang(kh) == true)
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công.");
                loaddgv();
            }
        }

        private void vbtnxoa_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = txtmakh.Text;
            kh.TenKH = txttenkh.Text;
            kh.Gioitinh = "";
            // Duyệt qua tất cả các điều khiển trong GroupBox
            foreach (Control ctr in this.groupBox1.Controls)
            {
                // Kiểm tra nếu điều khiển là RadioButton và nó đang được chọn
                if (ctr is RadioButton && rdbnam.Checked)
                {
                    // Lấy giá trị của RadioButton
                    kh.Gioitinh = rdbnam.Text;
                    break; // Thoát khỏi vòng lặp khi tìm thấy RadioButton được chọn
                }
                else if (ctr is RadioButton && rdbnu.Checked)
                {
                    kh.Gioitinh = rdbnu.Text;
                    break;
                }
            }
            kh.Diachi = txtdiachi.Text;
            kh.Sdt = txtsdt.Text;
            //if (bus_khachhang.XoaKhachHang(kh) == true)
            //{
            //    MessageBox.Show("Xóa khách hàng thành công.");
            //    loaddgv();
            //}
            string maKH = txtmakh.Text;

            try
            {
                bus_khachhang.XoaKhachHang(maKH);
                MessageBox.Show("Xóa khách hàng thành công!");
                loaddgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa khách hàng: " + ex.Message);
            }

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            GUI_KhachHang_Load(sender, e);
            string searchText = txttimkiem.Text.Trim().ToUpperInvariant();

            for (int i = dgvkh.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue0 = dgvkh[0, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue1 = dgvkh[1, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue2 = dgvkh[2, i].Value?.ToString().Trim().ToUpperInvariant();

                bool containsSearchText = (!string.IsNullOrEmpty(cellValue0) && cellValue0.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue2) && cellValue2.Contains(searchText));

                if (!containsSearchText)
                {
                    dgvkh.Rows.RemoveAt(i);
                }
            }
        }
    }
}
