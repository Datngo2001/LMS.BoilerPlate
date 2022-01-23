using System.ComponentModel.DataAnnotations;

namespace LMS.BoilerPlate.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}