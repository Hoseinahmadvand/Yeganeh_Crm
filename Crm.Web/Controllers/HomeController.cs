using Microsoft.AspNetCore.Mvc;

namespace Crm.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
