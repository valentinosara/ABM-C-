using System;
using System.Collections.Generic;

namespace ABM_ValentinoSara.Models
{
    public partial class Tour
    {
        public Tour()
        {
            Bookings = new HashSet<Booking>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Precio { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
