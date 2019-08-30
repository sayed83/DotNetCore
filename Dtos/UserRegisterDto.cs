using System.ComponentModel.DataAnnotations;

namespace My.Api.Dtos
{
    public class UserRegisterDto
    {   
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, ErrorMessage= "Password Should be 8 charecter long!")]
        public string Password{ get; set; }   
    }
}