using Game.Sources.Game.DataAccess.Models;

namespace Game.Sources.Game.DataAccess.Mappers
{
    public class WeaponMapper : MapperBase<WeaponDto>
    {
        public WeaponMapper() : base(Validate)
        {
        }

        private static bool Validate(WeaponDto dto) =>
            dto.Type == "Weapon";
    }
}