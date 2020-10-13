using System.ComponentModel.DataAnnotations;
using GRA.Data.Base;
using GRA.Data;
using Microsoft.EntityFrameworkCore;

namespace GRA.Models
{
    public class GraGGUPHelpForm : BaseModel, IFillData
    {
        [Display(Name = "Форма юридической помощи")]
        public string Name { get; set; }

        public void FillData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GraGGUPHelpForm>().HasData(
                new Models.GraGGUPHelpForm {Id = 1, Name = "консультационно-правовой помощи"},
                new Models.GraGGUPHelpForm {Id = 2, Name = "квалифицированной юридической помощи"}
            );
        }
    }

    // •	консультационно-правовой помощи;
    // •	квалифицированной юридической помощи.
}