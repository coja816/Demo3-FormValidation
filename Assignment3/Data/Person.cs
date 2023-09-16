using System.ComponentModel.DataAnnotations;

namespace Assignment3.Data
{
    public class Person
    {
        [Required]
        [StringLength(12, MinimumLength = 5, ErrorMessage = "Required and must be of length 5 to 12")]
        public string userID { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 7, ErrorMessage = "Required and must be of length 7 to 12")]
        public string password { get; set; }

        //optional
        public string address { get; set; }

        [Required]
        [StringLength(99, MinimumLength = 3, ErrorMessage = "Required and alphabates only")]
        public string name { get; set; }

        [Required(ErrorMessage = "Required. Must be a valid email")]
        [RegularExpression(@"^[\w\.-]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Invalid email format")]
        public string email { get; set; }

        [Required(ErrorMessage = "Required. Must be numeric only and be 5 numbers")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "You must input 5 numbers for the zip code")]
        public double zipCode { get; set; }

        [Required(ErrorMessage = "Gender selection is required")]
        public string sex { get; set; }


        //Optional
        public string about { get; set; }

        [Required(ErrorMessage = "A counntry must be selected")]
        public string country { get; set; } = "";

        //Language selection between english vs non english
        [Required(ErrorMessage = "Language selection is required")]
        public bool LanguageEnglish { get; set; }

        [Required(ErrorMessage = "Language selection is required")]
        public bool LanguageNonEnglish { get; set; }

    }
}
