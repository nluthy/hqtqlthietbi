using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhieuYeuCauDTO
    {
        public string MaPhieu { get; set; }
        public NguoiSuDungDTO NguoiSuDung { get; set; }
        public CoSoVatChatDTO Vatchat { get; set; }
        public DateTime ThoiGianDangKi { get; set; }
        public DateTime ThoiGianMuon { get; set; }
        public string TinhTrang { get; set; }
        public string GhiChu { get; set; }
        public int SoLuong { get; set; }
    }
}
