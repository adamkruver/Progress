using System;
using Newtonsoft.Json;

namespace Game.Sources.Game.DataAccess.Mappers
{
    public class MapperBase<T> : IMapper
    {
        private readonly Func<T, bool> _validator;

        public MapperBase(Func<T, bool> validator) => 
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));

        public object MapJsonToDto(string json)
        {
            try
            {
                var dto = JsonConvert.DeserializeObject<T>(json);
                
                if(_validator.Invoke(dto) == false)
                    throw new Exception();

                return dto;
            }
            catch
            {
                return null;
            }
        }
    }
}