namespace WykryjMycha
{
    internal class PatternEditorController
    {
        internal MainForm editorView;
        private PatternDatabase _patternDatabase;
        private int _selectedEditorPattern = -1;
        private int _selectedEditorPoint = -1;
        private int _lastSelectedEditorPoint = -1;

        internal PatternEditorController(MainForm editorView, PatternDatabase patternDatabase)
        {
            this.editorView = editorView;
            _patternDatabase = patternDatabase;
            editorView.SetEditorPatterns(_patternDatabase.GetPatterns());
            _patternDatabase.changed += UpdateEditorPatterns;
        }

        private void UpdateEditorPatterns(object? sender, EventArgs e)
        {
            _selectedEditorPattern = -1;
            _lastSelectedEditorPoint = -1;
            editorView.SetEditorPatterns(_patternDatabase.GetPatterns());
        }

        internal void HandleEditorPatternSelected(int index)
        {
            _selectedEditorPattern = index;
            if (index < 0) return;
            var pattern = _patternDatabase.GetPatterns()[_selectedEditorPattern];
            editorView.RenderPattern(pattern, _lastSelectedEditorPoint);
        }

        internal void DeletePattern()
        {
            _patternDatabase.DeletePattern(_selectedEditorPattern);
            editorView.SetEditorPatterns(_patternDatabase.GetPatterns());
        }

        internal void HandleEditorMouseDown(int x, int y)
        {
            var pattern = _patternDatabase.GetPatterns()[_selectedEditorPattern];
            int nearestPointIndex = 0;
            float nearestDistance = 9999999;
            for (int i = 0; i < pattern.points.Count; i++)
            {
                var point = pattern.points[i];
                float distance = Point.Distance(new Point(x,y), point);
                if (distance < nearestDistance)
                {
                    nearestPointIndex = i;
                    nearestDistance = distance;
                }
            }
            if (nearestDistance < 30)
            {
                _selectedEditorPoint = nearestPointIndex;
                _lastSelectedEditorPoint = _selectedEditorPoint;
            }
            editorView.RenderPattern(_patternDatabase.GetPatterns()[_selectedEditorPattern], _lastSelectedEditorPoint);
        }

        internal void HandleEditorMouseMove(int x, int y)
        {
            if (_selectedEditorPoint < 0) return;
            var pattern = _patternDatabase.GetPatterns()[_selectedEditorPattern];
            var oldPoint = pattern.points[_selectedEditorPoint];
            pattern.points[_selectedEditorPoint] = new Point(x, y, oldPoint.PointOrigin, oldPoint.angleWeight, oldPoint.distanceWeight);
            editorView.RenderPattern(_patternDatabase.GetPatterns()[_selectedEditorPattern], _lastSelectedEditorPoint);
        }

        internal void HandleEditorMouseUp(int x, int y)
        {
            _selectedEditorPoint = -1;
            var pattern = _patternDatabase.GetPatterns()[_selectedEditorPattern];
            pattern.points = MathUtils.NormalizePoints(pattern.points);
            editorView.RenderPattern(_patternDatabase.GetPatterns()[_selectedEditorPattern], _lastSelectedEditorPoint);
            editorView.SetAngleWeight((decimal)_patternDatabase.GetPatterns()[_selectedEditorPattern].points[_lastSelectedEditorPoint].angleWeight);
            editorView.SetDistanceWeight((decimal)_patternDatabase.GetPatterns()[_selectedEditorPattern].points[_lastSelectedEditorPoint].distanceWeight);
        }

        internal void ExportPatternDatabase()
        {
            _patternDatabase.Export();
        }

        internal void ImportPatternDatabase()
        {
            _patternDatabase.Import();
        }

        internal void AngleWeightChanged(float value)
        {
            var pattern = _patternDatabase.GetPatterns()[_selectedEditorPattern];
            var oldPoint = pattern.points[_lastSelectedEditorPoint];
            pattern.points[_lastSelectedEditorPoint] = new Point(oldPoint.X, oldPoint.Y, oldPoint.PointOrigin, value, oldPoint.distanceWeight);
        }

        internal void DistanceWeightChanged(float value)
        {
            var pattern = _patternDatabase.GetPatterns()[_selectedEditorPattern];
            var oldPoint = pattern.points[_lastSelectedEditorPoint];
            pattern.points[_lastSelectedEditorPoint] = new Point(oldPoint.X, oldPoint.Y, oldPoint.PointOrigin, oldPoint.angleWeight, value);
        }
    }
}
