using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
         public string Username { get; set; }
         
         [Required]
         [StringLength(8, MinimumLength = 4, ErrorMessage = "pw must be 4-8 characters")]
         public string Password { get; set; }
    }
}