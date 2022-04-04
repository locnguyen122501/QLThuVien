namespace QuanLyThuVien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuTra")]
    public partial class PhieuTra
    {
        [Key]
        public int MaPhieuTra { get; set; }

        public int? MaDocGia { get; set; }

        [StringLength(50)]
        public string MaThe { get; set; }

        public int? MaSach { get; set; }

        public int? SoLuongMuon { get; set; }

        public int? SoLuongTra { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTra { get; set; }

        [StringLength(10)]
        public string TinhTrangSach { get; set; }

        [StringLength(30)]
        public string MaTT { get; set; }

        public virtual DocGia DocGia { get; set; }

        public virtual Sach Sach { get; set; }

        public virtual ThuThu ThuThu { get; set; }

        public virtual The The { get; set; }
    }
}
