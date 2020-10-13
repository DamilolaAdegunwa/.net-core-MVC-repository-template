using GRA.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GRA.Data.Base;

namespace GRA.Models
{
    public class GraLicenseNumber : BaseModel
    {
        
        public int GraLicenceInfoId { get; set; }

        [ForeignKey(nameof(GraLicenceInfoId))] public GraLicenceInfo GraLicenceInfo { get; set; }




        [Display(Name = "Дупликат")]
        public bool IsDuplicate { get; set; }

        [Display(Name = "Дата выдачи лицензии")]
        [DataType(DataType.Date)]
        [Common.Validation.DateRange]
        public DateTime LicenseDate { get; set; }
        
        
        [Required(ErrorMessage = "Пожалуйста введите Номер лицензии")]
        [Display(Name = "Номер лицензии")]
        [StringLength(60)]
        public string LicenseNumber { get; set; }
        
        [Required(ErrorMessage = "Пожалуйста введите Номер приказа о выдаче лицензии")]
        [Display(Name = "Номер приказа о выдаче лицензии")]
        [StringLength(60)]
        public string LicenseOrderNumber { get; set; }
    }
}