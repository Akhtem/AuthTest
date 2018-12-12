using System;
using System.ComponentModel.DataAnnotations;

namespace SignInForm.Models
{
    public class RegisterAccount
    {
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Range(1890, 2017, ErrorMessage = "Недопустимый год")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Длина строки должна быть от 5 до 10 символов")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }


    }
}