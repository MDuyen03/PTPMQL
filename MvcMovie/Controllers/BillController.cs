using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    public class BillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Bill bill)
        {
            if (bill.Quantity < 0 || bill.UnitPrice < 0)
            {
                @ViewBag.Message = "Số lượng và đơn giá phải lớn hơn hoặc bằng 0.";
            }
            else
            {
                double billResult = (bill.Quantity * bill.UnitPrice);
                string strOutput = "Tổng tiền: " + billResult;
                 ViewBag.infoBill = strOutput;
                 ViewBag.Message = "Sản phẩm: " + bill.ProduceName;
            }
            return View(bill);
        }
        
    }
}