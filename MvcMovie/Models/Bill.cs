using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models
{
    public class Bill{
    public string ProduceName { get; set; }
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }
    }
}