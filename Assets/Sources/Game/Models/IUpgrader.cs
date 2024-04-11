namespace Game.Sources.Game.Models
{
    public interface IUpgrader
    {
        int Apply(int value);
        void Upgrade();
    }
}