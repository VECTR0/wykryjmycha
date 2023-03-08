using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    public enum CharacteristicPointType
    {
        Default,
        PenUp,
        PenDown
    }

    public class CharacteristicPoint
    {
        public Vector2 position { get; set; }
        public CharacteristicPointType type { get; set; }

        public CharacteristicPoint(float x = 0, float y = 0, CharacteristicPointType type = CharacteristicPointType.Default)
        {
            this.position = new Vector2(x, y);
            this.type = type;
        }
    }
}
