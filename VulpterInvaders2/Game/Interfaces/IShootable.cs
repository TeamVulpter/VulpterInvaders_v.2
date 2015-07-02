

namespace Game.Interfaces
{
    public interface IShootable
    {
        bool IsActive { get; set; }

        void Start();

        void Stop();

    }
}
