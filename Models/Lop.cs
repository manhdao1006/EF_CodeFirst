using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EF_CodeFirst.Models
{
    public class Lop
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string Name { get; set; }
        public int KhoaId { get; set; }
        public virtual Khoa Khoa { get; set; }
    }
}