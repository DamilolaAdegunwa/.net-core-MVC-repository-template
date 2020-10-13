using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace GRA.Models
{
    public class RolePageVM
    {
        public int Id { get; set; }
        [Display(Name = "Наименование страницы")]
        public string PageName { get; set; }
        [Required(ErrorMessage = "Заполните поле {0}")]
        [Display(Name = "Тип страницы")]
        public int PageId { get; set; }


        [Display(Name = "Наименование роли")]
        public string DepartmentName { get; set; }
        [Required(ErrorMessage = "Заполните поле {0}")]
        [Display(Name = "Тип роли")]
        public int DepartmentId { get; set; }
    }
}
