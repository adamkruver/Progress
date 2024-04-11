namespace Game.Sources.Game.Infrastructure.Loaders
{
    public interface ILoader
    {
        object Load(string json);
    }
}