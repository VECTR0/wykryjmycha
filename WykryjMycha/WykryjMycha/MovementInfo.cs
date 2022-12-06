using EventHook.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
