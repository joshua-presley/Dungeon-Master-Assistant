using Model.Interfaces;
namespace Model.Impl.Location
{
	/// <summary>
	/// base representation of a location in the game
	/// could be a large region, city, town, dungeon, etc
	/// </summary>
	public class Location: ILocation
	{
        public virtual Guid Id { get; set; }
		public virtual string Name { get; set; }
		public virtual string Description { get; set; }
		public virtual List<ICharacter> CharactersInLocation { get; set; }
		public virtual List<ILocation> SubLocations { get; set; }
	}
}

