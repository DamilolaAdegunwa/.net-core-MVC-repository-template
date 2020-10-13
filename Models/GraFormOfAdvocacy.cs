using GRA.Data.Base;
using GRA.Data;
using Microsoft.EntityFrameworkCore;

namespace GRA.Models
{
    public class GraFormOfAdvocacy : BaseModel, IFillData
    {
        public string Name { get; set; }
        public void FillData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GraFormOfAdvocacy>().HasData(
                new Models.GraFormOfAdvocacy {Id = 1, Name = "адвокатский кабинет"},
                new Models.GraFormOfAdvocacy {Id = 2, Name = "коллегия адвокатов"},
                new Models.GraFormOfAdvocacy {Id = 3, Name = "адвокатское бюро"}
            );
        }
    }

    // адвокатский кабинет,
    // коллегия адвокатов,
    // адвокатское бюро
}