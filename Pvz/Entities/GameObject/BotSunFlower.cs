using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pvz.Entities.Components;


namespace Pvz.Entities.GameObject
{
    class BotSunFlower : BotBase
    {
        int begin;
        public BotSunFlower(GameObj go) : base(go)
        {
            begin = GameManager.turn;
        }
        public override void DoSomething()
        {
            if ((begin + 80 <= GameManager.turn))
            {
                begin = GameManager.turn;
                SunEntity sun = new SunEntity((int)AssociatedGameObject.posX + 10, (int)AssociatedGameObject.posY + 40, (int)AssociatedGameObject.posY);
                GameManager.Entities.Add(sun);
            }
        }
    }
}
