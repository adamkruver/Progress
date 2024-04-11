
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Game.Sources.Game.DataAccess.Models
{
    public class BagDto
    {
        [JsonRequired]
        public string Type { get; set; }
        
        public JRaw[] Items { get; set; }
    }
}