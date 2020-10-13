using System.ComponentModel.DataAnnotations.Schema;
using GRA.Data.Base;
using GRA.Data;

namespace GRA.Models
{
    public class GraAdvocacyWorkPlaceCredentials: BaseModel
    {
        
        public int GraAdvocacyWorkPlaceId { get; set; }

        [ForeignKey(nameof(GraAdvocacyWorkPlaceId))]
        public GraAdvocacyWorkPlace GraAdvocacyWorkPlace { get; set; }
        
        public string BankName { get; set; }
        public string Credentials { get; set; }

    }
}