namespace QuanLyThuVien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            PhieuMuon = new HashSet<PhieuMuon>();
            PhieuTra = new HashSet<PhieuTra>();
        }

        [Key]
        public int MaSach { get; set; }

        [StringLength(255)]
        public string TenSach { get; set; }

        [StringLength(50)]
        public string TacGia { get; set; }

        [StringLength(20)]
        public string MaTheLoai { get; set; }

        public int? MaNXB { get; set; }

        public int? DonGia { get; set; }

        public int? SoLuongTon { get; set; }

        public int? SoLanMuon { get; set; }

        [StringLength(20)]
        public string TinhTrang { get; set; }

        public virtual NhaXuatBan NhaXuatBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuMuon> PhieuMuon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuTra> PhieuTra { get; set; }

        public virtual TheLoai TheLoai { get; set; }
    }
}
