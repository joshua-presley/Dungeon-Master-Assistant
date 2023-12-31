namespace Model.Interfaces
{
	public interface ILocation
	{
		Guid Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        List<ICharacter> CharactersInLocation { get; set; }
        List<ILocation> SubLocations { get; set; }
    }
}

