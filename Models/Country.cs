using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GRA.Data.Base;

namespace GRA.Models
{
    [Display(Name = "Страна")]
    public class Country : BaseModel
    {
        [Required(ErrorMessage = "Пожалуйста введите Страну")]
        [Display(Name = "Страна")]
        [StringLength(50)]
        public string InstitutionName { get; set; }
    }
}
