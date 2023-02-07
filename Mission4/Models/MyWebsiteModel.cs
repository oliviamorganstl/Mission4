using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MyWebsiteModel
    {
        [Required]
        [Range(0,100)]
        public string Assignments { get; set; } //Does automatic getters and settings as long as we call this line
        [Required]
        [Range(0, 100)]
        public string Projects { get; set; } //I change these variables to integers later.
        [Required]
        [Range(0, 100)]
        public string Quizzes { get; set; }
        [Required]
        [Range(0, 100)]
        public string Midterm { get; set; }
        [Required]
        [Range(0, 100)]
        public string Final { get; set; }
        [Required]
        [Range(0, 100)]
        public string Intex { get; set; }
    }
}
