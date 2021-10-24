using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKho.Entity
{
    public class NhapKho
    {
        public NhapKho()
        {
            ChiTietNhaps = new List<ChiTietNhap>();
            Khos = new List<Kho>();
        }
        [Key]
        [Required]
        public string MaNhap { get; set; }
        public string NguoiNhap { get; set; }
        public DateTime NgayNhap { get; set; }
        public string GhiChu { get; set; }
        public string MaDV { get; set; }
        public virtual DonViCho DonViCho { get; set; }
        public virtual List<ChiTietNhap> ChiTietNhaps { get; set; }
        public virtual List<Kho> Khos { get; set; }
    }
}
