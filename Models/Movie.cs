using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp3.Models
{
    public class Movie
    {
        [Required(ErrorMessage = "This is a required field")]
        public string Category { get; set; }
        [Required(ErrorMessage = "This is a required field")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This is a required field")]
        public string Year { get; set; }
        [Required(ErrorMessage = "This is a required field")]
        public string Director { get; set; }
        [Required(ErrorMessage = "This is a required field")]
        public string Rating { get; set; }
        [Required(ErrorMessage = "This is a required field")]
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25, ErrorMessage = "Maximum number of characters is 25")]
        public string Notes { get; set; }
    }
}
