using Microsoft.AspNetCore.Mvc;

namespace DevDotNet.Controllers
{
    public class ProjectController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Facckup()
        {
            return View();
        }
    }
}