using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DocumentFormat.OpenXml.Math;
using GRA.Data.Base;
using GRA.Data;

namespace GRA.Models
{
    public class GraLicenseTermination : BaseModel
    {
        
        
        public int GraLicenceInfoId { get; set; }

        [ForeignKey(nameof(GraLicenceInfoId))] public GraLicenceInfo GraLicenceInfo { get; set; }
        
        [Display(Name = "Дата прекращения лицензии")]
        [DataType(DataType.Date)]
        [Common.Validation.DateRange]
        public DateTime WithdrawalDate { get; set; }
        


        [Required(ErrorMessage = "Пожалуйста введите Номер приказа о прекращении лицензии")]
        [Display(Name = "Номер приказа о прекращении лицензии")]
        [StringLength(60)]
        public string LicenseWithdrawalOrderNumber { get; set; }
        
        
        public int GraLicenseTerminationBasementId { get; set; }

        [ForeignKey(nameof(GraLicenseTerminationBasementId))]
        public GraLicenseTerminationBasement GraLicenseTerminationBasement { get; set; }
    }
}