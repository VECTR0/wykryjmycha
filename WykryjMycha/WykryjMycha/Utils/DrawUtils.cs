namespace WykryjMycha
{
    internal static class DrawUtils
    {
        internal static void DrawPattern(List<Point> points, PictureBox pic, int selectedPoint = -1, float size = 10f)
        {
            using Graphics g = Graphics.FromImage(pic.Image);
            for (int i = 0; i < points.Count - 1; i++)
            {
                var current = points[i];
                var next = points[i + 1];
                g.DrawLine(Pens.Red, current.X, current.Y, next.X, next.Y);
            }
            for (int i = 0; i < points.Count; i++)
            {
                var p = points[i];
                Brush brush = i == 0 ? Brushes.Orange : Brushes.Red;
                if (i != selectedPoint)
                {
                    g.FillEllipse(brush, p.X - size / 2, p.Y - size / 2f, size, size);
                }
                else
                {
                    g.FillEllipse(brush, p.X - size / 4f, p.Y - size / 4f, size/2f, size / 2f);
                }
            }
            pic.Invalidate();
        }

        internal static void ClearPictureBox(PictureBox pic)
        {
            var oldImage = pic.Image;
            pic.Image = new Bitmap(pic.Width, pic.Height);
            oldImage?.Dispose();
        }

        internal static void DrawPoint(int x, int y, PictureBox pic)
        {
            using Graphics g = Graphics.FromImage(pic.Image);
            g.DrawRectangle(Pens.Black, x, y, 1, 1);
            pic.Invalidate();
        }

        internal static void DrawPoints(List<Point> points, Brush brush, PictureBox pic, float size = 3)
        {
            using Graphics g = Graphics.FromImage(pic.Image);
            points.ForEach(p =>
            {
                g.FillEllipse(brush, p.X - size / 2, (float)(p.Y - size / 2), size * 2, size * 2);
            });
            pic.Invalidate();
        }

        internal static void DrawLines(List<Point> points, Pen pen, PictureBox pic)
        {
            using Graphics g = Graphics.FromImage(pic.Image);
            for (int i = 0; i < points.Count - 1; i++)
            {
                g.DrawLine(pen, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }
            pic.Invalidate();
        }

        internal static void DrawCircles(List<Point> points, Pen pen, PictureBox pic, float size = 3)
        {
            using Graphics g = Graphics.FromImage(pic.Image);
            points.ForEach(p =>
            {
                g.DrawEllipse(pen, p.X - size / 2, (float)(p.Y - size / 2), size * 2, size * 2);
            });
            pic.Invalidate();
        }

        internal static void DrawStroke(Stroke stroke, PictureBox pic)
        {
            using Graphics g = Graphics.FromImage(pic.Image);
            var points = stroke.points;
            for (int i = 0; i < points.Count - 1; i++)
            {
                var current = points[i];
                var next = points[i + 1];
                g.DrawRectangle(Pens.Black, current.X, current.Y, 1, 1);
            }
            pic.Invalidate();
        }
    }
}
