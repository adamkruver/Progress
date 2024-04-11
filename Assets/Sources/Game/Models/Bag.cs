using System;
using System.Collections.Generic;
using Game.Sources.Game.DataAccess.Models;
using Game.Sources.Game.Infrastructure.Loaders;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Game.Sources.Game.Models
{
    public class Bag
    {
        private List<object> _items;

        public Bag(BagDto bagDto, ILoader loader)
        {
            if (bagDto == null) 
                throw new ArgumentNullException(nameof(bagDto));
            
            if (loader == null) 
                throw new ArgumentNullException(nameof(loader));

            _items = new List<object>();

            CreateItems(bagDto.Items, loader);
        }

        private void CreateItems(JRaw[] bagDtoItems, ILoader loader)
        {
            if(bagDtoItems == null)
                return;
            
            foreach (var item in bagDtoItems) 
                _items.Add(loader.Load(item.ToString()));
        }
    }
}