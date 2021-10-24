using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKho.Entity
{
    public class XuatKho
    {
        public XuatKho()
        {
            ChiTietXuats = new List<ChiTietXuat>();
        }
        [Key]
        [Required]
        public string MaXuat { get; set; } 
        public string NguoiXuat { get; set; }
        public string DonViNhan { get; set; }
        public string LoaiDonViNhan { get; set; }
        public DateTime NgayXuat { get; set; }
        public string GhiChu { get; set; }
        public virtual List<ChiTietXuat> ChiTietXuats { get; set; }
    }
}
