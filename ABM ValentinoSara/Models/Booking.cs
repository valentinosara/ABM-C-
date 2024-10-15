using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ABM_ValentinoSara.Models
{
    public partial class Booking
    {
        public int Id { get; set; }
        public int? TourId { get; set; }
        [Display(Name = "Cliente")]
        public string? NombreCliente { get; set; }

        public virtual Tour? Tour { get; set; }
    }
}
