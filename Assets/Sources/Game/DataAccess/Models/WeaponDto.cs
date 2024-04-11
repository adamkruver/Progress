using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Game.Sources.Game.DataAccess.Models
{
    public class WeaponDto
    {
        [JsonRequired]
        public string Type { get; set; }
        [JsonRequired]
        public int Damage { get; set; }
        [JsonRequired]
        public int Range { get; set; }
        
        public JRaw[] Upgraders { get; set; }
    }
}