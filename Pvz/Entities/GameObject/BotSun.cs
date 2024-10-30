using Pvz.Entities.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz.Entities.GameObject
{
    class BotSun : BotBase
    {
        public BotSun(GameObj go) : base(go)
        {
        }

        public override void DoSomething()
        {
            SunEntity sunEntity = AssociatedGameObject as SunEntity;
            if(AssociatedGameObject.posY <= sunEntity.EndingY)
            {
                AssociatedGameObject.GetComponent<CMoveable>().Stop();
            }
            if (AssociatedGameObject.GetComponent<Clickable>().IsClicked)
            {
                AssociatedGameObject.Inactive = true;
                GameManager.Sun += 25;
            }
        }
    }
}
