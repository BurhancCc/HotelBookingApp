using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelBookingsWeb.Model
{
    public partial class Landlord
    {
        public Landlord()
        {
            this.Properties = new HashSet<Property>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}