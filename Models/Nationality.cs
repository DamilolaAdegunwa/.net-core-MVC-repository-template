using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GRA.Data.Base;

namespace GRA.Models
{
    public class Nationality: BaseModel
    {

        [Required(ErrorMessage = "Пожалуйста введите Национальность")]
        [Display(Name = "Национальность")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
