using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DTO;

namespace HQT_QuanLyThietBi
{
    static class Program
    {
        private static NguoiSuDungDTO nguoiSuDung;

        public static void setNguoiSuDung(NguoiSuDungDTO nsd)
        {
            nguoiSuDung = nsd;
        }

        public static string getNguoiSuDung()
        {
            return nguoiSuDung.MaNguoiSuDung;
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormDangNhap form = new FormDangNhap();

            if (form.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new UserMainForm());
            }
        }
    }
}
