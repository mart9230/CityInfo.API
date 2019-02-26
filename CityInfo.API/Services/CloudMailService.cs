using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    // dummy service to simulate sending emails.
    public class CloudMailService : IMailService
    {
        private string mailTo = Startup.Configuration["MailSettings:mailToAddress"];
        private string mailFrom = Startup.Configuration["MailSettings:mailFromAddress"];

        public void Send(string subject, string message)
        {
            Debug.WriteLine($"Mail from {mailFrom} to {mailTo} using CloudMailService");
            Debug.WriteLine($"Subject {subject}");
            Debug.WriteLine($"Subject {message}");
        }
    }
}
