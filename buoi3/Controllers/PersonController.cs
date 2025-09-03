using Microsoft.AspNetCore.Mvc;
using Buoi3.Models;

namespace buoi3.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Message = "Dữ liệu từ controller gửi về view sử dụng ViewBag ";
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ip)
        {
            ViewBag.Message = ip.FullName + "-" + ip.Age;
            return View();
        }
    }
}