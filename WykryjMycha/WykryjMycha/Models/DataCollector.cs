using EventHook.Hooks;
using EventHook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    internal class DataCollector : IDisposable
    {
        internal event EventHandler<MovementInfo>? eventHandler;
        private EventHookFactory _eventHookFactory;
        private MouseWatcher _mouseWatcher;

        private int _currentSample;
        private int _oldX, _oldY;
        private long _oldTime;
        private MouseMessages _oldMessage;

        internal DataCollector()
        {
            _eventHookFactory = new EventHookFactory();
            _mouseWatcher = _eventHookFactory.GetMouseWatcher();
            _mouseWatcher.OnMouseInput += OnMouseInput;
        }

        internal void Start()
        {
            _mouseWatcher.Start();
        }

        internal void Stop()
        {
            _mouseWatcher.Stop();
        }

        private void OnMouseInput(object? sender, EventHook.MouseEventArgs e)
        {
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

            if (++_currentSample != Settings.takeEveryXSample && Math.Abs(DateTime.Now.Millisecond - _oldTime) < 100 && _oldMessage == args.message)
            {
                return;
            }

            _currentSample = 0;

            _oldX = e.Point.x;
            _oldY = e.Point.y;
            _oldTime = args.time;
            _oldMessage = args.message;
            eventHandler?.Invoke(sender, args);
        }

        public void Dispose()
        {
            _eventHookFactory.Dispose();
        }
    }
}
