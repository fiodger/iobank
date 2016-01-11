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
        [Display(Name = "User name")]
        public string UserName { get; set; }

        public string ExternalLoginData { get; set; }
    }

    public class LocalPasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
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

    public class ExternalLogin
    {
        public string Provider { get; set; }
        public string ProviderDisplayName { get; set; }
        public string ProviderUserId { get; set; }
    }
}
