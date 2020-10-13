using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;
using DocumentFormat.OpenXml.Wordprocessing;
using GRA.Data.Base;
using GRA.Data;
using Microsoft.EntityFrameworkCore;

namespace GRA.Models
{
    public class GraLicenseStopBasement : BaseModel, IFillData
    {
        [Display(Name = "Основание приостановления лицензии")]
        public string Name { get; set; }

        public void FillData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GraLicenseStopBasement>().HasData(
                new Models.GraLicenseStopBasement {Id = 1, Name = "поступление адвоката на государственную или муниципальную службу (за исключением депутатов местных кенешей)"},
                new Models.GraLicenseStopBasement {Id = 2, Name = "нахождение адвоката на срочной действительной военной службе"},
                new Models.GraLicenseStopBasement {Id = 3, Name = "заявление адвоката"},
                new Models.GraLicenseStopBasement {Id = 4, Name = "нарушение адвокатом норм Кодекса профессиональной этики адвокатов"},
                new Models.GraLicenseStopBasement {Id = 5, Name = "неуплата членских взносов в сроки, установленные уставом Адвокатуры"}
            );
        }
    }
    
    // •	поступление адвоката на государственную или муниципальную службу (за исключением депутатов местных кенешей);
    // •	нахождение адвоката на срочной действительной военной службе;
    // •	заявление адвоката;
    // •	нарушение адвокатом норм Кодекса профессиональной этики адвокатов;
    // •	неуплата членских взносов в сроки, установленные уставом Адвокатуры.
}