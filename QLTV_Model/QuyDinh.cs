namespace QuanLyThuVien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuyDinh")]
    public partial class QuyDinh
    {
        [Key]
        public int MaQD { get; set; }

        [StringLength(50)]
        public string TenQD { get; set; }

        public int? SoLuongQD { get; set; }
    }
}
