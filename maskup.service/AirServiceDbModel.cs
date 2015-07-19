namespace maskup.service
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using maskup.domain;

    public partial class AirServiceDbModel : DbContext
    {
        public AirServiceDbModel()
            : base("name=AirServiceDbModel")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AirCondiction> AirCondictions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
