using System;
namespace Model.Interfaces
{
	public interface IBaseRepository<T> where T: class
	{
		IQueryable<T> QueryDB();
	}
}

