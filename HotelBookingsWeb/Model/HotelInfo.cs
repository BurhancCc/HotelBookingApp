using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelBookingsWeb.Model
{
    public class HotelInfo
    {
        public HotelInfo()
        {
            this.Bookings = new HashSet<Reservation>();
            this.Extras = new HashSet<Extra>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string City { get; set; }
        public Nullable<int> NumberOfRooms { get; set; }

        public virtual ICollection<Reservation> Bookings { get; set; }

        public virtual ICollection<Extra> Extras { get; set; }
    }
}