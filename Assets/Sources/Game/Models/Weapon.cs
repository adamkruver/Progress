using System.Collections.Generic;
using System.Linq;

namespace Game.Sources.Game.Models
{
    public class Weapon
    {
        private readonly IDictionary<string, IUpgrader> _upgraders;

        private int _damage;
        private int _range;

        public Weapon(int damage, int range, IEnumerable<IUpgrader> upgraders)
        {
            _damage = damage;
            _range = range;
            _upgraders = upgraders?.ToDictionary(
                             upgrader => upgrader.GetType().Name,
                             upgrader => upgrader
                         )
                         ?? new Dictionary<string, IUpgrader>();
        }

        public int Damage => _upgraders.TryGetValue("DamageUpgrader", out var upgrader)
            ? upgrader.Apply(_damage)
            : _damage;

        public int Range => _upgraders.TryGetValue("RangeUpgrader", out var upgrader)
            ? upgrader.Apply(_range)
            : _range;

        public void UpgradeDamage()
        {
            if (_upgraders.TryGetValue("DamageUpgrader", out var upgrader) == false)
            {
                upgrader = new DamageUpgrader();
                _upgraders.Add("DamageUpgrader", upgrader);
            }

            upgrader.Upgrade();
        }

        public void UpgradeRange()
        {
            if (_upgraders.TryGetValue("RangeUpgrader", out var upgrader) == false)
            {
                upgrader = new RangeUpgrader();
                _upgraders.Add("RangeUpgrader", upgrader);
            }

            upgrader.Upgrade();
        }
    }
}