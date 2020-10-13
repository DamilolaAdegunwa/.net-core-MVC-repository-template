using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GRA.Models
{
    public class RolePageMap
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("DepartmentPK")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int PageId { get; set; }

        public bool IsActive { get; set; }
    }
}
