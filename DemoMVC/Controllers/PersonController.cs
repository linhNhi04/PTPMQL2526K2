using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
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
            ViewBag.Message = ip.FullName + "-" + ip.age;
            return View();
        }
    }
}