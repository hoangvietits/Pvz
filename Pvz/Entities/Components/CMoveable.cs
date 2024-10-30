using Pvz.Entities.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz.Entities.Components
{
    class CMoveable : Component
    {
        public bool HasStopped { get; set; }
        public Point Speed { get; set; }
        public Point _initialSpeed;
        public Point InitialSpeed
        {
            get { return _initialSpeed; }
            set
            {
                _initialSpeed = value;
                Speed = value;
            }
        }
        public bool IsOutBound
        {
            get
            {
                return parent.posX > Floor.GetScreenWidth();
            }
        }

        public override void Update()
        {
            Move(Speed.X, Speed.Y);
        }
        public void Move(float x, float y)
        {
            parent.posX += (int)(x * GameManager.DeltaTime);
            parent.posY += (int)(y * GameManager.DeltaTime);
        }
        public void Stop()
        {
            HasStopped = true;
            Speed = new Point(0, 0);
        }
        public void Resume()
        {
            if (HasStopped)
            {
                Speed = InitialSpeed;
                HasStopped = false;
            }
        }
    }
}
