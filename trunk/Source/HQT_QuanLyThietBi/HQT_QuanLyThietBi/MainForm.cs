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
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Program.getNguoiSuDung(), "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
