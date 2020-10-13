using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GRA.Data.Base;
using GRA.Data;

namespace GRA.Models
{
    public class GraAdvocacyWorkPlaceName : BaseModel
    {
        public int GraAdvocacyWorkPlaceId { get; set; }

        [ForeignKey(nameof(GraAdvocacyWorkPlaceId))]
        public GraAdvocacyWorkPlace GraAdvocacyWorkPlace { get; set; }


        [Display(Name = "Наименование адвокатского учреждения")]
        public string Name { get; set; }
    }
}