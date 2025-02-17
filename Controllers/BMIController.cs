using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;

namespace YourNamespace.Controllers
{
    public class BMIController : Controller
    {
        // GET: BMI/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: BMI/Index
        [HttpPost]
        public IActionResult Index(BMIModel model)
        {
            if (ModelState.IsValid) // Kiểm tra dữ liệu đầu vào
            {
                // Tính toán BMI và phân loại BMI
                ViewBag.BMI = model.BMI;
                ViewBag.Category = model.BMICategory();
            }
            return View(model); // Trả lại View với các dữ liệu tính toán
        }
    }
}
