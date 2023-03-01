using System.ComponentModel.DataAnnotations;

namespace aquabliss
{
    public class Product
    {
        [Key]
        public string Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Category { get; set;}
    }
}
