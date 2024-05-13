using System.ComponentModel.DataAnnotations.Schema;

namespace WebOnline.Models.EF
{
    [Table("tb_ChiTietDatHang")]
    public class OderDetails : CMAbstract
    {
        public int Id { get; set; }
        public int ProductID { get; set; }
        public int OrdersID { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set;}
    }
}
