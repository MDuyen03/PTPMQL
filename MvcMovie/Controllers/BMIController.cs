using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    public class BMIController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(BMI bmi)
    {
        if (bmi.Weight <= 0 || bmi.Hight <= 0)
        {
            @ViewBag.Message = "Vui lòng nhập cân nặng và chiều cao hợp lệ!";
        
        }else{
            float bmiResult = bmi.Weight/(bmi.Hight * bmi.Hight);
            string strOutput = "Chỉ số BMI của bạn là:" + bmiResult;
            ViewBag.infoBMI = strOutput;
        }
        

        return View();
    }
    public IActionResult Creat()
        {
            return View();
        }
    }
}