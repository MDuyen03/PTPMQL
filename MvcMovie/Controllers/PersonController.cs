using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    { 
        // GET: /Person/
        public IActionResult Index()
        {
            return View();
        } 
        // GET: /Person/Welcome/ 
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = "Xin chào " + ps.PersonId + "-" + ps.FullName + "-" + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }
        public IActionResult Creat()
        {
            return View();
        }
    }
}
