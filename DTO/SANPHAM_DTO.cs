using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class SANPHAM_DTO
    {
        [Key]
        public int MaSP { get; set; }

        [Required]
        public int MaDMSP { get; set; }

        [Required]
        public string TenSanPham { get; set; }

        [Required]
        public double DonGia { get; set; }

        [Required]
        public bool TrangThai { get; set; }
    }
}