using DndCharacterSheepPWA.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DndCharacterSheepPWA.Client.Services.Interfaces;
using DndCharacterSheepPWA.Client.Services;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7080") });
builder.Services.AddScoped<ICharacterSelection, CharacterSelectionService>();
builder.Services.AddScoped<ICharacterSheet, CharacterSheetService>();

await builder.Build().RunAsync();
