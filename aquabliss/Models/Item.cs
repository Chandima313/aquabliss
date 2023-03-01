using System.ComponentModel.DataAnnotations;

namespace aquabliss
{
    public class Item
    {
        [Key]
        public string Item_ID { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
    }
}
