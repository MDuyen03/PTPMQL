using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
     [Table("Employees")]
public class Employee : Person
{
    [Key]
    public string EmployeeId { get; set;}
    public int Age { get; set;}
}
}