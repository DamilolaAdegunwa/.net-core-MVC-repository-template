using System;
using System.ComponentModel.DataAnnotations;


namespace GRA.Common.Validation
{
    public class DateRangeAttribute : RangeAttribute
    {
        public DateRangeAttribute()
            : base(typeof(DateTime), DateTime.Now.AddYears(-100).ToShortDateString(), DateTime.Now.AddYears(100).ToShortDateString())
        {
            ErrorMessage = "Введите корректную дату";
        } 
    }
}