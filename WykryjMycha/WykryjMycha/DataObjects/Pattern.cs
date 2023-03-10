namespace WykryjMycha
{
    internal class Step
    {
        public string name;
        public List<Point> points;
        public List<Point> pattern;
    }

    internal class Pattern
    {
        public string name;
        public List<Point> points;
        public List<Step> steps;
    }
}
