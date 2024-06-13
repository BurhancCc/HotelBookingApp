using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelBookingsWeb.Model
{
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Nullable<int> RoomId { get; set; }
        public Nullable<int> PropertyId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<int> BookingDays { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<double> TotalCharges { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }

        public virtual Property Property { get; set; }
        public virtual Room Room { get; set; }
        public virtual Customer Customer { get; set; }
    }
}