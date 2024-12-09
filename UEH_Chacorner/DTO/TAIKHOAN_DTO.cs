using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class TAIKHOAN_DTO
    {
        [Key]
        [MaxLength(50)]
        public string TenTK { get; set; } 

        [Required]
        [MaxLength(20)] 
        public string MatKhau { get; set; } 

        [Required]
        [MaxLength(20)]
        public string Quyen { get; set; } 

        [Required]
        [MaxLength(20)] 
        public string MaNV { get; set; } 
    }
}
