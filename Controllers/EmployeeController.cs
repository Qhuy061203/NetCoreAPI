using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace haquanghuy1.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }
    }
}
