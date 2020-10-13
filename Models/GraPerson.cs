using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using GRA.Data.Base;
using GRA.Data;
using Microsoft.AspNetCore.Http;

namespace GRA.Models
{
    public class GraPerson : BaseModel
    {
        [NotMapped] public GraFIO GraFIO => GraFIOs?.OrderBy(x => x.Id)?.LastOrDefault();

        [Display(Name = "ФИО", AutoGenerateField = true, AutoGenerateFilter = true)]
        public ICollection<GraFIO> GraFIOs { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите Фамилию")]
        [Display(Name = "Фамилия")]
        [StringLength(60)]
        [NotMapped]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите Имя")]
        [Display(Name = "Имя")]
        [StringLength(60)]
        [NotMapped]
        public string Firstname { get; set; }


        [Display(Name = "Отчество")]
        [StringLength(60)]
        [NotMapped]
        public string Middlename { get; set; }


        public int CitezenshipId { get; set; }

        [Display(Name = "Гражданство", AutoGenerateField = true, AutoGenerateFilter = true)]
        [ForeignKey(nameof(CitezenshipId))]
        public Country Citezenship { get; set; }

        public int SexId { get; set; }

        [Display(Name = "Пол", AutoGenerateField = true, AutoGenerateFilter = true)]
        [ForeignKey(nameof(SexId))]
        public Sex Sex { get; set; }

        
        
        [Display(Name = "Местожительство (адрес) ", AutoGenerateField = true, AutoGenerateFilter = true)]
        public string LivingAddress { get; set; }
        
        [Required(ErrorMessage = "Пожалуйста введите Дату рождения")]
        [DataType(DataType.Date)]
        [Display(Name = "Дата рождения")]
        [Common.Validation.DateRange]
        public DateTime BirthDate { get; set; }
        
        [Display(Name = "Серия и номер документа")]
        [StringLength(200)]
        public string DocumentID { get; set; }


        [Display(Name = "Дата выдачи")]
        [DataType(DataType.Date)]
        [Common.Validation.DateRange]
        public DateTime? DocumentDate { get; set; }

        // [Required(ErrorMessage = "Кем выдан документ")]
        [Display(Name = "Кем выдан документ")] public string DocumentIssuingAuthority { get; set; }
        
        [Display(Name = "Фотография")]
        public string PhotoPath { get; set; }
        
        [DataType(DataType.Upload)]
        [Display(Name = "Фотография")]
        [NotMapped]
        public IFormFile PhotoFile { get; set; }
        
        
        [Display(Name = "Копия паспорта")]
        public string[] PassportPath { get; set; }
        
        [DataType(DataType.Upload)]
        [Display(Name = "Копия паспорта")]
        [NotMapped]
        public IFormFileCollection PassportFile { get; set; }
        
        
        
    }
}