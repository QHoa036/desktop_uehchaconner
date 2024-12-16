using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class HOADON_DTO
    {
        [Key]
        public int MaHD { get; set; }

        [Required]
        public int MaBan { get; set; }

        [Required]
        [MaxLength(20)]
        public string MaNV { get; set; }

        [Required]
        public DateTime NgayLap { get; set; }

        [Required]
        public string TrangThai { get; set; }
    }
}
