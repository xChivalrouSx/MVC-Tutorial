using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name="Name")]
        public string StudentName { get; set; }

        [Required]
        public int Age { get; set; }
    }
}