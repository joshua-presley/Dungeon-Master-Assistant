using System;
namespace Model.Interfaces.DatabaseAccess
{
	public interface IBaseRepository<T> where T: class
	{
		IQueryable<T> QueryDB();
	}
}

