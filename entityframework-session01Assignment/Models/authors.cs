using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace entityframework_session01Assignment.Models
{
    [Table("authors")]
    internal class authors
    {
        [Key]
        public int authorid { get; set; }
        [Required]
        [MaxLength(50)]
        public  string? FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string? LastName { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Email { get; set; }
        [MaxLength(1000)]
        public string? shortBio { get; set; }

        [Column("BirthDate", TypeName = "date")]
        public  DateTime DateOfBirth { get; set; }
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

    }
}
