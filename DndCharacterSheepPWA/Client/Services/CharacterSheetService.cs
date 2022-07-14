using DndCharacterSheepPWA.Client.Services.Interfaces;
using DndCharacterSheepPWA.Shared;
using System.Net;
using System.Net.Http.Json;

namespace DndCharacterSheepPWA.Client.Services
{
    public class CharacterSheetService : ICharacterSheet
    {
       private readonly HttpClient _httpClient;
        public CharacterSheetService(HttpClient http)
        {
            _httpClient = http;
        }

        public List<CharacterModel> Characters { get; set; }

        public async Task GetCharacterList()
        {
            var result = await _httpClient.GetFromJsonAsync< List < CharacterModel >> ("api/character");
            Characters = result;        
        }

        public async Task PostCharacter(CharacterModel character)
        {
            var result = await _httpClient.PostAsJsonAsync("api/character", character);
            CharacterModel whatever = await result.Content.ReadFromJsonAsync<CharacterModel>();
        }

        public Task UpdateCharcater()
        {
            throw new NotImplementedException();
        }
    }
}
