using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GRA.Data.Base;
using Microsoft.AspNetCore.Identity;

namespace GRA.Models
{
    public class PageVM: BaseModel
    {
        [Required(ErrorMessage = "Заполните поле {0}")]
        [Display(Name = "Наименование страницы")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Заполните поле {0}")]
        [Display(Name = "Родитель")]
        public int? ParentId { get; set; }
        [Display(Name = "Родитель")]
        public string ParentName { get; set; }
        [Required(ErrorMessage = "Заполните поле {0}")]
        [Display(Name = "Путь")]
        public string URL { get; set; }
        public bool RoleHas { get; internal set; }
    }
}
