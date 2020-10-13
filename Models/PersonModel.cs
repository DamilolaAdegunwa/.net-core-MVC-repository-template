using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GRA.Models
{
    public class PersonModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Пин")]
        public string Pin { get; set; }

        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Дата рождения")]
        [Common.Validation.DateRange]
        public DateTime DateOfBirthDate { get; set; }

        [Display(Name = "Иностранец")]
        public bool IsGringo { get; set; }

        [Display(Name = "Регион")]
        public string BirthRegion { get; set; }

        [Display(Name = "Место рождения")]
        public string BirthLocality { get; set; }

        [NotMapped] public string BirthPlace => $"{BirthRegion} {BirthLocality}";



        [Display(Name = "Код состояния")]
        public int StatusCode { get; set; }

        [Display(Name = "Из ГРС")]
        public bool FromGrs { get; set; }

        [Display(Name = "Пол")]
        public string Gender { get; set; }

        [Display(Name = "Семейное положение")]
        public string MaritalStatus { get; set; }

        [Display(Name = "Национальность")]
        public string Nationality { get; set; }
        public string NationalityID { get; set; }

        [Display(Name = "Гражданство")]
        public string Citizenship { get; set; }

        public virtual ICollection<PersonPhotoModel> Photos { get; set; }

        public virtual ICollection<PersonDocumentModel> Documents { get; set; }

        public virtual ICollection<PersonAddressModel> Addresses { get; set; }


    }
}
