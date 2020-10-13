using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;
using DocumentFormat.OpenXml.Wordprocessing;
using GRA.Data.Base;
using GRA.Data;
using Microsoft.EntityFrameworkCore;

namespace GRA.Models
{
    public class GraLicenseWithdrawalBasement : BaseModel , IFillData
    {
        [Display(Name = "Основание лишения лицензии")]
        public string Name { get; set; }

        public void FillData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GraLicenseWithdrawalBasement>().HasData(
                new Models.GraLicenseWithdrawalBasement {Id = 1, Name = "вступление в законную силу обвинительного приговора суда в отношении адвоката"},
                new Models.GraLicenseWithdrawalBasement {Id = 2, Name = "повторное нарушение норм Кодекса профессиональной этики адвоката"},
                new Models.GraLicenseWithdrawalBasement {Id = 3, Name = "не повышение квалификации в соответствии с нормами Закона «Об Адвокатуре Кыргызской Республики и адвокатской деятельности» либо уставом Адвокатуры"},
                new Models.GraLicenseWithdrawalBasement {Id = 4, Name = "нарушение адвокатом норм Закона «Об Адвокатуре Кыргызской Республики и адвокатской деятельности»"}
            );
        }
    }
    
    // •	;
    // •	;
    // •	;
    // •	.
}