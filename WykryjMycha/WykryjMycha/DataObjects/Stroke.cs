namespace WykryjMycha
{
    internal class Stroke
    {
        private List<Point> _normalizedPoints = null;
        private string _nameLowercase = null;

        public string name { get; set; }
        public List<Point> points { get; set; }
        public bool isPattern { get; set; }

        public string NameLowercase
        {
            get
            {
                if (_nameLowercase == null)
                    _nameLowercase = name.ToLower();
                return _nameLowercase;
            }
        }
        public List<Point> NormalizedPoints
        {
            get
            {
                if (_normalizedPoints == null)
                    _normalizedPoints = new List<Point>(MathUtils.NormalizePoints(points));
                return _normalizedPoints;
            }
        }
    }
}
