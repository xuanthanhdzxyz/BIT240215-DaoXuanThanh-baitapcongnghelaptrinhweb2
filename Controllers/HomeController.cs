using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return Content("Dao Xuan Thanh");
        }

        public IActionResult Contact()
        {
            return Content("xuanthanh@gmail.com");
        }
    }
}