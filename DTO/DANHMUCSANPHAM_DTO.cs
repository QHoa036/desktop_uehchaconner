using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class DANHMUCSANPHAM_DTO
    {
        [Key]
        public int MaDMSP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDMSP { get; set; }
    }
}


