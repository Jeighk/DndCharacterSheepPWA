using DndCharacterSheepPWA.Client.Services.Interfaces;
using DndCharacterSheepPWA.Shared;
using System.Net;
using System.Net.Http.Json;

namespace DndCharacterSheepPWA.Client.Services
{
    public class CharacterSelectionService : ICharacterSelection
    {
        private readonly HttpClient _httpClient;
        public CharacterSelectionService(HttpClient http)
        {
            _httpClient = http;
        }
        public List<CharacterModel> Characters { get; set; } = new List<CharacterModel>();

        public async Task GetCharacterList()
        {
            var result = await _httpClient.GetFromJsonAsync< List < CharacterModel >> ("api/character");
            Characters = result;
        }
    }
}
