using System.Diagnostics;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCTestApp.Models;

namespace MVCTestApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            SubjectModel model = new SubjectModel();
            model.SubjectList.Add(new SelectListItem { Text = "Physics", Value = "1" });
            model.SubjectList.Add(new SelectListItem { Text = "Chemistry", Value = "2" });
            model.SubjectList.Add(new SelectListItem { Text = "Mathematics", Value = "3" });
            //model.SelectedSubject = new SelectList(model.SubjectList, "Value", "Text", model.SelectedSubject);
            return View(model);
        }

        public ActionResult MyButtonClicked()
        {
            // Perform server-side action here
            ViewBag.Message = "Button clicked on the server side";
            return View("Index"); // Assuming "Index" is the name of your View
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