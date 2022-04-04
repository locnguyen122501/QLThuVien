namespace QuanLyThuVien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("The")]
    public partial class The
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public The()
        {
            PhieuMuon = new HashSet<PhieuMuon>();
            PhieuTra = new HashSet<PhieuTra>();
        }

        [Key]
        [StringLength(50)]
        public string MaThe { get; set; }

        public int? MaDocGia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapThe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHetHan { get; set; }

        [StringLength(30)]
        public string MaTT { get; set; }

        public virtual DocGia DocGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuMuon> PhieuMuon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuTra> PhieuTra { get; set; }

        public virtual ThuThu ThuThu { get; set; }
    }
}
