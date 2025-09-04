using Microsoft.AspNetCore.Mvc;
using buoi3.Models;

namespace buoi3.Controllers
{
    public class ToanController : Controller
    {
         [HttpGet]
         public IActionResult Index()
         {
             ViewBag.Message = "Dữ liệu từ controller gửi về view sử dụng ViewBag ";
             return View();
         }
         [HttpPost]
        public IActionResult Index(Toan tt)
        {
            switch (tt.phepToan)
            {
                case "+":
                    tt.Ketqua = tt.so1 + tt.so2;
                    break;
                case "-":
                    tt.Ketqua = tt.so1 - tt.so2;
                    break;
                case "*":
                    tt.Ketqua = tt.so1 * tt.so2;
                    break;
                case "/":
                    if(tt.so2 != 0 )
                        tt.Ketqua = tt.so1 / tt.so2;
                    else 
                        ViewBag.Message = "Không thể chia cho 0";
                    break;

            }
            ViewBag.Message = " Kết quả:" + tt.Ketqua;
            return View();

        }
    }
}