using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            
            ViewBag.Name = "Dao Xuan Thanh";

            
            ViewData["Age"] = 20;

            
            ViewBag.Major = "CNTT";

            return View();
        }
    }
}