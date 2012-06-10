using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HQT_QuanLyThietBi
{
    public partial class ChonThoiGianForm : Form
    {
        public UserMuonThietBiForm frmParent;
        public ChonThoiGianForm()
        {
            InitializeComponent();
        }

        private void btnChonXong_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            frmParent.thoiGian = dap.Value;
            Close();
        }
    }
}
