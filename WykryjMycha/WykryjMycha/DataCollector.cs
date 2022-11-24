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
        internal event EventHandler<DataCollectorEventArgs>? eventHandler;
        private EventHookFactory _eventHookFactory;
        private MouseWatcher _mouseWatcher;

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
            DataCollectorEventArgs args = new DataCollectorEventArgs()
            {
                x = e.Point.x,
                y = e.Point.y,
                message = e.Message
            };
            eventHandler?.Invoke(sender, args);
        }

        public void Dispose()
        {
            _eventHookFactory.Dispose();
        }
    }
}
