using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace entityframework_session01Assignment.Models
{
    [Table("categoriesofBOOKS")]
    internal class categories
    {
        [Key]
        public int catid { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string? name { get; set; }
        [Required]
        [MaxLength(500)]
        public string? description { get; set; }

        public bool IsActive { get; set; }


    }
}
