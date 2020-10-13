using GRA.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GRA.Data.Base;

namespace GRA.Models
{
    public class GraGGUPSuspension : BaseModel
    {
        public int GraGGUPId { get; set; }

        [ForeignKey(nameof(GraGGUPId))] public GraGGUP GraGGUP { get; set; }


        [Required(ErrorMessage = "Пожалуйста ввкдите дату приостановления")]
        [DataType(DataType.Date)]
        [Display(Name = "Дата приостановления")]
        [Common.Validation.DateRange]
        public DateTime SuspensionDate { get; set; }


        [Display(Name = "Номер приказа о приостановлении")]
        public string SuspensionOrderName { get; set; }


        public int GraGGUPSuspensionBasementId { get; set; }

        [ForeignKey(nameof(GraGGUPSuspensionBasementId))]
        public GraGGUPSuspensionBasement GraGGUPSuspensionBasement { get; set; }
    }
}