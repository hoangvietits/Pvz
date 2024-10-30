using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz.Entities.GameObject
{
    class BotPlant : BotBase
    {
        public BotPlant(GameObj go) : base(go)
        {
        }

        public override void DoSomething()
        {
            botState = "None";
            if(GameManager.Entities.Find(x => x.GetType() == typeof(ZombieEntity) && Floor.YtoRow((int)x.CorrectedY) == Floor.YtoRow((int)AssociatedGameObject.CorrectedY)) != null)
            {
                botState = "Shooting";
            }
        }
    }
}
