using Microsoft.AspNetCore.Mvc;

namespace NUTRIVIDA.Controllers
{
    public class PlanesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
