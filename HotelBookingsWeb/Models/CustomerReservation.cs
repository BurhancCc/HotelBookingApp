using System;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions;
using System.Xml.Linq;

namespace HotelBookingsWeb.Models
{
    public class CustomerReservation
    {
        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Select Room")]
        public Nullable<int> RoomId { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Select Property")]
        public Nullable<int> PropertyId { get; set; }
        
        public string Property { get; set; }
        public string Room { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [Date(ErrorMessage = "{0} must be a valid date!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<int> BookingDays { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Total Charges")]
        public Nullable<double> TotalCharges { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [Date(ErrorMessage = "{0} must be a valid date!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "End Date")]
        public Nullable<System.DateTime> EndDate { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Customer Name")]
        public string Customer { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Contact Number")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Provide Email")]
        public string Email { get; set; }
    }
}
