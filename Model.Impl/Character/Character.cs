
using Model.Interfaces;
namespace Model.Impl
{
	/// <summary>
	/// Base representation of any 'being'
	/// in the game, be they an PC, NPC,
	/// Monster, etc.
	/// </summary>
	public class Character: ICharacter
    {
		public Guid Id { get; set; }
		public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

		public string Name { get; set; }
		/// <summary>
		/// This field is meant to be used as an ongoing 
		/// update, as opposed to background which shouldn't change.
		/// </summary>
		public string Notes { get; set; }
		public string Background { get; set; }

		public string Class { get; set; }
		
		public int MaxHitPoints { get; set; }

		public int Level { get; set; } 

		public Guid LocationId { get; set; }
		public ILocation CharacterLocation { get; set; }

	}
}

