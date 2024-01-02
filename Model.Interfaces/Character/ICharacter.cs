namespace Model.Interfaces
{
	/// <summary>
	/// Base representation of any 'being'
	/// in the game, be they an PC, NPC,
	/// Monster, etc.
	/// </summary>
	public interface ICharacter
	{
         int Strength { get; set; }
         int Dexterity { get; set; }
         int Constitution { get; set; }
         int Intelligence { get; set; }
         int Wisdom { get; set; }
         int Charisma { get; set; }

         string Name { get; set; }
        /// <summary>
        /// This field is meant to be used as an ongoing 
        /// update, as opposed to background which shouldn't change.
        /// </summary>
         string Notes { get; set; }
         string Background { get; set; }

         string Class { get; set; }

         int MaxHitPoints { get; set; }

         int Level { get; set; }

		 Guid LocationId { get; set; }
         ILocation CharacterLocation { get; set; }
    }
}

