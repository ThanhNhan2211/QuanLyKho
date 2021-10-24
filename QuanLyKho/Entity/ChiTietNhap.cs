using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKho.Entity
{
    public class ChiTietNhap
    {
        public string MaNhap { get; set; }
        public string MaHH { get; set; }
        public decimal SoLuong { get; set; }
        public DateTime HSD { get; set; }
        public virtual NhapKho NhapKho { get; set; }
        public virtual HangHoa HangHoa { get; set; }
    }
}
