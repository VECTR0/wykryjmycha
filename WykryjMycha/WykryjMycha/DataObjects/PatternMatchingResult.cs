using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    internal class PatternMatchingResult
    {
        internal bool success;
        internal float maxTranslationDistance;
        internal float maxRotationAngle;
        internal string? status;

        internal PatternMatchingResult Succeed()
        {
            success = true;
            return this;
        }

        internal PatternMatchingResult Fail(string reason)
        {
            success = false;
            status = reason;
            return this;
        }
    }
}
