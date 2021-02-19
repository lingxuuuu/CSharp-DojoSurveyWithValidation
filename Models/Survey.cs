using System.ComponentModel.DataAnnotations;

namespace dojoSurveyWithValidation.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        public string Dojo_location { get; set; }
        [Required]
        public string Favorite_language { get; set; }
        [MinLength(20)]
        public string Comments { get; set; }
    }
}