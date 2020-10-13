using System.ComponentModel.DataAnnotations;
using GRA.Data.Base;
using GRA.Data;
using Microsoft.EntityFrameworkCore;

namespace GRA.Models
{
    public class GraGGUPSuspensionBasement : BaseModel, IFillData
    {
        [Display(Name = "Основание приостановления")]
        public string Name { get; set; }

        public void FillData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GraGGUPSuspensionBasement>().HasData(
                new Models.GraGGUPSuspensionBasement {Id = 1, Name = "подачи заявления адвокатом"},
                new Models.GraGGUPSuspensionBasement {Id = 2, Name = "наличия досудебного производства в отношении адвоката"}
            );
        }
    }

    // •	подачи заявления адвокатом;
    // •	наличия досудебного производства в отношении адвоката.
}