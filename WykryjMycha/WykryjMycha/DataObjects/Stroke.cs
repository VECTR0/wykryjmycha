namespace WykryjMycha
{
    internal class Stroke
    {
        public string name { get; set; }
        public List<Point> points { get; set; }
        public bool isPattern { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
