using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GRA.Models
{
    public class ChangePasswordVM
    {
        public class ChangeUserPassVM
        {
            public int UserId { get; set; }

            [Required(ErrorMessage = "Заполните поле {0}")]
            [Display(Name = "Пароль")]
            public string CurrentPassword { get; set; }

            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$", ErrorMessage = "Пароль должен содержать от 6 до 20 символов и содержать минимум одну букву, одну цифру.")]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Подтвердить пароль")]
            [Compare("NewPassword", ErrorMessage = "Пароли не совпадают.")]
            public string PasswordConfirm { get; set; }
        }
    }
}
