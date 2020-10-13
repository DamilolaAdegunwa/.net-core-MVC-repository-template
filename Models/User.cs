using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace GRA.Models
{
    public class 
        User : IdentityUser
    {
        public int Year { get; set; }
        public int DepartmentId { get; set; } //структурное отделение почты
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        
        
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }

        public string FIO => $"{surname} {name} {patronymic}";
        public string PIN { get; set; }
        public bool ischanged { get; set; }
        public bool isActive { get; set; }
        [Common.Validation.DateRange]
        public DateTime CreatedAt { get; set; }
    }
}
