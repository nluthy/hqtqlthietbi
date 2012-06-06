using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DAO
{
    public class DataAccess
    {
        private static string chuoiKetNoi = "Data Source=localhost;Initial Catalog=hqtqltb;User Id=sa;Password=;";
        public static SqlConnection KetNoi()
        {
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            ketNoi.Open();
            return ketNoi;
        }
    }
}
