using EventHook;

namespace WykryjMycha
{
    internal class DataCollector : IDisposable
    {
        private const int TAKE_EVERY_X_SAMPLE = 100;
        private const int DIRECTIONS_BUFFER_SIZE = 10;

        private MainWindow _logger;
        internal event EventHandler<MovementInfo>? eventHandler;
        private EventHookFactory _eventHookFactory;
        private MouseWatcher _mouseWatcher;
        private GesturePattern[] _patterns;

        private int _currentSample;
        private int _oldX, _oldY;
        private long _oldTime;
        private List<MouseDirection> _collectedDirections;

        internal DataCollector(GesturePattern[] patterns, MainWindow logger)
        {
            _eventHookFactory = new EventHookFactory();
            _mouseWatcher = _eventHookFactory.GetMouseWatcher();
            _mouseWatcher.OnMouseInput += OnMouseInput;
            _collectedDirections = new List<MouseDirection>();
            _patterns = patterns;
            _logger = logger;
        }

        internal void Start()
        {
            _mouseWatcher.Start();
            _collectedDirections.Clear();
        }

        internal void Stop()
        {
            _mouseWatcher.Stop();
        }

        private void OnMouseInput(object? sender, EventHook.MouseEventArgs e)
        {
            if (++_currentSample != TAKE_EVERY_X_SAMPLE) return;

            _currentSample = 0;

            MovementInfo args = new MovementInfo()
            {
                x = e.Point.x,
                y = e.Point.y,
                dx = e.Point.x - _oldX,
                dy = e.Point.y - _oldY,
                message = e.Message,
                time = DateTime.Now.Millisecond,
            };
            args.deltaTime = args.time - _oldTime;
            args.angle = Math.Atan2(args.dy, args.dx) * 180.0 / Math.PI;
            args.direction = GetDirection(args.angle);
            args.patternName = String.Empty;

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
                            _logger.Log = pattern.name;
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

            _oldX = e.Point.x;
            _oldY = e.Point.y;
            _oldTime = args.time;
            eventHandler?.Invoke(sender, args);
        }

        public void Dispose()
        {
            _eventHookFactory.Dispose();
        }

        private MouseDirection GetDirection(double angle)
        {
            if (angle <= 22.5 && angle >= -22.5)
            {
                return MouseDirection.Right;
            }
            else if (angle > 22.5 && angle < 67.5)
            {
                return MouseDirection.DownRight;
            }
            else if (angle >= 67.5 && angle <= 112.5)
            {
                return MouseDirection.Down;
            }
            else if (angle > 112.5 && angle < 157.5)
            {
                return MouseDirection.DownLeft;
            }
            else if (angle >= -157.5 && angle <= -112.5)
            {
                return MouseDirection.UpLeft;
            }
            else if (angle >= -112.5 && angle <= -67.5)
            {
                return MouseDirection.Up;
            }
            else if (angle > -67.5 && angle < -22.5)
            {
                return MouseDirection.UpRight;
            }
            else
            {
                return MouseDirection.Left;
            }
        }
    }
}
