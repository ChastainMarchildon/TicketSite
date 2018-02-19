namespace TicketSite.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShowsModel : DbContext
    {
        public ShowsModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Venue> Venues { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
