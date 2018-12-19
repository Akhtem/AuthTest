using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SignInForm.Models
{
    public class EditModel
    {
        [Required(ErrorMessage = "Поле должно быть установлено")]
        
        [Range(1890, 2017, ErrorMessage = "Недопустимый год")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Некорректное имя")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Некорректная фамилия")]
        public string SurName { get; set; }

        public string Country { get; set; }

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