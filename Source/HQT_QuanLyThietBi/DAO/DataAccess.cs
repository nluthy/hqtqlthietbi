using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace DAO
{
    public class DataAccess
    {
        private static string chuoiKetNoi = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=hqtqltb;User Id=sa;Password=;";
        public static OleDbConnection KetNoi()
        {
            OleDbConnection ketNoi = new OleDbConnection(chuoiKetNoi);
            ketNoi.Open();
            return ketNoi;
        }
    }
}
