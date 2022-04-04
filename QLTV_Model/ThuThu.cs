namespace QuanLyThuVien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThuThu")]
    public partial class ThuThu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThuThu()
        {
            PhieuMuon = new HashSet<PhieuMuon>();
            PhieuTra = new HashSet<PhieuTra>();
            TaiKhoan = new HashSet<TaiKhoan>();
            The = new HashSet<The>();
        }

        [Key]
        [StringLength(30)]
        public string MaTT { get; set; }

        [StringLength(255)]
        public string Hoten { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [StringLength(255)]
        public string DiaChi { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(20)]
        public string SoDienThoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuMuon> PhieuMuon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuTra> PhieuTra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<The> The { get; set; }
    }
}
