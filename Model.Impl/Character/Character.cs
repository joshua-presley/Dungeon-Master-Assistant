
using Model.Interfaces;
namespace Model.Impl
{
	/// <summary	>
	/// Base representation of any 'being'
	/// in the game, be they an PC, NPC,
	/// Monster, etc.
	/// </summary>
	public class Character: ICharacter
    {
		public virtual Guid Id { get; set; }
		public virtual int Strength { get; set; }
        public virtual int Dexterity { get; set; }
        public virtual int Constitution { get; set; }
        public virtual int Intelligence { get; set; }
        public virtual int Wisdom { get; set; }
        public virtual int Charisma { get; set; }

		public virtual string Name { get; set; }
		/// <summary>
		/// This field is meant to be used as an ongoing 
		/// update, as opposed to background which shouldn't change.
		/// </summary>
		public virtual string Notes { get; set; }
		public virtual string Background { get; set; }

		public virtual string Class { get; set; }
		
		public virtual int MaxHitPoints { get; set; }

		public virtual int Level { get; set; } 
	}
}

