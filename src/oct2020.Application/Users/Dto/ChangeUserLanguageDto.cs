using System.ComponentModel.DataAnnotations;

namespace oct2020.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}