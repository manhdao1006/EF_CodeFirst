using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EF_CodeFirst.Models
{
    public class SinhVien
    {
        [Key]
        [MaxLength(12)]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        public int LopId { get; set; }
        public virtual Lop Lop { get; set; }
    }
}