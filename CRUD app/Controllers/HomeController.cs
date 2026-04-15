using System.Diagnostics;
using CRUD_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_app.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDBContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDBContext context)
        {
            _logger = logger;

            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
