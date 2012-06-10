using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;
using DTO;

namespace HQT_QuanLyThietBi
{
    public partial class UserMainForm : Form
    {
        public UserMainForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<CoSoVatChatDTO> csvcList = CoSoVatChatDAO.LayDanhSachCoSoVatChat("", "1");
            MessageBox.Show(csvcList[5].TenVatChat);

            UserXemThietBiForm conme = new UserXemThietBiForm();
            conme.Show();
        }

        private void btnXemThietBi_Click(object sender, EventArgs e)
        {
            UserXemThietBiForm form = new UserXemThietBiForm();
            form.Show();
            form.Location = Location;
            this.Visible = false;
            form.formParent = this;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (Program.getNguoiSuDung() == null || Program.getNguoiSuDung() == "")
            {
                FormDangNhap form = new FormDangNhap();
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    lblUserName.Text = Program.getNguoiSuDung();
                    lblGreeting.Text = "Xin chào";
                    btnDangNhap.Text = "Đăng xuất";
                }
            }
            else
            {
                Program.setNguoiSuDung(new NguoiSuDungDTO());
                btnDangNhap.Text = "Đăng nhập";
                lblUserName.Text = "";
                lblGreeting.Text = "Bạn chưa đăng nhập.";
            }
        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            if (Program.getNguoiSuDung() != null && Program.getNguoiSuDung() != "")
            {
                lblUserName.Text = Program.getNguoiSuDung();
            }
            else
            {
                lblGreeting.Text = "Bạn chưa đăng nhập.";
            }
        }



    }
}
