using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class NHANVIEN_DTO
    {
        [Key]
        [StringLength(20)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(100)]
        public string TenNV { get; set; }

        [Required]
        public DateTimeOffset NgaySinh { get; set; }

        [Required]
        [StringLength(12)]
        public string SDT { get; set; }

        [Required]
        [StringLength(3)]
        public string GioiTinh { get; set; }
    }
}
