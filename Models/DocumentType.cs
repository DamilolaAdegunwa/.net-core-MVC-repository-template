using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GRA.Models
{
    public enum DocumentType
    {
        [Display(Name = "Паспорт")]
        Passport = 0,
        [Display(Name = "Свидетельство о рождении")]
        BirthСertificate = 1,
        [Display(Name = "Водительские права")]
        DriverLicense = 2,
        [Display(Name = "Нет")]
        No = 3
    }

    public class DocumentTypeViewModel
    {
        public DocumentType DocumentType { get; set; }
    }

    public enum EducationStatus
    {
        [Display(Name = "Высшее")]
        High = 1,
        [Display(Name = "Неоконченное среднее")]
        NotMid = 2,
        [Display(Name = "Среднее специальное")]
        MidProf = 3,
        [Display(Name = "Начальное")]
        ProfBeg = 4,
        [Display(Name = "Cреднее")]
        Middle = 5,
        [Display(Name = "Не имеет")]
        No = 7,
    }

    public class EducationStatusViewModel
    {
        public DocumentType DocumentType { get; set; }
    }


    public enum MerrigeStatus
    {
        [Display(Name = "Женат/Замужем")]
        Yes = 1,
        [Display(Name = "Не женат/Не замужем")]
        No = 2,
        [Display(Name = "Разведен/Разведена")]
        Devorced = 3,
        [Display(Name = "Вдовец/Вдова")]
        Widow = 4,
        [Display(Name = "Гражданский брак")]
        City = 5,
        [Display(Name = "Неизвестно")]
        Unknown = 6,
    }

    public class MerrigeStatusViewModel
    {
        public MerrigeStatus DocumentType { get; set; }
    }

    public enum YesNoStatus
    {
        [Display(Name = "Да")]
        Yes = 1,
        [Display(Name = "Нет")]
        No = 2

    }

    public class YesNoStatusViewModel
    {
        public YesNoStatus DocumentType { get; set; }
    }

    
}
