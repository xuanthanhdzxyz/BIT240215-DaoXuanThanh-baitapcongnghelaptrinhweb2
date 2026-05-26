using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class ProductController : Controller
    {
  
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return Content("Lỗi: Không có ID sản phẩm!");
            }
            return Content($"Product ID = {id}");
        }

     
        public IActionResult Category(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return Content("Lỗi: Vui lòng nhập tên danh mục (ví dụ: ?name=Laptop)");
            }
            return Content($"Category = {name}");
        }
    }
}