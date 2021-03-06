﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UMSApp.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [StringLength(11)]
        public string Id { get; set; }

        [Required]
        [StringLength(100)]
        [Index("Ix_StudentName")]
        public string Name { get; set; }


    }
}
