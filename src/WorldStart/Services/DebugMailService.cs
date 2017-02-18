namespace WorldStart.Services
{
    using System;
    using System.Diagnostics;

    public class DebugMailService : IMailService
    {
        public void SendMail(string to, string from, string subject, string body)
        {
            Debug.WriteLine($"{to}, {from}, {subject}");
        }
    }
}
