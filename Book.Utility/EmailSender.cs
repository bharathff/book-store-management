using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace Book.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Your email sending logic goes here
            // For simplicity, returning a completed task
            return Task.CompletedTask;
        }
    }
}
