using Model.Interfaces;
namespace Model.Impl
{

	/// <summary>
	/// base representation of a location in the game
	/// could be a large region, city, town, dungeon, etc
	/// </summary>
	public class Location : ILocation
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public Guid ParentId { get; set; }
		public ILocation ParentLocation { get; set; }

		public List<Character> Characters { get; set; }
		public List<Location> SubLocs { get; set; }

		public List<ICharacter> CharactersInLocation => Characters.Select(c => (ICharacter)c).ToList();
		public List<ILocation> SubLocations => SubLocs.Select(l => (ILocation)l).ToList();
	}
}

