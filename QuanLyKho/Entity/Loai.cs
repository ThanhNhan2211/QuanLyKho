using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKho.Entity
{
    public class Loai
    {
        public Loai()
        {
            HangHoas = new List<HangHoa>();
        }
        [Key]
        [Required]
        public string Id { get; set; }
        public string TenLoai { get; set; }
        public string MoTa { get; set; }
        public virtual List<HangHoa> HangHoas { get; set; }
    }
}
