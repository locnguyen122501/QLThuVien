using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyThuVien
{
    public partial class QLTV_Model : DbContext
    {
        public QLTV_Model()
            : base("name=QLTV_Model")
        {
        }

        public virtual DbSet<DocGia> DocGia { get; set; }
        public virtual DbSet<NhaXuatBan> NhaXuatBan { get; set; }
        public virtual DbSet<PhieuMuon> PhieuMuon { get; set; }
        public virtual DbSet<PhieuTra> PhieuTra { get; set; }
        public virtual DbSet<QuyDinh> QuyDinh { get; set; }
        public virtual DbSet<Sach> Sach { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<The> The { get; set; }
        public virtual DbSet<TheLoai> TheLoai { get; set; }
        public virtual DbSet<ThuThu> ThuThu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocGia>()
                .HasMany(e => e.PhieuTra)
                .WithOptional(e => e.DocGia)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DocGia>()
                .HasMany(e => e.The)
                .WithOptional(e => e.DocGia)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhaXuatBan>()
                .HasMany(e => e.Sach)
                .WithOptional(e => e.NhaXuatBan)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Sach>()
                .HasMany(e => e.PhieuMuon)
                .WithOptional(e => e.Sach)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Sach>()
                .HasMany(e => e.PhieuTra)
                .WithOptional(e => e.Sach)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MK)
                .IsUnicode(false);

            modelBuilder.Entity<TheLoai>()
                .HasMany(e => e.Sach)
                .WithOptional(e => e.TheLoai)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ThuThu>()
                .HasMany(e => e.PhieuMuon)
                .WithOptional(e => e.ThuThu)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ThuThu>()
                .HasMany(e => e.PhieuTra)
                .WithOptional(e => e.ThuThu)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ThuThu>()
                .HasMany(e => e.TaiKhoan)
                .WithOptional(e => e.ThuThu)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ThuThu>()
                .HasMany(e => e.The)
                .WithOptional(e => e.ThuThu)
                .WillCascadeOnDelete();
        }
    }
}
