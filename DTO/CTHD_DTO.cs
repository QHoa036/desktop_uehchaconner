using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class CTHD_DTO
    {
        [Key]
        public int MaCTHD { get; set; }

        [Required]
        public int MaHD { get; set; }

        [Required]
        public int MaSP { get; set; }

        public int SoLuong { get; set; }
    }
}
