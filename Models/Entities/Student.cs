using System;
using System.ComponentModel.DataAnnotations;

namespace EFCoreTest.Models.Repository.Models
{
    public class Student
    {
        public Guid StudentId { get; set; }
        
        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters")]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}