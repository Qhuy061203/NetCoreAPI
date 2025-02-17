using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace haquanghuy1.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}