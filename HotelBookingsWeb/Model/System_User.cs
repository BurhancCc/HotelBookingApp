using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingsWeb.Model
{
    public class System_User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}