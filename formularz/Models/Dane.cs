using System.ComponentModel.DataAnnotations;
namespace formularz.Models;

public class Dane
{
    [Required(ErrorMessage = "Prosze podaj Imie")] 
    [MinLength(2,ErrorMessage = "Imie musi miec conajmniej 2 znaki")]
    public string Name { get; set; } 
    
    [Required(ErrorMessage = "Prosze podaj nazwisko")] 
    [MinLength(2,ErrorMessage = "Nazwisko mu miec conajmniej 2 znaki")]
    public string Surname { get; set; } 
    
    [Required(ErrorMessage = "Prosze podaj Email")] 
    [RegularExpression(".+\\@.+\\.[a-z]{2,3}")] 
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Prosze podaj Hasło")] 
    [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).*$", ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, jedną dużą literę i jedną małą literę.")]
    [MinLength(8,ErrorMessage = "Hasło mu miec conajmniej 8 znaków")]
    public string Password { get; set; } 
    
    [Required(ErrorMessage = "Potwierdzenie hasła jest wymagane.")]
    [Compare("Password", ErrorMessage = "Hasło i potwierdzenie hasła nie są identyczne.")]
    public string ConfirmPassword { get; set; }
    
    [Required(ErrorMessage = "Numer telefonu jest wymagany.")]
    [RegularExpression(@"^(?:(\+|00)48)?[ -]?\d{3}[ -]?\d{3}[ -]?\d{3}$", ErrorMessage = "Numer telefonu musi składać się z cyfr .")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Wiek jest wymagany.")]
    [Range(11, 80, ErrorMessage = "Wiek musi być w zakresie od 11 do 80 lat.")]
    public int Age { get; set; }
    
    public Kategorie CityCategory { get; set; }

}

