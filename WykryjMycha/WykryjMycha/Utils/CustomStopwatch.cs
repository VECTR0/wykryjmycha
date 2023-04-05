namespace WykryjMycha
{
    internal class CustomStopwatch
    {
        DateTime start;

        internal void Start() => start = DateTime.Now;
        internal TimeSpan MeasureAndStart()
        {
            var elapsed = DateTime.Now.Subtract(start);
            Start();
            return elapsed;
        }
    }
}
