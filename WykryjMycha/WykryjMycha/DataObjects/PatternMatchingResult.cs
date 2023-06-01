namespace WykryjMycha
{
    public class PatternMatchingResult
    {
        internal string name;
        internal string nameLowercase;
        internal bool success;
        internal float maxTranslationDistance;
        internal float maxRotationAngle;
        internal float avgRotationAngle;
        internal string? status;

        internal float MaxTranslationDistanceNormalized => maxTranslationDistance / 100f;
        internal float MaxRotationAngleNormalized => maxRotationAngle / (float)Math.PI;
        internal PatternMatchingResult(string name)
        {
            this.name = name;
            nameLowercase = name.ToLower();
        }

        internal PatternMatchingResult Succeed()
        {
            success = true;
            return this;
        }

        internal PatternMatchingResult Fail(string reason)
        {
            success = false;
            status = reason ?? "failure";
            return this;
        }
    }
}
