using System.ComponentModel.DataAnnotations;
using GRA.Data.Base;
using GRA.Data;
using Microsoft.EntityFrameworkCore;

namespace GRA.Models
{
    public class GraGGUPSpecialization : BaseModel, IFillData
    {
        [Display(Name = "Специализация адвоката")]
        public string Name { get; set; }
        
        public void FillData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GraGGUPSpecialization>().HasData(
                new Models.GraGGUPSpecialization {Id = 1, Name = "уголовное"},
                new Models.GraGGUPSpecialization {Id = 2, Name = "гражданское"},
                new Models.GraGGUPSpecialization {Id = 3, Name = "административное"}
            );
        }
    }
    // •	уголовное;
    // •	гражданское;
    // •	административное.

}