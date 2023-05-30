using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class MyAccountsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
