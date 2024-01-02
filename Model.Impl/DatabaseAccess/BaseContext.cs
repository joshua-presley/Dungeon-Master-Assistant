using Microsoft.EntityFrameworkCore;

namespace Model.Impl
{
	public class BaseContext : DbContext
	{
		public DbSet<Character> Characters { get; set; }
		public DbSet<Location> Locations { get; set; }

		public string DbPath { get; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Location>()
				.HasMany(l => l.SubLocs)
				.WithOne(l => (Location)l.ParentLocation)
				.HasForeignKey(l => l.ParentId)
				.HasPrincipalKey(l => l.Id);

			modelBuilder.Entity<Location>()
				.HasMany(l => l.Characters)
				.WithOne(l => (Location)l.CharacterLocation)
				.HasForeignKey(c => c.LocationId)
				.HasPrincipalKey(c => c.Id);
        }

        public BaseContext()
		{
			DbPath = "..\\Database\\MainDb.Db";
		}
	}

}

