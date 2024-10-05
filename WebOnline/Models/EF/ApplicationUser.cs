using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebOnline.Models.EF
{
    [Table("tb_TaiKhoan")] 
    public class ApplicationUser : IdentityUser 
    {
        public string FullName {  get; set; }
        public ICollection<Oders> orders { get; set; }
    }
}
