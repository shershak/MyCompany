using System;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace MyCompany.Service
{
    public class Mail
    {
        public static async Task Send(string subjectText, string mailTo, string text)
        {
            var apiKey = Environment.GetEnvironmentVariable("ApiKey");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("shershak@i.ua", "MyCompany");
            var to = new EmailAddress(mailTo);
            var htmlContent = $"{text}";
            var msg = MailHelper.CreateSingleEmail(from, to, subjectText, text, htmlContent);
            await client.SendEmailAsync(msg);
        }
    }
}
