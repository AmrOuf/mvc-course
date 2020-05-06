using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day1
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(128)]
        [EmailAddress]
        public string Email { get; set; }
        public int Salary { get; set; }
        [MaxLength(256)]
        public string Address { get; set; }
    }
}