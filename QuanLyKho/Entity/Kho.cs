using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKho.Entity
{
    public class Kho
    {
        public Kho()
        {
            ChiTietXuats = new List<ChiTietXuat>();
        }
        [Key]
        [Required]
        public string SoLo { get; set; }
        public string MaHH { get; set; }
        public DateTime NgayNhap { get; set; }
        public decimal SoLuong { get; set; }
        public DateTime HSD { get; set; }
        public string GhiChu { get; set; }
        public string MaNhap { get; set; }
        public virtual HangHoa HangHoa { get; set; }
        public virtual NhapKho NhapKho { get; set; }
        public virtual List<ChiTietXuat> ChiTietXuats { get; set; }
    }
}
