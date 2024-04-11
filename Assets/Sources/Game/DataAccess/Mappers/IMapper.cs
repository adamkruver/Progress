namespace Game.Sources.Game.DataAccess.Mappers
{
    public interface IMapper
    {
        object MapJsonToDto(string json);
    }
}