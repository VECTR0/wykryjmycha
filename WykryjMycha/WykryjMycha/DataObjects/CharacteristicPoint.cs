namespace WykryjMycha
{
    internal enum CharacteristicPointType
    {
        Default,
        PenUp,
        PenDown
    }

    internal class CharacteristicPoint
    {
        public Point position { get; set; }
        public CharacteristicPointType type { get; set; }

        public CharacteristicPoint(float x = 0, float y = 0, CharacteristicPointType type = CharacteristicPointType.Default)
        {
            this.position = new Point(x, y);
            this.type = type;
        }
    }
}
