using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey_MVC.Models
{
    public class DojoStudent
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        public string Comment { get; set; }
    }
}