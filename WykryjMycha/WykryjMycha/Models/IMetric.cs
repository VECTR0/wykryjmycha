namespace WykryjMycha
{
    public interface IMetric
    {
        public float GetValue(PatternMatchingResult result);
        public void Initialize(Settings settings);
    }
}
