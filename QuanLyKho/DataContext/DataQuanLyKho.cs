using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLyKho.Entity;

namespace QuanLyKho.DataContext
{
    public class DataQuanLyKho : DbContext
    {
        public DbSet<ChiTietNhap> ChiTietNhap { set; get; }
        public DbSet<ChiTietXuat> ChiTietXuat { set; get; }
        public DbSet<DonViCho> DonViCho { set; get; }
        public DbSet<HangHoa> HangHoa { set; get; }
        public DbSet<Kho> Kho { set; get; }
        public DbSet<Loai> Loai { set; get; }
        public DbSet<NhapKho> NhapKho { set; get; }
        public DbSet<XuatKho> XuatKho { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietNhap>().HasKey(ctn => new { ctn.MaNhap, ctn.MaHH });
            modelBuilder.Entity<ChiTietXuat>().HasKey(ctn => new { ctn.MaXuat, ctn.MaHH });
        }
        public DataQuanLyKho(
            DbContextOptions<DataQuanLyKho> options) : base(options)
    {
    }
}
}
