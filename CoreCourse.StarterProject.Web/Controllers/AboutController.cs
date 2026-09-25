using Microsoft.AspNetCore.Mvc;

namespace CoreCourse.StarterProject.Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
