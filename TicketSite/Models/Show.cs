using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Web;

namespace TicketSite.Models
{
    public class Show
    {
        [Column("Venue Name")]
        [StringLength(50)]
        public string Venue_Name { get; set; }

        public int? Tickets { get; set; }

        public int ShowID { get; set; }

        [Column("Artist Name")]
        [StringLength(50)]
        public string Artist_Name { get; set; }
    }
}