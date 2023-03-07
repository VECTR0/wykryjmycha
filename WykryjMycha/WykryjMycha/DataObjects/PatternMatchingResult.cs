using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    public class PatternMatchingResult
    {
        internal string name;
        internal bool success;
        internal float maxTranslationDistance;
        internal float maxRotationAngle;
        internal float avgRotationAngle;
        internal string? status;

        internal PatternMatchingResult(string name)
        {
            this.name = name;
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
