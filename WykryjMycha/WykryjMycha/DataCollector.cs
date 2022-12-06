﻿using EventHook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    internal class DataCollector : IDisposable
    {
        internal event EventHandler<MovementInfo>? eventHandler;
        private EventHookFactory _eventHookFactory;
        private MouseWatcher _mouseWatcher;
        private int _oldX, _oldY;
        private long _oldTime;

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
            args.direction = GetDirection(args.angle);

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
