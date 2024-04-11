using System;
using Game.Sources.Game.DataAccess.Models;
using Game.Sources.Game.Infrastructure.Loaders;

namespace Game.Sources.Game.Models
{
    public class DamageUpgrader : IUpgrader
    {
        private int _damage;

        public DamageUpgrader() => 
            _damage = 0;

        public DamageUpgrader(DamageUpgraderDto damageUpgraderDto, ILoader loader)
        {
            if (damageUpgraderDto == null) 
                throw new ArgumentNullException(nameof(damageUpgraderDto));
            
            if (loader == null) 
                throw new ArgumentNullException(nameof(loader));
            
            _damage = damageUpgraderDto.Damage;
        }

        public int Apply(int value) => 
            value + _damage;

        public void Upgrade() => 
            _damage++;
    }
}