using Game.Sources.Game.DataAccess.Models;

namespace Game.Sources.Game.DataAccess.Mappers
{
    public class BagMapper : MapperBase<BagDto>
    {
        public BagMapper() : base(Validate)
        {
        }

        private static bool Validate(BagDto dto) =>
            dto.Type == "Bag";
    }
}