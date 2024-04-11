using Newtonsoft.Json;

namespace Game.Sources.Game.DataAccess.Models
{
    public class RangeUpgraderDto
    {
        [JsonRequired]
        public string Type { get; } = "RangeUpgrader";
        [JsonRequired]
        public int Range { get; set; }
    }
}