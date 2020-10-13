using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using GRA.Data.Base;

namespace GRA.Models
{
    public class Page: BaseModel
    {
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        public string URL { get; set; }
        public string IconName { get; set; }
        public int? ParentId { get; set; }
    }
}
