using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace entityframework_session01Assignment.Models
{
    [Table("Books")]
    internal class Book
    {
        [Key]
        public int bookid { get; set; }
        [Required]
        [MaxLength(50)]
        public string? ISBNnumber { get; set; }
        [Required]
        [MaxLength(50)]
        public string ?Title { get; set; }


        [Column("UnitPrice", TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int YearPublished { get; set; }
        public bool stock{ get; set; }


    }
}
