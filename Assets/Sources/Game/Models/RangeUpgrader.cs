using System;
using Game.Sources.Game.DataAccess.Models;
using Game.Sources.Game.Infrastructure.Loaders;

namespace Game.Sources.Game.Models
{
    public class RangeUpgrader : IUpgrader
    {
        private int _range;

        public RangeUpgrader() =>
            _range = 0;

        public RangeUpgrader(RangeUpgraderDto rangeUpgraderDto, ILoader loader)
        {
            if (rangeUpgraderDto == null)
                throw new ArgumentNullException(nameof(rangeUpgraderDto));

            if (loader == null)
                throw new ArgumentNullException(nameof(loader));

            _range = rangeUpgraderDto.Range;
        }

        public int Apply(int value) =>
            value + _range;

        public void Upgrade() =>
            _range++;
    }
}