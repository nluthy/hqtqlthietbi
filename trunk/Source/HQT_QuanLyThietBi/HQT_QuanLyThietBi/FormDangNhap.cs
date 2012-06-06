using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using DAO;

namespace HQT_QuanLyThietBi
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            NguoiSuDungDTO nsd = new NguoiSuDungDTO();
            if (kiemTraDuLieuHopLe())
            {
                nsd.MaNguoiSuDung = txtTenDangNhap.Text;
                nsd.MatKhau = txtMatKhau.Text;
                int kq = NguoiSuDungDAO.DangNhap(nsd);
                switch (kq)
                {
                    case -1:
                        MessageBox.Show("Tên đăng nhập không tồn tại.\n Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 0:
                        MessageBox.Show("Mật khẩu không đúng.\n Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 1:
                        this.DialogResult = DialogResult.OK;
                        Program.setNguoiSuDung(nsd);
                        this.Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ.\n Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool kiemTraDuLieuHopLe()
        {
            if (txtTenDangNhap.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }
    }
}
