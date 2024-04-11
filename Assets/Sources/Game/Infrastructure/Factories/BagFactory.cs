using System;
using Game.Sources.Game.DataAccess.Models;
using Game.Sources.Game.Infrastructure.Loaders;
using Game.Sources.Game.Models;
using Newtonsoft.Json;

namespace Game.Sources.Game.Infrastructure.Factories
{
    public class BagFactory : IFactory
    {
        private readonly ILoader _loader;

        public BagFactory(ILoader loader) => 
            _loader = loader ?? throw new ArgumentNullException(nameof(loader));

        public object Create(object dto)
        {
            if(dto is not BagDto bagDto)
                throw new InvalidCastException(nameof(dto));

            return new Bag(bagDto, _loader);
        }
    }
}