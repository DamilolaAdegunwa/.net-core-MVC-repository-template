using System.ComponentModel.DataAnnotations;
using GRA.Data.Base;
using GRA.Data;
using Microsoft.EntityFrameworkCore;

namespace GRA.Models
{
    public class GraLicenseStatus : BaseModel,IFillData
    {
        [Display(Name = "Статус лицензии")]
        public string Name { get; set; }

        public void FillData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GraLicenseStatus>().HasData(
                new Models.GraLicenseStatus {Id = 1, Name = "действует"},
                new Models.GraLicenseStatus {Id = 2, Name = "приостановлен"},
                new Models.GraLicenseStatus {Id = 3, Name = "лишен"},
                new Models.GraLicenseStatus {Id = 4, Name = "прекращен"}
            );
        }
    }

    //действует,
    //приостановлен,
    //лишен,
    //прекращен.
}