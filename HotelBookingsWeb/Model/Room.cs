using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelBookingsWeb.Model
{
    public class Room
    {
        public Room()
        {
            this.Bookings = new HashSet<Reservation>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Number { get; set; }
        public string Size { get; set; }
        public Nullable<double> PricePerNight { get; set; }

        public virtual ICollection<Reservation> Bookings { get; set; }
    }
}