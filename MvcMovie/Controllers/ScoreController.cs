using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    public class ScoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Score score)
        {
            double ScoreResult = (score.ScoreA * 0.6 + score.ScoreB * 0.3 + score.ScoreC * 0.1);
            string strOutput = "Điểm của bạn là: " + ScoreResult ;
            ViewBag.infoScore = strOutput;
            if ( score.ScoreA > 10 || score.ScoreB > 10 || ScoreResult > 10 )
                    @ViewBag.infoScore = "Điểm vượt quá quy định, vui lòng nhập lại";
                else if(ScoreResult >= 9)
                    @ViewBag.ScoreResult = "Thang điểm A+";
                else if (ScoreResult >= 8.5 && ScoreResult <= 8.9)
                    ViewBag.ScoreResult = "Thang điểm A";
                else if (ScoreResult >= 7.0 && ScoreResult <= 8.4)
                    @ViewBag.ScoreResult = "Thang điểm B";
                else if (ScoreResult >= 5.5 && ScoreResult <= 6.9)
                    @ViewBag.ScoreResult = "Thang điểm C";
                else if (ScoreResult >= 4.0 && ScoreResult <= 5.4)
                    @ViewBag.ScoreResult = "Thang điểm D";
                else
                    @ViewBag.ScoreResult = "F";
                    return View(score);

        }
    }
}