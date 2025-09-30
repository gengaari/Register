using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(20)]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Имя пользователя может содержать только буквы, цифры и подчёркивания.")]
        [Remote(action: "CheckUsername", controller: "Account", ErrorMessage = "Имя пользователя уже занято.")]
        public string Username { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Неверный формат email.")]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [Range(18, 100, ErrorMessage = "Возраст должен быть от 18 до 100 лет.")]
        public int Age { get; set; }

        [Url]
        public string Website { get; set; }

        [CreditCard]
        public string CreditCardNumber { get; set; }

        [ValidateNever]
        public bool TermsOfService { get; set; }
    }
}
