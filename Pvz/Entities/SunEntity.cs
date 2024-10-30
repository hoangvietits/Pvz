using Pvz.Entities.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pvz.Entities.GameObject;
namespace Pvz.Entities
{
     class SunEntity : GameObj
    {
        CDrawable drawable;
        CMoveable moveable;
        public int EndingY;

        public SunEntity(int posX,int posY,int endingY)
        {
            Layer = 3;
            Bot = new BotSun(this);
            Tags.Add("Sun");

            this.posX = posX;
            this.posY = posY;
            this.EndingY = endingY;

            drawable = AddComponent(new CDrawable()) as CDrawable;
            moveable = AddComponent(new CMoveable()) as CMoveable;
            AddComponent(new Clickable());
            AddComponent(new CDisappear(500));

            moveable.InitialSpeed = new Point(0, -50);
            drawable.HitBox = new Size(55, 54);
            drawable.Sprites = new List<string> { "sun" };
        }
    }
}
