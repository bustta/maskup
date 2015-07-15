namespace maskup.repository
{
    using System.Data.Entity;
    using maskup.domain;

    public partial class AirDbModel : DbContext
    {
        public AirDbModel()
            : base("name=AirDbModel")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AirCondiction> AirCondictions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
