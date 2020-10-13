using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GRA.Data.Base;
using GRA.Data;
using Microsoft.AspNetCore.Http;

namespace GRA.Models
{
    public class GraLicenceInfo : BaseModel
    {
        public int GraPersonId { get; set; }

        [ForeignKey(nameof(GraPersonId))] public GraPerson GraPerson { get; set; }

        public int GraLicenseStatusId { get; set; }

        [ForeignKey(nameof(GraLicenseStatusId))]
        public GraLicenseStatus GraLicenseStatus { get; set; }

        public int GraLicenseBasementId { get; set; }

        [ForeignKey(nameof(GraLicenseBasementId))]
        public GraLicenseBasement GraLicenseBasement { get; set; }
        
        
        public int? GraLicenseStopInfoId { get; set; }

        [ForeignKey(nameof(GraLicenseStopInfoId))]
        public GraLicenseStopInfo GraLicenseStopInfo { get; set; } 
        
        
        public int? GraLicenseWithdrawalId { get; set; }

        [ForeignKey(nameof(GraLicenseWithdrawalId))]
        public GraLicenseWithdrawal GraLicenseWithdrawal { get; set; }

        public int? GraLicenseTerminationId { get; set; }

        [ForeignKey(nameof(GraLicenseTerminationId))]
        public GraLicenseTermination GraLicenseTermination { get; set; }


        [Display(Name = "Выписка из экзаменационного листа")]
        public string[] ExamPath { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Выписка из экзаменационного листа")]
        [NotMapped]
        public IFormFileCollection ExamFile { get; set; }


        [Display(Name = "Дата прохождения квалификационного экзамена")]
        [DataType(DataType.Date)]
        [Common.Validation.DateRange]
        public DateTime ExamDate { get; set; }

        [Display(Name = "Дата выдачи лицензии")]
        [DataType(DataType.Date)]
        [Common.Validation.DateRange]
        public DateTime LicenseDate { get; set; }


        public ICollection<GraLicenseNumber> GraLicenseNumbers { get; set; }
    }
}