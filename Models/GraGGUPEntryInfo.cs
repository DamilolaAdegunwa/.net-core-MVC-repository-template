using GRA.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GRA.Data.Base;

namespace GRA.Models
{
    public class GraGGUPEntryInfo : BaseModel
    {
        public int GraGGUPId { get; set; }

        [ForeignKey(nameof(GraGGUPId))]
        public GraGGUP GraGGUP { get; set; }
        
        
        [Required(ErrorMessage = "Пожалуйста ввкдите Дату вступления")]
        [DataType(DataType.Date)]
        [Display(Name = "Дата вступления")]
        [Common.Validation.DateRange]
        public DateTime EntryDate { get; set; }
        
        
        [Display(Name = "Номер приказа о вступлении")]
        public string EntryOrderName { get; set; }
    }
}