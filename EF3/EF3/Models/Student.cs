using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EF3.Models
{
    
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set;}
        [Required]
        public int StudentAge { get; set;}
    }
}
