using System.ComponentModel.DataAnnotations;

namespace Gulf_Logistics.Models
{
    public class User
    {
        public string Email { get; set; }

        public string Password { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string ClientId { get; set; }
    }
}
