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
    public partial class UserMuonThietBiForm : Form
    {
        public Form frmParent;
        Dictionary<string, string> loaiCSVC;
        Dictionary<string, string> dicCSVC;

        public UserMuonThietBiForm()
        {
            InitializeComponent();
            dicCSVC = new Dictionary<string, string>();
            loaiCSVC = new Dictionary<string, string>();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmParent.Visible = true;
            this.Close();
        }

        private void UserMuonThietBiForm_Load(object sender, EventArgs e)
        {
            loaiCSVC = CoSoVatChatDAO.LayLoaiCSVC();
            loaiCSVC.Add("Tất cả", "");
            cobLoai.DataSource = loaiCSVC.Keys.ToArray();
            cobLoai.SelectedIndex = cobLoai.Items.Count - 1;
            getListCSVC("");
            
        }

        private void getListCSVC(string maLoai)
        {
            dicCSVC.Clear();
            dgvThietBi.Rows.Clear();
            List<CoSoVatChatDTO> csvc = CoSoVatChatDAO.LayDanhSachCoSoVatChat(maLoai, "1");
            foreach (CoSoVatChatDTO cs in csvc)
            {
                dicCSVC.Add(cs.MaVatChat, cs.TenVatChat);
                dgvThietBi.Rows.Add(new string[] { cs.TenVatChat, cs.Loai });
            }
        }

        private void cobLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loai = cobLoai.SelectedItem.ToString();
            string maLoai;
            loaiCSVC.TryGetValue(loai, out maLoai);

            getListCSVC(maLoai);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenCSVC = dgvThietBi.SelectedRows[0].Cells["TenThietBi"].Value.ToString();
            string maCSVC;
            dicCSVC.TryGetValue(tenCSVC, out maCSVC);

        }
    }
}
