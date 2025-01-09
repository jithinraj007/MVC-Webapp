using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployeeDepartment
    {
        [Required]
        public int Id { get; set; }

        [MaxLength(100,ErrorMessage ="Max length is 100")]
        [MinLength(100,ErrorMessage ="Max length is 100")]

        public string Name { get; set; }
    }
}