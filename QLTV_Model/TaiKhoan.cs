namespace QuanLyThuVien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        public int MaTK { get; set; }

        [StringLength(50)]
        public string TK { get; set; }

        [StringLength(50)]
        public string MK { get; set; }

        [StringLength(30)]
        public string MaTT { get; set; }

        [StringLength(10)]
        public string Quyen { get; set; }

        public virtual ThuThu ThuThu { get; set; }
    }
}
