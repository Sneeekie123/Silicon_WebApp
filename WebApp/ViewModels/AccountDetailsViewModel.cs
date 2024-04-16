using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels;

public class AccountDetailsViewModel
{
    public AccountBasicInfo? Basic {  get; set; }

    public AccountAddressInfo? Address { get; set; }
}

public class AccountBasicInfo
{


    [Display(Name = "First name", Prompt = "Enter your first name")]
    [Required]
    public string FirstName { get; set; } = null!;


    [Display(Name = "Last name", Prompt = "Enter your last name")]
    [Required]
    public string LastName { get; set; } = null!;

    [DataType(DataType.EmailAddress)]
    [Display(Name = "E-mail address", Prompt = "Enter your e-mail address")]
    [Required]
    public string Email { get; set; } = null!;

    [Display(Name = "Phone (optional)", Prompt = "Enter your phone")]
    public string? PhoneNumber { get; set; }

    [Display(Name = "Bio (optional)", Prompt = "Add a short bio...")]
    public string? Bio { get; set; }

}

public class AccountAddressInfo
{
    [Display(Name = "AddressLine_1", Prompt = "Enter your first address line")]
    [Required]
    public string AddressLine_1 { get; set; } = null!;

    [Display(Name = "AddressLine_´2", Prompt = "Enter your second address line")]
    public string? AddressLine_2 { get; set; }

    [Display(Name = "Postal code", Prompt = "Enter your postal code")]
    [Required]
    public string PostalCode { get; set; } = null!;

    [Display(Name = "City", Prompt = "Enter your city")]
    [Required]
    public string City { get; set; } = null!;

}