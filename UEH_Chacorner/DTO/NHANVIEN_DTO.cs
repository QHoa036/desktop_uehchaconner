using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class NHANVIEN_DTO
    {
        [Key]
        [MaxLength(20)]
        public string MaNV { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenNV { get; set; }

        [Required]
        public DateTime NgaySinh { get; set; }

        [Required]
        [MaxLength(12)]
        public string SDT { get; set; }

        [Required]
        [MaxLength(3)]
        public string GioiTinh { get; set; }
    }
}
