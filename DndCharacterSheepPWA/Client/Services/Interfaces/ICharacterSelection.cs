using DndCharacterSheepPWA.Shared;

namespace DndCharacterSheepPWA.Client.Services.Interfaces
{
    public interface ICharacterSelection
    {
        List<CharacterModel> Characters { get; set; }
        Task GetCharacterList();
    }
}
