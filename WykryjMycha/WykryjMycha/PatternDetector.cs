using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    internal class PatternDetector
    {
        private const int DIRECTIONS_BUFFER_SIZE = 10;

        private List<MouseDirection> _collectedDirections;
        private readonly GesturePattern[] _patterns;
        private readonly MainWindow _mainWindow;

        internal PatternDetector(GesturePattern[] patterns, MainWindow instance)
        {
            _collectedDirections = new List<MouseDirection>();
            _patterns = patterns;
            _mainWindow = instance;
        }

        internal void Start()
        {
            _collectedDirections.Clear();
        }

        internal MovementInfo ProcessMovementEvent(MovementInfo args)
        {
            if (_collectedDirections.Count == 0 || args.direction != _collectedDirections[^1])
            {
                _collectedDirections.Add(args.direction);

                if (_collectedDirections.Count > DIRECTIONS_BUFFER_SIZE)
                    _collectedDirections.RemoveAt(0);
            }

            foreach (var pattern in _patterns)
            {
                if (_collectedDirections.Count < pattern.directions.Length) continue;

                int bufferIndex = 0;
                foreach (var direction in _collectedDirections)
                {
                    if (direction == pattern.directions[bufferIndex])
                    {
                        if (++bufferIndex == pattern.directions.Length)
                        {
                            _mainWindow.Log = pattern.name;
                            args.patternName = pattern.name;
                            _collectedDirections.Clear();
                            break;
                        }
                    }
                    else
                    {
                        bufferIndex = 0;
                    }
                }
            }
            return args;
        }
    }
}
