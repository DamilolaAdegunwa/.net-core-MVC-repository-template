using System.ComponentModel.DataAnnotations;
using GRA.Data.Base;
using GRA.Data;
using Microsoft.EntityFrameworkCore;

namespace GRA.Models
{
    public class GraGGUPExclusionBasement : BaseModel,IFillData
    {
        [Display(Name = "Основание исключения")]
        public string Name { get; set; }

        public void FillData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GraGGUPExclusionBasement>().HasData(
                new Models.GraGGUPExclusionBasement {Id = 1, Name = "подачи заявления адвокатом"},
                new Models.GraGGUPExclusionBasement {Id = 2, Name = "расторжения договора об оказании квалифицированной юридической помощи"},
                new Models.GraGGUPExclusionBasement {Id = 3, Name = "лишения адвоката права заниматься адвокатской деятельностью"},
                new Models.GraGGUPExclusionBasement {Id = 4, Name = "смерти адвоката"}
            );
        }
    }
    
    // •	;
    // •	;
    // •	;
    // •	.
}