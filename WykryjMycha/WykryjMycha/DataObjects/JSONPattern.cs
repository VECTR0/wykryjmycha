namespace WykryjMycha
{
    internal class JSONPattern
    {
        public string name { get; set; }
        public List<float> xList  { get; set; }
        public List<float> yList  { get; set; }
        public List<PointOrigin> pointOriginList  { get; set; }
        public List<float> angleWeightList  { get; set; }
        public List<float> distanceWeightList { get; set; }
    }
}
