using Microsoft.AspNetCore.Mvc;

namespace project.Controllers
{
    public class DetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
