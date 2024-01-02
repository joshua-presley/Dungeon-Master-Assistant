using Model.Interfaces;
namespace Model.Impl
{
	public class LocationRepository: BaseRepository<Location>, ILocationRepository
	{
		public LocationRepository(BaseContext context): base(context) { }
	}
}

