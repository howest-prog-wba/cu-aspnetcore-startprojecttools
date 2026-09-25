using Microsoft.AspNetCore.Mvc;

namespace CoreCourse.StarterProject.Web.Areas.Public.Controllers
{
    [Area("Public")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
