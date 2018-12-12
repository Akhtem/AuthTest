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

        public string Password { get; set; }
    }
}