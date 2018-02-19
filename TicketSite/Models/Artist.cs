namespace TicketSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Artist
    {
        [Column("Artist Name")]
        [StringLength(50)]
        public string Artist_Name { get; set; }

        public int ArtistID { get; set; }
    }
}
