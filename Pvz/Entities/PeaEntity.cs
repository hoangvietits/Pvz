using Pvz.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz.Entities
{
     class PeaEntity : GameObj
    {
        private CHealth health;
        private CMoveable moveable;
        private CDrawable drawable;

        public PeaEntity(float posX, float posY, double shootSpeed, int dmg )
        {
            Bot = new BotPea(this);
            Layer = 3;

            drawable = AddComponents(new CDrawable()) as CDrawable;
            moveable = AddComponents(new CMoveable()) as CMoveable;
        }
    }
}
