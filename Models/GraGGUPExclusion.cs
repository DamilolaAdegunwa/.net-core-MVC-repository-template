using GRA.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GRA.Data.Base;

namespace GRA.Models
{
    public class GraGGUPExclusion : BaseModel
    {
        public int GraGGUPId { get; set; }

        [ForeignKey(nameof(GraGGUPId))] public GraGGUP GraGGUP { get; set; }


        [Required(ErrorMessage = "Пожалуйста ввкдите дату исключения")]
        [DataType(DataType.Date)]
        [Display(Name = "Дата исключения")]
        [Common.Validation.DateRange]
        public DateTime ExclusionDate { get; set; }


        [Display(Name = "Номер приказа об исключения")]
        public string ExclusionOrderName { get; set; }


        public int GraGGUPExclusionBasementId { get; set; }

        [ForeignKey(nameof(GraGGUPExclusionBasementId))]
        public GraGGUPExclusionBasement GraGGUPExclusionBasement { get; set; }
    }
}