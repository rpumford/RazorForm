using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorForm.Models
{
    public class MeaningResponse
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must have some thought about the meaning of life...")]
        public string Response { get; set; }

    }
}
