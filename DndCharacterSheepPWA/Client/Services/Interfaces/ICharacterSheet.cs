using DndCharacterSheepPWA.Shared;

namespace DndCharacterSheepPWA.Client.Services.Interfaces
{
    public interface ICharacterSheet
    {
        List<CharacterModel> Characters { get; set; }
        Task GetCharacterList();
        Task PostCharacter(CharacterModel character);
        Task UpdateCharcater();
    }
}
