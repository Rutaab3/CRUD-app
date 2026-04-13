using CRUD_app.Models;
using Microsoft.AspNetCore.Mvc;
namespace CRUD_app.Controllers
{
    public class TeacherController : Controller
    {
        // _context is our connection to the database:
        private readonly ApplicationDBContext _context;

        // We are making constructor
        public TeacherController(ApplicationDBContext context)
        {
            // Save the database connection into _context variable
            _context = context;
        }

        // This method runs when someone visit: /Student/Index
        public IActionResult Index()
        {
            //Get All students from the database
            // Students = table data from the DbContext
            //ToList() = convert data into a list(collection)
            var Teacher = _context.Teacher.ToList();

            return View(Teacher);
        }

    }
}