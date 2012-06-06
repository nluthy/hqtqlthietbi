using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace DAO
{
    public class NguoiSuDungDAO:DataAccess
    {
        int DangNhap(NguoiSuDungDTO nsd)
        {
            SqlConnection conn = null;
            try
            {
                conn = KetNoi();
                SqlCommand cmd = new SqlCommand("DangNhap", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNguoiSuDung", System.Data.SqlDbType.NChar, 10);
                cmd.Parameters.Add("@MatKhau", System.Data.SqlDbType.NChar, 10);
                cmd.Parameters["@MaNguoiSuDung"].Value = nsd.MaNguoiSuDung;
                cmd.Parameters["@MatKhau"].Value = nsd.MatKhau;
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return -999;
        }
    }
}
