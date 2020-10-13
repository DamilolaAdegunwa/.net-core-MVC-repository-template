using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GRA.Data.Base;
using GRA.Data;

namespace GRA.Models
{
    public class GraAdvocacyInfo : BaseModel
    {
        public int GraPersonId { get; set; }

        [ForeignKey(nameof(GraPersonId))] 
        public GraPerson GraPerson { get; set; }


        [Display(Name = "Тип")] 
        public GraAdvocacyInfoDateType Type { get; set; }


        [Required(ErrorMessage = "Дата")]
        [DataType(DataType.Date)]
        [Display(Name = "Дата")]
        [Common.Validation.DateRange]
        public DateTime ActionDate { get; set; }
    }


    public enum GraAdvocacyInfoDateType : byte
    {
        [Display(Name = "Вступление в адвокатуру")]
        In = 1,

        [Display(Name = "Выход из адвокатуры")]
        Out = 2
    }

    public class GraAdvocacyInfoDateTypeViewModel
    {
        public GraAdvocacyInfoDateType DocumentType { get; set; }
    }
}