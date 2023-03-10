namespace WykryjMycha
{
    internal class PatternMatchingResults
    {
        internal List<PatternMatchingResult> results;

        internal PatternMatchingResults()
        {
            results = new List<PatternMatchingResult>();
        }

        internal void Add(PatternMatchingResult result)
        {
            results.Add(result);
        }

        private void Sort(IMetric metric)
        {
            results.Sort(delegate (PatternMatchingResult x, PatternMatchingResult y)
            {
                return metric.GetValue(x).CompareTo(metric.GetValue(y));
            });
        }
        internal List<PatternMatchingResult> GetPossible(IMetric metric)
        {
            Sort(metric);
            return results.Where(x => x.success).ToList();
        }

        internal PatternMatchingResult? GetBest(IMetric metric)
        {
            var possible = GetPossible(metric);
            return possible.Count > 0 ? possible[0] : null;
        }
    }
}
