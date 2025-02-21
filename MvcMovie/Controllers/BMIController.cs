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
        double bmiResult = (bmi.Weight/(bmi.Height * bmi.Height));
        string strOutput = "Chỉ số BMI của bạn là: " + bmiResult;
        ViewBag.infoBMI = strOutput;
        if ( bmi.Weight <=0 || bmi.Height <=0)
        {
            @ViewBag.BMIResult = "Nhập giá trị lớn hơn!";
        }
        else {
            if (bmiResult < 18.5){
                @ViewBag.BMIResult = strOutput + " Gầy";
            }
            else if (bmiResult >= 18.5 && bmiResult < 24.9){
                @ViewBag.BMIResult = strOutput + " Bình thường"; 
            }
            else if (bmiResult >= 25 && bmiResult < 29.9){
                @ViewBag.BMIResult = strOutput + " Thừa cân";
            }
            else
            @ViewBag.BMIResult = " Béo phì";
            @ViewBag.Message = "Vui lòng nhập cân nặng và chiều cao hợp lệ!";
        }
        return View();
    }
    }
}