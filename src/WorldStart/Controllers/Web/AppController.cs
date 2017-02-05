namespace WorldStart.Controllers.Web
{
    using Microsoft.AspNetCore.Mvc;
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
