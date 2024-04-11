using System.Collections.Generic;
using Game.Sources.Game.DataAccess.Mappers;
using Game.Sources.Game.Infrastructure.Factories;

namespace Game.Sources.Game.Infrastructure.Loaders
{
    public class Loader : ILoader
    {
        private readonly IReadOnlyDictionary<IMapper, IFactory> _factories;

        public Loader() =>
            _factories = new Dictionary<IMapper, IFactory>()
            {
                [new BagMapper()] = new BagFactory(this),
                [new WeaponMapper()] = new WeaponFactory(this),
                [new DamageUpgraderMapper()] = new DamageUpgraderFactory(this),
                [new RangeUpgraderMapper()] = new RangeUpgraderFactory(this)
            };

        public object Load(string json)
        {
            var dto = Create(json);

            return dto;
        }

        private object Create(string json)
        {
            foreach (IMapper mapper in _factories.Keys)
            {
                var @object = mapper.MapJsonToDto(json);

                if (@object == null)
                    continue;

                return _factories[mapper].Create(@object);
            }

            return default;
        }
    }
}