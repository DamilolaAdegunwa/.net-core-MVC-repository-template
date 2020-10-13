using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GRA.Data.Base;
using Microsoft.EntityFrameworkCore;

namespace GRA.Models
{
    public class EditorsAndCreators: BaseModel
    {
        
        public EntityState State { get; set; }
        
        [MaxLength(200)]
        public string Table { get; set; }

        public int ModifiedId { get; set; }
        public string UserId { get; set; }
        [Common.Validation.DateRange]
        public DateTime CreationTime { get; set; }

        public string ValueJson { get; set; }
        public string StackTrace { get; set; }
    }
}