using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
     [Table("DaiLy")]
public class Daily : HeThongPhanPhoi
{
    [Key]
    public string MaHTPP {get; set;}
    public string MaDaiLy{ get; set;}
    public string TenDaiLy { get; set;}
    public string DiaChi { get; set;}
    public string NguoiDaiDien { get;}
    public string DienThoai { get;}
}
}