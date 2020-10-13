using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GRA.Data.Base;
using GRA.Data;

namespace GRA.Models
{
    public class GraFIO : BaseModel
    {
        [MaxLength(14)]
        [MinLength(14)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "ИНН может содержать только цифры")]
        [Display(Name = "ИНН")]
        [StringLength(50)]
        public string INN { get; set; }


        [Required(ErrorMessage = "Пожалуйста введите Фамилию")]
        [Display(Name = "Фамилия")]
        [StringLength(60)]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите Имя")]
        [Display(Name = "Имя")]
        [StringLength(60)]
        public string Firstname { get; set; }


        [Display(Name = "Отчество")]
        [StringLength(60)]
        public string Middlename { get; set; }

        public int GraPersonId { get; set; }

        [ForeignKey(nameof(GraPersonId))] public GraPerson GraPerson { get; set; }

        public override string ToString()
        {
            return $"{Lastname} {Firstname} {Middlename}";
        }
    }
}