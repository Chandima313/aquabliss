using System.ComponentModel.DataAnnotations;

namespace aquabliss
{
    public class LogIn
    {
        [Key]
        public string Login_ID { get; set; }
        public string Login_Time { get; set; }
    }
}
