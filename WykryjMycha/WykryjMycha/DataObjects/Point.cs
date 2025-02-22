﻿using System.Numerics;

namespace WykryjMycha
{
    internal struct Point
    {
        internal float X { get; set; }
        internal float Y { get; set; }
        internal PointOrigin PointOrigin { get; set; }
        internal float angleWeight {get; set; }
        internal float distanceWeight {get; set; }

        internal Point(float x = 0, float y = 0, PointOrigin pointOrigin = PointOrigin.PenMove, float angleWeight = 1, float distanceWeight = 1)
        {
            X = x;
            Y = y;
            PointOrigin = pointOrigin;
            this.angleWeight = angleWeight;
            this.distanceWeight = distanceWeight;
        }

        // Note that PointOrigin of left value is preserved
        public static Point operator +(Point left, Point right)
        {
            return new Point(left.X + right.X, left.Y + right.Y, left.PointOrigin, left.angleWeight, left.distanceWeight);
        }

        public static Point operator -(Point left, Point right)
        {
            return new Point(left.X - right.X, left.Y - right.Y, left.PointOrigin, left.angleWeight, left.distanceWeight);
        }

        public static Point operator *(Point left, float right)
        {
            return new Point(left.X * right, left.Y * right, left.PointOrigin, left.angleWeight, left.distanceWeight);
        }

        public static Point operator /(Point left, float right)
        {
            return new Point(left.X / right, left.Y / right, left.PointOrigin, left.angleWeight, left.distanceWeight);
        }

        internal static Point Min(Point val1, Point val2)
        {
            return new Point(Math.Min(val1.X, val2.X), Math.Min(val1.Y, val2.Y), val1.PointOrigin, val1.angleWeight, val1.distanceWeight);
        }

        internal static Point Max(Point val1, Point val2)
        {
            return new Point(Math.Max(val1.X, val2.X), Math.Max(val1.Y, val2.Y), val1.PointOrigin, val1.angleWeight, val1.distanceWeight);
        }

        internal static float Dot(Point val1, Point val2)
        {
            return val1.X * val2.X + val1.Y * val2.Y;
        }

        internal float LengthSquared()
        {
            return X * X + Y * Y;
        }

        internal float Length()
        {
            return (float)Math.Sqrt(X * X + Y * Y);
        }

        internal static float Distance(Point val1, Point val2)
        {
            return (val2 - val1).Length();
        }
    }
}
