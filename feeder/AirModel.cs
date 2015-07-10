namespace feeder
{
    using feeder.Binding;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public partial class AirModel : DbContext
    {
        public AirModel()
            : base("name=AirModel")
        {
        }

        public virtual DbSet<AirCondiction> AirCondiction { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}