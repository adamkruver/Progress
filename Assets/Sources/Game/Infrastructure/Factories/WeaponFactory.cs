using System;
using System.Collections.Generic;
using Game.Sources.Game.DataAccess.Models;
using Game.Sources.Game.Infrastructure.Loaders;
using Game.Sources.Game.Models;
using Newtonsoft.Json.Linq;

namespace Game.Sources.Game.Infrastructure.Factories
{
    public class WeaponFactory : IFactory
    {
        private readonly ILoader _loader;

        public WeaponFactory(ILoader loader) => 
            _loader = loader ?? throw new ArgumentNullException(nameof(loader));

        public object Create(object dto)
        {
            if (dto is not WeaponDto weaponDto)
                throw new InvalidCastException(nameof(dto));
            
            return new Weapon(weaponDto.Damage, weaponDto.Range, CreateUpgraders(weaponDto.Upgraders, _loader));
        }
        
        private IEnumerable<IUpgrader> CreateUpgraders(JRaw[] weaponDtoUpgraders, ILoader loader)
        {
            if(weaponDtoUpgraders == null)
                return new IUpgrader[] {};

            List<IUpgrader> upgraders = new List<IUpgrader>();

            foreach (var dtoUpgrader in weaponDtoUpgraders)
            {
                var updrader = loader.Load(dtoUpgrader.ToString());
                
                if(updrader is not IUpgrader concreteUpgrader)
                    continue;
                
                upgraders.Add(concreteUpgrader);
            }
            
            return upgraders;
        }
    }
}