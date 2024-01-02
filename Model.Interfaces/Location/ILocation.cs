namespace Model.Interfaces
{
	public interface ILocation
	{
		Guid Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        Guid ParentId { get; set; }
        ILocation ParentLocation { get; set; }
        List<ICharacter> CharactersInLocation { get; }
        List<ILocation> SubLocations { get; }
    }
}

