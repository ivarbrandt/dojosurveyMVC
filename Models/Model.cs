using System.ComponentModel.DataAnnotations;

namespace dojo_survey.Models
{

    public class Survey
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Location")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Language")]
        public string Language { get; set; }

        [MaxLength(20)]
        [Display(Name = "Comment")]
        public string Comment { get; set; }
    }
}