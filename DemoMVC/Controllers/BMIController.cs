using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
using System.Diagnostics;
namespace DemoMVC.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            @ViewBag.Message = "Calculate your BMI";

            return View();
        }

        [HttpPost]
        public IActionResult Index(BMI bmi)
        {
            bmi.chisoBMI = bmi.cannang / (bmi.chieucao * bmi.chieucao);
            if (bmi.chisoBMI < 18.5)
            {
                bmi.ketqua = "Underweight";
            }
            else if (bmi.chisoBMI < 24.9)
            {
                bmi.ketqua = "Normal weight";
            }
            else if (bmi.chisoBMI < 29.9)
            {
                bmi.ketqua = "Overweight";
            }
            else
            {
                bmi.ketqua = "Obesity";
            }
            ViewBag.Message = "Your BMI is: " + bmi.chisoBMI + " (" + bmi.ketqua + ")";
            return View();
        }
    }
}
    