using Microsoft.EntityFrameworkCore;
using Model.Interfaces;
namespace Model.Impl
{
	public class BaseRepository<T> : IBaseRepository<T>
		where T : class
	{
		internal BaseContext dbContext;
		internal DbSet<T> Items { get; set; }

		public IQueryable<T> QueryDB()
		{
			return Items.AsQueryable<T>();
		}

		public BaseRepository(BaseContext context)
		{
			this.dbContext = context;
			this.Items = context.Set<T>();
		}
	}
}

