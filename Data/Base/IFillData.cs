using Microsoft.EntityFrameworkCore;

namespace GRA.Data.Base
{
    public interface IFillData
    {
        void FillData(ModelBuilder modelBuilder);
    }

    // public interface IFillData<T> where T : class, IDict, new()
    // {
    //     void FillData(ModelBuilder modelBuilder, string[] names)
    //     {
    //         for (int i = 0; i < names.Length; i++)
    //         {
    //             modelBuilder.Entity<T>().HasData(new T() {Id = i, Name = names[i]});
    //         }
    //     }
    // }
}