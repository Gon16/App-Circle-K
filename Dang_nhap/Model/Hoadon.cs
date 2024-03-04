namespace Dang_nhap.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hoadon")]
    public partial class Hoadon
    {
        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNV { get; set; }

        public DateTime? NgayBan { get; set; }

        public double? ThanhTien { get; set; }

        public double? TienKhachDua { get; set; }

        public double? TienThua { get; set; }
    }
}
