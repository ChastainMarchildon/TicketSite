namespace TicketSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Venue
    {
        [Column("Venue Name")]
        [StringLength(50)]
        public string Venue_Name { get; set; }

        [Column("Venue Location")]
        public string Venue_Location { get; set; }

        public int? Tickets { get; set; }

        public int VenueID { get; set; }

        [Column("Artist Name")]
        [StringLength(50)]
        public string Artist_Name { get; set; }
    }
}
