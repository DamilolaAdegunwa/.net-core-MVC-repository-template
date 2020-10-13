using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GRA.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace GRA.Data.Base
{
    public class BaseModel : IEntity
    {
        [Key]
        public int Id { get; set; }

        [ScaffoldColumn(false)]
        [DefaultValue(true)] public bool IsActive { get; set; } = true;
        
        [ScaffoldColumn(false)]
        public string CreatorId { get; set; }
        
        
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? CreationDate { get; set; }
    }
}