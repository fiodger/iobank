using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace Bank.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }

    [Table("UserProfile")]
    public class UserProfile
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
    }

    public class RegisterExternalLoginModel
    {
        [Required]
        [Display(Name = "Login")]
        public string UserName { get; set; }

        public string ExternalLoginData { get; set; }
    }

    public class LocalPasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Obecne hasło")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Hasło musi skłądać sie z przynajmniej 6 znaków w tym dwie duże litery.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nowe hasło")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź nowe hasło")]
        [Compare("NewPassword", ErrorMessage = "Hasła nie są identyczne")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "Nazwa Użytkownika")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Display(Name = "Zapamiętaj hasło?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
    {
        [Required]
        [Display(Name = "Imię")]
        public string UserFirstName { get; set; }
        [Required]
        [Display(Name = "Nazwisko")]
        public string UserSurname { get; set; }
        [Required]
        [StringLength(11, ErrorMessage = "Pesel musi się skłądać z 11 liczb.", MinimumLength = 11)]
        [Display(Name = "Pesel")]
        public string UserId { get; set; }
        [Required]
        [Display(Name = "Nick")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Hasło musi się skłądać z przynajmniej 6 znaków w tym dwie duże litery.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Powtórz hasło")]
        [Compare("Password", ErrorMessage = "Hasła są różne")]
        public string ConfirmPassword { get; set; }
    }

    public class KontaktModel
    {
        [Required]
        [Display(Name = "Imię")]
        public string KontaktFirstName { get; set; }
        [Required]
        [Display(Name = "Nazwisko")]
        public string KontaktSurname { get; set; }
        [Required]
        [StringLength(11, ErrorMessage = "Pesel musi się skłądać z 11 liczb.", MinimumLength = 11)]
        [Display(Name = "Pesel")]
        public string KontaktId { get; set; }
        [Required]
        [Display(Name = "Text")]
        public string KontaktText { get; set; }
    }

    public class PrzlewModel
    {
        [Required]
        [Display(Name = "Imię")]
        public string PrzelewFirstName { get; set; }
        [Required]
        [Display(Name = "Nazwisko")]
        public string PrzelewSurname { get; set; }
        [Required]
        [StringLength(26, ErrorMessage = "Nr rachunku musi skłądać się z 26 cyfr", MinimumLength = 26)]
        [Display(Name = "Nr rachunku")]
        public int PrzelewId { get; set; }
        [Required]
        [Display(Name = "Tytuł")]
        public string PrzelewText { get; set; }
    }

    public class PrzlewCyklicznyModel
    {
        [Required]
        [Display(Name = "Imię")]
        public string CPrzelewFirstName { get; set; }
        [Required]
        [Display(Name = "Nazwisko")]
        public string CPrzelewSurname { get; set; }
        [Required]
        [StringLength(26, ErrorMessage = "Nr rachunku musi skłądać się z 26 cyfr", MinimumLength = 26)]
        [Display(Name = "Nr rachunku")]
        public int CPrzelewId { get; set; }
        [Required]
        [Display(Name = "Tytuł")]
        public string CPrzelewText { get; set; }
        [Required]
        [Display(Name = "Cykliczny co ile dni")]
        public int CPrzelewTime { get; set; }
    }

    public class ExternalLogin
    {
        public string Provider { get; set; }
        public string ProviderDisplayName { get; set; }
        public string ProviderUserId { get; set; }
    }
}
