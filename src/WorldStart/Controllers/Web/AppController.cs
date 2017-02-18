namespace WorldStart.Controllers.Web
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Services;
    using ViewModels;

    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IConfigurationRoot _configuration;

        public AppController(IMailService mailService, IConfigurationRoot configuration)
        {
            _mailService = mailService;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (model.Email.Contains("aol.com"))
                ModelState.AddModelError("", "Nop, not good. Cya"); // Adds general errors to model, first param specific prop.

            if (ModelState.IsValid)
            {
                _mailService.SendMail(_configuration["MailSettings:ToAddress"], model.Email, model.Name, model.Message);

                ViewBag.UserMessage = "Message Sent";
                ModelState.Clear();
            }
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
