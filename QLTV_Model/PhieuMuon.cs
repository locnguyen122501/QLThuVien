namespace QuanLyThuVien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuMuon")]
    public partial class PhieuMuon
    {
        [Key]
        public int MaPhieuMuon { get; set; }

        public int? MaSach { get; set; }

        [StringLength(50)]
        public string TenSach { get; set; }

        [StringLength(50)]
        public string MaThe { get; set; }

        [StringLength(20)]
        public string MaTheLoai { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayMuon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTra { get; set; }

        public int? SoLuongMuon { get; set; }

        [StringLength(30)]
        public string MaTT { get; set; }

        public virtual Sach Sach { get; set; }

        public virtual ThuThu ThuThu { get; set; }

        public virtual TheLoai TheLoai { get; set; }

        public virtual The The { get; set; }
    }
}
