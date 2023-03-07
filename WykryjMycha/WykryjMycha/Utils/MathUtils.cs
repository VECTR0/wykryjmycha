using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    internal static class MathUtils
    {
        public static Vector2 GetCentroid(List<Vector2> points)
        {
            Vector2 centroid = new Vector2();
            foreach (var vector in points)
            {
                centroid += vector;
            }
            centroid /= points.Count;
            return centroid;
        }

        public static Tuple<Vector2, Vector2> GetBoundingBox(List<Vector2> points)
        {
            var min = new Vector2(999, 999);
            var max = new Vector2(-999, -999);
            foreach (var point in points)
            {
                min = Vector2.Min(min, point);
                max = Vector2.Max(max, point);
            }
            return new Tuple<Vector2, Vector2>(min, max);
        }

        public static List<Vector2> NormalizePoints(List<Vector2> points, float targetSize = 150f)
        {
            var bbox = GetBoundingBox(points);
            float scale = 1f / Math.Max(bbox.Item2.X - bbox.Item1.X, bbox.Item2.Y - bbox.Item1.Y);
            scale *= targetSize;
            var centroid = GetCentroid(points);
            var offset = new Vector2(targetSize, targetSize);
            for (int i = 0; i < points.Count; i++)
            {
                points[i] -= centroid;
                points[i] *= scale;
                points[i] += offset;
            }
            return points;
        }

        public static float DistanceFromLine(Vector2 x, Vector2 a, Vector2 b)
        {
            var x0 = x.X;
            var y0 = x.Y;
            var x1 = a.X;
            var y1 = a.Y;
            var x2 = b.X;
            var y2 = b.Y;
            return (float)(Math.Abs((x2 - x1) * (y1 - y0) - (x1 - x0) * (y2 - y1)) /
                Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
        }

        public static float DistanceFromSegment(Vector2 x, Vector2 a, Vector2 b)
        {
            var ab = b - a;
            var ax = x - a;
            var proj = Vector2.Dot(ax, ab);
            var d = proj / ab.LengthSquared();
            if (d < 0) return ax.Length();
            else if (d > 0) return (b - x).Length();
            else return DistanceFromLine(x, a, b);
        }

        public static List<Vector2> RotatePoints(List<Vector2> points, Vector2 rotationPoint, float angle)
        {
            float s = (float)Math.Sin(angle);
            float c = (float)Math.Cos(angle);
            for (int i = 0; i < points.Count; i++)
            {
                var p = points[i];
                p.X -= rotationPoint.X;
                p.Y -= rotationPoint.Y;

                float xnew = p.X * c - p.Y * s;
                float ynew = p.X * s + p.Y * c;

                p.X = xnew + rotationPoint.X;
                p.Y = ynew + rotationPoint.Y;
                points[i] = p;
            }
            return points;
        }
        public static void TranslatePoints(List<Vector2> points, Vector2 delta)
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i] += delta;
            }
        }

        public static float GetSmallestAbsoluteAngle(float deltaAngle)
        {
            deltaAngle = (float)Math.Abs(deltaAngle) % (float)(2 * Math.PI);
            if (deltaAngle > Math.PI) deltaAngle = (float)(2 * Math.PI) - deltaAngle;
            return deltaAngle;
        }
    }
}
