using EventHook.Hooks;

namespace WykryjMycha
{
    internal struct MovementInfo
    {
        internal long time, deltaTime;
        internal double angle;
        internal int x, y;
        internal int dx, dy;
        internal MouseMessages message;
        internal MouseDirection direction;
    }
}
