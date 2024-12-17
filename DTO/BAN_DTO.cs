using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class BAN_DTO
    {
        [Key]   
        public int MaBan { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }
                
        [Required]
        [StringLength(20)]
        public string TrangThai { get; set; }
        
        [Required]       
        public int ThuTu { get; set; }

        [Required]
        public bool DaXoa { get; set; }
        
    } 

}
