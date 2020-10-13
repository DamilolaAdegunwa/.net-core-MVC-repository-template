using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GRA.Models
{
    public class PersonDocumentModel
    {
        public Guid Id { get; set; }

        public Guid PersonId { get; set; }

        public Guid DocumentTypeId { get; set; }

        [Display(Name = "Номер")]
        public string DocumentNumber { get; set; }

        [Display(Name = "Серия")]
        public string DocumentSeries { get; set; }

        [Display(Name = "Орган")]
        public string DocumentIssueOrgan { get; set; }

        [Display(Name = "Дата выпуска")]
        [DataType(DataType.Date)]
        [Common.Validation.DateRange]
        public DateTime DocumentIssueDate { get; set; }

        [Display(Name = "Срок действия")]
        [DataType(DataType.Date)]
        [Common.Validation.DateRange]
        public DateTime DocumentExpireDate { get; set; }
        [Display(Name = "Действителен")]
        public bool IsValid { get; set; }
        [Display(Name = "Примечание")]
        public string Note { get; set; }

        public PersonModel Person { get; set; }

    }
}