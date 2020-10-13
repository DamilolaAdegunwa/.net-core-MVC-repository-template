using System.ComponentModel.DataAnnotations;
using GRA.Data.Base;
using GRA.Data;
using Microsoft.EntityFrameworkCore;

namespace GRA.Models
{
    public class GraLicenseBasement : BaseModel, IFillData
    {
        [Display(Name = "Основания выдачи лицензии")]
        public string Name { get; set; }

        public void FillData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GraLicenseBasement>().HasData(
                new Models.GraLicenseBasement {Id = 1, Name = "без экзамена"},
                new Models.GraLicenseBasement {Id = 2, Name = "через квалификационный экзамен"}
            );
        }
    }
}