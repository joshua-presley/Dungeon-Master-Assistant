using Microsoft.EntityFrameworkCore;
namespace Model.Impl
{
	public class BaseRepository<T>: DbContext where T: class
	{
		public DbSet<T> Items { get; set; }

		public IQueryable<T> QueryDB() 
		{
			return Items.AsQueryable<T>();
		}

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={m_dbSource}");

		private const string m_dbSource = "..\\Database\\mainDb.db";
    }
}

