using Game.Sources.Game.DataAccess.Models;

namespace Game.Sources.Game.DataAccess.Mappers
{
    public class DamageUpgraderMapper : MapperBase<DamageUpgraderDto>
    {
        public DamageUpgraderMapper() : base(Validate)
        {
        }

        private static bool Validate(DamageUpgraderDto dto) =>
            dto.Type == "DamageUpgrader";
    }
}