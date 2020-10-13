using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRA.Data.Base;

namespace GRA.Models
{
    public class PageViewModel: BaseModel
    {
        public int PageNumber { get; private set; }
        public int TotalPages { get; private set; }

        public PageViewModel(int count, int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageNumber > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageNumber < TotalPages);
            }
        }
    }
    public class MyUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }

    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<MyUser> Users { get; set; }
        public Company()
        {
            Users = new List<MyUser>();
        }
    }
    public class FilterViewModel
    {
        public FilterViewModel(string name)
        {
            // устанавливаем начальный элемент, который позволит выбрать всех
            SelectedName = name;
        }
        public string SelectedName { get; private set; }    // введенное имя
    }
    public enum SortState
    {
        NameAsc,    // по имени по возрастанию
        NameDesc,   // по имени по убыванию
        AgeAsc, // по возрасту по возрастанию
        AgeDesc,    // по возрасту по убыванию
        CompanyAsc, // по компании по возрастанию
        CompanyDesc, // по компании по убыванию
        RegisterNumberAsc, // по номеру реестра по возрастанию
        RegisterNumberDesc // по номеру реестра по убыванию
    }
    public class SortViewModel
    {
        public SortState NameSort { get; private set; } // значение для сортировки по имени
        public SortState AgeSort { get; private set; }    // значение для сортировки по возрасту
        public SortState CompanySort { get; private set; }
        public SortState RegisterNumber { get; private set; }   // значение для сортировки по компании
        public SortState Current { get; private set; }     // текущее значение сортировки

        public SortViewModel(SortState sortOrder)
        {
            NameSort = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
            AgeSort = sortOrder == SortState.AgeAsc ? SortState.AgeDesc : SortState.AgeAsc;
            CompanySort = sortOrder == SortState.CompanyAsc ? SortState.CompanyDesc : SortState.CompanyAsc;
            RegisterNumber = sortOrder == SortState.RegisterNumberAsc ? SortState.RegisterNumberDesc : SortState.RegisterNumberAsc;
            Current = sortOrder;
        }
    }
    public class IndexViewModel
    {
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
        public SortViewModel SortViewModel { get; set; }
        public int CountTotal { get; set; }
    }
}
