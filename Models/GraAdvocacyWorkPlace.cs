using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GRA.Data.Base;
using GRA.Data;
using Microsoft.AspNetCore.Http;

namespace GRA.Models
{
    public class GraAdvocacyWorkPlace : BaseModel
    {
        public int GraPersonId { get; set; }

        [ForeignKey(nameof(GraPersonId))] public GraPerson GraPerson { get; set; }

        public int GraFormOfAdvocacyId { get; set; }

        [Display(Name = "Форма адвокатской деятельности")]
        [ForeignKey(nameof(GraFormOfAdvocacyId))]
        public GraFormOfAdvocacy GraFormOfAdvocacy { get; set; }

        [Display(Name = "Наименование адвокатского учреждения")]
        public string GraPlaceName { get; set; }

        [Required(ErrorMessage = "Дата учреждения адвокатского учреждения")]
        [DataType(DataType.Date)]
        [Display(Name = "Дата учреждения адвокатского учреждения")]
        [Common.Validation.DateRange]
        public DateTime EstablishmentDate { get; set; }



        [Display(Name = "Форма адвокатской деятельности")]
        public ICollection<GraAdvocacyWorkPlaceName> GraAdvocacyWorkPlaceNames { get; set; }        
        
        [Display(Name = "Юридический адрес адвокатского учреждения")]
        public string GraPlaceAddress { get; set; }
        
        
        
        [DataType(DataType.Upload)]
        [NotMapped]
        [Display(Name = "Образец печати")]
        public IFormFile StampSampleFile { get; set; }


        [Display(Name = "Образец печати")]
        public string StampSamplePath { get; set; }
        
        
        
        [Display(Name = "Данные о счете в финансово-кредитном учреждении")]
        public ICollection<GraAdvocacyWorkPlaceCredentials> GraAdvocacyWorkPlaceCredentials { get; set; }

        [Display(Name = "Номера телефонов")]
        public string[] PhoneNumbers { get; set; }
        
        
        [Display(Name = "Номера факсов")]
        public string[] FaxNumbers { get; set; }
        
        
        [Display(Name = "Адреса электронной почты")]
        public string[] Emails { get; set; }

    }
}