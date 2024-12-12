using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class TAIKHOAN_DTO
    {
        [Key]
        [StringLength(50)]
        public string TenTK { get; set; } 

        [Required]
        [StringLength(20)] 
        public string MatKhau { get; set; } 

        [Required]
        [StringLength(20)]
        public string Quyen { get; set; } 

        [Required]
        [StringLength(20)] 
        public string MaNV { get; set; } 
    }
}
