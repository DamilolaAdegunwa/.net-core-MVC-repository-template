using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRA.Models
{
    public class PersonPhotoModel
    {
        public Guid Id { get; set; }

        public Guid PersonId { get; set; }

        public string Photo { get; set; }
        public string PhotoPath { get; set; }

        public string PhotoBase { get; set; }

        public virtual PersonModel Person { get; set; }
    }
}