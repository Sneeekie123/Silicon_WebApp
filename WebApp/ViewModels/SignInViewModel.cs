using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels;

public class SignInViewModel
{
    [DataType(DataType.EmailAddress)]
    [Display(Name = "E-mail address", Prompt = "Enter your e-mail address")]
    [Required(ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;


    [DataType(DataType.Password)]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [Required(ErrorMessage = "Invalid password")]
    public string Password { get; set; } = null!;


    [Display(Name = "Remember me", Prompt = "Remember me")]
    public bool IsPresistent { get; set; }
}
