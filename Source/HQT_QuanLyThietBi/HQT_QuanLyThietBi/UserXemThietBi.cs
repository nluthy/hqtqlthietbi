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
    public partial class UserXemThietBiForm : Form
    {
        Dictionary<string, string> loaiCSVC;
        Dictionary<string, string> tinhTrangCSVC;

        public UserXemThietBiForm()
        {
            InitializeComponent();
        }

        public Form formParent;

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            formParent.Visible = true;
            this.Close();
        }

        private void UserXemThietBiForm_Load(object sender, EventArgs e)
        {
            loaiCSVC = CoSoVatChatDAO.LayLoaiCSVC();
            loaiCSVC.Add("Tất cả", "");
            cobLoai.DataSource = loaiCSVC.Keys.ToArray();
            tinhTrangCSVC = CoSoVatChatDAO.LayTinhTrangCSVC();
            tinhTrangCSVC.Add("Tất cả", "");
            cobTinhTrang.DataSource = tinhTrangCSVC.Keys.ToArray();
        }

        private void btnXemThietBi_Click(object sender, EventArgs e)
        {
            string loai = cobLoai.SelectedItem.ToString();
            string tinhTrang = cobTinhTrang.SelectedItem.ToString();
            string maLoai;
            string maTinhTrang;
            loaiCSVC.TryGetValue(loai,out maLoai);
            tinhTrangCSVC.TryGetValue(tinhTrang, out maTinhTrang);
            List<CoSoVatChatDTO> csvc = CoSoVatChatDAO.LayDanhSachCoSoVatChat(maLoai, maTinhTrang);
            dgvThietBi.DataSource = csvc;
        }
    }
}
