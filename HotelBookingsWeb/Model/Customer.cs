using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingsWeb.Model
{
    public class Customer
    {
        public Customer()
        {
            this.Bookings = new HashSet<Reservation>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Reservation> Bookings { get; set; }
    }
}