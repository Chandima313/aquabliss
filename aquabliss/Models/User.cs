using System.ComponentModel.DataAnnotations;

namespace aquabliss
{
    public class User
    {
        [Key]
        public string User_ID { get; set; }
        public string Username { get; set;}
        public string Email { get; set;}
        public string Password { get; set;}
    }
}
