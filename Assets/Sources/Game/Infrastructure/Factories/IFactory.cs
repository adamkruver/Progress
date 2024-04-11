namespace Game.Sources.Game.Infrastructure.Factories
{
    public interface IFactory
    {
        object Create(object dto);
    }
}