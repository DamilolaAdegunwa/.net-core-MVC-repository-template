using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GRA.Data.Base;
using GRA.Data;
using Microsoft.AspNetCore.Http;

namespace GRA.Models
{
    public class GraApplicant : BaseModel
    {
        public int GraPersonId { get; set; }

        [ForeignKey(nameof(GraPersonId))] public GraPerson GraPerson { get; set; }


        [DataType(DataType.Upload)]
        [NotMapped]
        [Display(Name = "Результат квалификационного экзамена ")]
        public IFormFileCollection DocumentFile { get; set; }


        [Display(Name = "Результат квалификационного экзамена ")]
        public string[] DocumentsPath { get; set; }


        [DataType(DataType.Upload)]
        [NotMapped] 
        [Display(Name = "Заявление о допуске к сдаче квалификационного экзамена на получение лицензии")]
        public IFormFile DocumentStatementFile { get; set; }


        [Display(Name = "Заявление о допуске к сдаче квалификационного экзамена на получение лицензии")]
        public string DocumentStatementPath { get; set; }


        [DataType(DataType.Upload)]
        [NotMapped]
        [Display(Name = "Личный листок по учету кадров")]
        public IFormFile DocumentPersonalSheetFile { get; set; }


        [Display(Name = "Личный листок по учету кадров")]
        public string DocumentPersonalSheetPath { get; set; }


        [DataType(DataType.Upload)]
        [NotMapped]
        [Display(Name = "Нотариально удостоверенная копия диплома о высшем юридическом образовании")]
        public IFormFile DocumentDiplomaFile { get; set; }


        [Display(Name = "Нотариально удостоверенная копия диплома о высшем юридическом образовании")]
        public string DocumentDiplomaPath { get; set; }


        [DataType(DataType.Upload)]
        [NotMapped]
        [Display(Name = "Нотариально удостоверенная или удостоверенная по последнему месту работы копия трудовой книжки")]
        public IFormFile DocumentWorkbookFile { get; set; }


        [Display(Name = "Нотариально удостоверенная или удостоверенная по последнему месту работы копия трудовой книжки")]
        public string DocumentWorkbookPath { get; set; }


        [DataType(DataType.Upload)]
        [NotMapped]
        [Display(Name = "Характеристика с последнего места работы")]
        public IFormFile DocumentCharacteristicFile { get; set; }


        [Display(Name = "Характеристика с последнего места работы")]
        public string DocumentCharacteristicPath { get; set; }
    }
}