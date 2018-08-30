namespace SA.GA.DataAccess.Context.Implementation
{
    #region Usings
    using Microsoft.EntityFrameworkCore;
    using SA.GA.Common.Models;
    #endregion
    public class AppContext2 : DbContext
    {
        public AppContext2(DbContextOptions<AppContext2> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder
                .Entity<History>()
                .HasOne<User>(e => e.User)
                .WithMany(e => e.Historys)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Plot> Plots { get; set; }

        public DbSet<History> Historys { get; set; }

        public DbSet<Electricity> Electricitys { get; set; }

        public DbSet<Rate> Rates { get; set; }
    }
}