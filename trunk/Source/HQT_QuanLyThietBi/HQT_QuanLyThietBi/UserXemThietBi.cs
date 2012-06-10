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
    public partial class UserXemThietBiForm : Form
    {
        public UserXemThietBiForm()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Owner.Visible = true;
            this.Close();
        }
    }
}
