using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKho.Entity
{
    public class DonViCho
    {
        public DonViCho()
        {
            NhapKhos = new List<NhapKho>();
        }
        [Key]
        [Required]
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public string DiaChi { get; set; }
        public string TenNDD { get; set; }
        public string Sdt { get; set; }
        public string Mail { get; set; }
        public string FileUrl { get; set; }
        public virtual List<NhapKho> NhapKhos { get; set; }
    }
}
