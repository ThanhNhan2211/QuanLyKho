using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKho.Entity
{
    public class HangHoa
    {
        public HangHoa()
        {
            Khos = new List<Kho>();
        }
        [Key]
        [Required]
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public string DonViTinh { get; set; }
        public string MaLoai { get; set; }
        public virtual Loai Loai { get; set; }
        public virtual List<Kho> Khos { get; set; }
        public virtual List<ChiTietNhap> ChiTietNhaps { get; set; }
        public virtual List<ChiTietXuat> ChiTietXuats { get; set; }
    }
}
