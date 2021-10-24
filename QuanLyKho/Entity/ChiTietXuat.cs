using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKho.Entity
{
    public class ChiTietXuat
    {
        public string MaXuat { get; set; }
        public string MaHH { get; set; }
        public decimal SoLuong { get; set; }
        public string SoLo { get; set; }
        public virtual Kho Kho { get; set; }
        public virtual NhapKho NhapKho { get; set; }
        public virtual HangHoa HangHoa { get; set; }
    }
}
