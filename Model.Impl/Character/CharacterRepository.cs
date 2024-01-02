using Model.Interfaces;
namespace Model.Impl
{
	public class CharacterRepository: BaseRepository<Character>, ICharacterRepository
	{
		public CharacterRepository(BaseContext context): base(context) { }
	}
}

