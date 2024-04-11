using Game.Sources.Game.DataAccess.Models;

namespace Game.Sources.Game.DataAccess.Mappers
{
    public class RangeUpgraderMapper : MapperBase<RangeUpgraderDto>
    {
        public RangeUpgraderMapper() : base(Validate)
        {
        }

        private static bool Validate(RangeUpgraderDto dto) =>
            dto.Type == "RangeUpgrader";
    }
}