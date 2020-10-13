using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GRA.Data.Base;
using GRA.Data;

namespace GRA.Models
{
    public class GraLicenseStopInfo : BaseModel
    {
        public int GraLicenceInfoId { get; set; }

        [ForeignKey(nameof(GraLicenceInfoId))] public GraLicenceInfo GraLicenceInfo { get; set; }
        public int GraLicenseStopBasementId { get; set; }

        [ForeignKey(nameof(GraLicenseStopBasementId))]
        public GraLicenseStopBasement GraLicenseStopBasement { get; set; }

        [Display(Name = "Дата приостановления действия лицензии")]
        [DataType(DataType.Date)]
        [Common.Validation.DateRange]
        public DateTime StopDate { get; set; }
        
        
        [Display(Name = "Дата возобновления действия приостановленной лицензии")]
        [DataType(DataType.Date)]
        [Common.Validation.DateRange]
        public DateTime RestoreDate { get; set; }
        
        
        [Display(Name = "Срок приостановления лицензии")]
        // [DataType(DataType.Date)]
        public TimeSpan Term { get; set; }


        [Required(ErrorMessage = "Пожалуйста введите Номер приказа о приостановлении действия лицензиии")]
        [Display(Name = "Номер приказа о приостановлении действия лицензии")]
        [StringLength(60)]
        public string LicenseStopOrderNumber { get; set; }
    }
}