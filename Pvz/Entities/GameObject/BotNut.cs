using Pvz.Entities.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz.Entities.GameObject
{
    class BotNut : BotBase
    {
        public BotNut(GameObj go) : base(go)
        {
        }

        public override void DoSomething()
        {
            CHealth health = AssociatedGameObject.GetComponent<CHealth>();
            CDrawable nutdraw = AssociatedGameObject.GetComponent<CDrawable>();

            if(health.HP > 1333)
            {
                nutdraw.stats = 0;
            }
            else if(health.HP < 1333 && health.HP > 666)
            {
                nutdraw.stats = 1;
            }
            else
            {
                nutdraw.stats = 2;
            }
        }
    }
}
