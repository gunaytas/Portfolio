using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
