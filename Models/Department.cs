using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GRA.Data.Base;

namespace GRA.Models
{
    public class Department: BaseModel
    {
        [Display(Name = "Наименование")]
        public string Name { get; set; }
    }
}
