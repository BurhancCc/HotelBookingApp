using System;

namespace HotelBookingsWeb.Model
{
    public partial class Extra
    {
        public int Id { get; set; }
        public string ExtraDescription { get; set; }
        public Nullable<int> HotelId { get; set; }

        public virtual HotelInfo HotelInfo { get; set; }
    }
}