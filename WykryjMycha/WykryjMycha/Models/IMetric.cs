namespace WykryjMycha
{
    public interface IMetric
    {
        public float GetValue(PatternMatchingResult result);
        public IMetric New(Settings settings);
    }
}
