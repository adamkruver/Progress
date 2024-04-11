using System;
using Game.Sources.Game.DataAccess.Models;
using Game.Sources.Game.Infrastructure.Loaders;
using Game.Sources.Game.Models;

namespace Game.Sources.Game.Infrastructure.Factories
{
    public class RangeUpgraderFactory : IFactory
    {
        private readonly ILoader _loader;

        public RangeUpgraderFactory(ILoader loader)
        {
            _loader = loader ?? throw new ArgumentNullException(nameof(loader));
        }

        public object Create(object dto)
        {
            if (dto is not RangeUpgraderDto rangeUpgraderDto)
                throw new InvalidCastException(nameof(dto));
            
            return new RangeUpgrader(rangeUpgraderDto, _loader);
        }
    }
}