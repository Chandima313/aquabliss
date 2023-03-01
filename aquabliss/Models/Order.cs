using System.ComponentModel.DataAnnotations;

namespace aquabliss
{
    public class Order
    {
        [Key]
        public string Order_ID { get; set; }
        public string Order_Date { get; set; }
        public string Total_Price { get; set; }
    }
}
