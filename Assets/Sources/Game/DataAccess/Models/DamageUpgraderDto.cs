using Newtonsoft.Json;

namespace Game.Sources.Game.DataAccess.Models
{
    public class DamageUpgraderDto
    {
        [JsonRequired]
        public string Type { get; } = "DamageUpgrader";
        [JsonRequired]
        public int Damage { get; set; }
    }
}