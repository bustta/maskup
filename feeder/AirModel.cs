namespace feeder
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AirModel : DbContext
    {
        public AirModel()
            : base("name=AirModel4Feeder")
        {
        }

        public virtual DbSet<AirCondiction> AirCondiction { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
