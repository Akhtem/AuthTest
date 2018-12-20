using System;
using System.ComponentModel.DataAnnotations;

namespace SignInForm.Models
{
    public class RegisterAccount
    {
        [Required(ErrorMessage = "Поле Электронной почты должно быть установлено")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный электронный адрес")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле Года должно быть установлено")]
        [Range(1890, 2017, ErrorMessage = "Недопустимый год")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Поле Пароля должно быть установлено")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Длина Пароля должна быть от 5 до 10 символов")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Поле Подтверждения пароля должно быть установлено")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "Поле Имя должно быть установлено")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Некорректное имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле Фамилия должно быть установлено")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Некорректная фамилия")]    
        public string SurName { get; set; }

        public string Country { get; set; }


    }
}