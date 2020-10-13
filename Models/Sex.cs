using System.ComponentModel.DataAnnotations;
using GRA.Data.Base;
using GRA.Data;
using Microsoft.EntityFrameworkCore;

namespace GRA.Models
{
    public class Sex : BaseModel, IFillData
    {
        [Display(Name = "Пол", AutoGenerateField = true, AutoGenerateFilter = true)]
        public string Name { get; set; }

        public void FillData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sex>().HasData(
                new Models.Sex {Id = 1, Name = "Мужчина"},
                new Models.Sex {Id = 2, Name = "Женщина"}
            );
        }
    }
}