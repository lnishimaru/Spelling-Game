using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SpellingGame.Models
{
    public class Form1
    {
        [Required(ErrorMessage = "Please enter your answer")]
        public string Answer { get; set; }
        public int Occurrence { get; }
    }
}
