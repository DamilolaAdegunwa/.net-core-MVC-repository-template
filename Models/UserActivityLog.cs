using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GRA.Data.Base;
using GRA.Data;

namespace GRA.Models
{
    public class UserActivityLog : BaseModel
    {
        
        [Display(Name = "Запрос")]
        public string Request { get; set; }
        [Display(Name = "Ответ")]
        public string Response { get; set; }
        [Display(Name = "Пользователь")]
        public string User { get; set; }
        public string ServiceCode { get; set; }
        [Display(Name = "Время")]
        [Common.Validation.DateRange]
        public DateTime CreatedAt { get; set; }
    }
}
