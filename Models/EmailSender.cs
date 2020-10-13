using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GRA.Models
{
    public class EmailSender 
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.CompletedTask;
        }
    }
}
