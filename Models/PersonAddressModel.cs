using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GRA.Models
{
    public class PersonAddressModel
    {
        public Guid Id { get; set; }

        public Guid? PersonId { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }


        public PersonModel Person { get; set; }
    }
}
