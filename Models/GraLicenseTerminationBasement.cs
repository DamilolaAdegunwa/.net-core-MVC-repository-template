using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;
using DocumentFormat.OpenXml.Wordprocessing;
using GRA.Data.Base;
using GRA.Data;
using Microsoft.EntityFrameworkCore;

namespace GRA.Models
{
    public class GraLicenseTerminationBasement : BaseModel , IFillData
    {
        [Display(Name = "Основание прекращения действия лицензии")]
        public string Name { get; set; }

        public void FillData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GraLicenseTerminationBasement>().HasData(
                new Models.GraLicenseTerminationBasement {Id = 1, Name = "утрата адвокатом гражданства Кыргызской Республики"},
                new Models.GraLicenseTerminationBasement {Id = 2, Name = "смерть адвоката или вступления в законную силу решения суда об объявлении его безвестно отсутствующим или умершим"},
                new Models.GraLicenseTerminationBasement {Id = 3, Name = "признание в установленном порядке адвоката недееспособным либо ограниченно дееспособным"},
                new Models.GraLicenseTerminationBasement {Id = 4, Name = "личное заявление адвоката, поданное в письменной форме"},
                new Models.GraLicenseTerminationBasement {Id = 5, Name = "неполучение лицензии в течение одного месяца по неуважительным причинам"},
                new Models.GraLicenseTerminationBasement {Id = 6, Name = "невступление адвоката в члены Адвокатуры в течение одного месяца со дня получения лицензии"}
                );
        }
    }
}