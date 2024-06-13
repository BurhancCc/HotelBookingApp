using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace HotelBookingsWeb.Model
{
    public partial class Property
    {
        public Property()
        {
            this.Bookings = new HashSet<Reservation>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string PropertyName { get; set; }
        public string Location { get; set; }
        public string PropertyType { get; set; }
        public Nullable<int> RoomsCount { get; set; }

        public Nullable<int> LandlordId { get; set; }
        public virtual Landlord Landlord { get; set; }

        public virtual ICollection<Reservation> Bookings { get; set; }
    }
}