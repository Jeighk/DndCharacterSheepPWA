using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterSheepPWA.Shared
{
    public class CharacterModel
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public int MaxHitPoints { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constituion { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Alignment { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public string Race { get; set; } = string.Empty;
        public string Background { get; set; } = string.Empty;
        public decimal Gold { get; set; }
        public int Speed { get; set; }
    }
}
