using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class CoSoVatChatDAO : DataAccess
    {
        public static List<CoSoVatChatDTO> LayDanhSachCoSoVatChat(string maLoai, string maTinhTrang)
        {
            List<CoSoVatChatDTO> kq = new List<CoSoVatChatDTO>();

            SqlConnection conn = null;
            try
            {
                conn = KetNoi();
                SqlCommand cmd = null;
                if ((maLoai == null || maLoai == "") && (maTinhTrang == null || maTinhTrang == ""))
                {
                    cmd = new SqlCommand("LayTatCaVatChat", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    if (maLoai != null && maLoai != "")
                    {
                        if (maTinhTrang != null && maTinhTrang != "")
                        {
                            cmd = new SqlCommand("LayVatChatTheoLoaiVaTinhTrang", conn);
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.Add("@MaLoai", System.Data.SqlDbType.NChar, 10);
                            cmd.Parameters["@MaLoai"].Value = maLoai;
                            cmd.Parameters.Add("@MaTinhTrang", System.Data.SqlDbType.NChar, 10);
                            cmd.Parameters["@MaTinhTrang"].Value = maTinhTrang;
                        }
                        else
                        {
                            cmd = new SqlCommand("LayVatChatTheoLoai", conn);
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.Add("@MaLoai", System.Data.SqlDbType.NChar, 10);
                            cmd.Parameters["@MaLoai"].Value = maLoai;
                        }
                    }
                    else
                    {
                        if (maTinhTrang != null && maTinhTrang != "")
                        {
                            cmd = new SqlCommand("LayVatChatTheoTinhTrang", conn);
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.Add("@MaTinhTrang", System.Data.SqlDbType.NChar, 10);
                            cmd.Parameters["@MaTinhTrang"].Value = maTinhTrang;
                        }
                    }
                }

                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        string maVC = dataReader.GetString(0);
                        string tenVC = dataReader.GetString(1);
                        string loaiVC = dataReader.GetString(2);
                        string tinhTrangVC = dataReader.GetString(3);

                        CoSoVatChatDTO csvc = new CoSoVatChatDTO();
                        csvc.MaVatChat = maVC;
                        csvc.TenVatChat = tenVC;
                        csvc.Loai = loaiVC;
                        csvc.TinhTrang = tinhTrangVC;

                        kq.Add(csvc);
                    }
                }


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

            return kq;
        }

        public static Dictionary<string, string> LayLoaiCSVC()
        {
            Dictionary<string, string> kq = new Dictionary<string, string>();
            SqlConnection conn = null;
            try
            {
                conn = KetNoi();
                SqlCommand cmd = new SqlCommand("LayLoaiVatChat", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        kq.Add(reader.GetString(1), reader.GetString(0));
                    }
                }
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
            return kq;
        }

        public static Dictionary<string, string> LayTinhTrangCSVC()
        {
            Dictionary<string, string> kq = new Dictionary<string, string>();
            SqlConnection conn = null;
            try
            {
                conn = KetNoi();
                SqlCommand cmd = new SqlCommand("LayTinhTrangVatChat", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        kq.Add(reader.GetString(1), reader.GetString(0));
                    }
                }
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
            return kq;
        }
    }
}
