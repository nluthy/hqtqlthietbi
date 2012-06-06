using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;

namespace HQT_QuanLyThietBi
{
    public partial class MainForm : Form
    {
        private NguoiSuDungDTO nguoiSuDung;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        void setNguoiSuDung(NguoiSuDungDTO nsd)
        {
            this.nguoiSuDung = nsd;
        }

        string getNguoiSuDung()
        {
            return nguoiSuDung.MaNguoiSuDung;
        }
    }
}
