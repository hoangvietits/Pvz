using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz.Entities.GameObject
{
    class BotSpawn : BotBase
    {
        public BotSpawn(GameObj go) : base(go)
        {
        }

        public override void DoSomething()
        {
            if(GameManager.turn % 80 ==0)
            {
                SunEntity sun = new SunEntities(GameManager.Random(300,900), Floor.GetScreenHeight(), GameManager.Random(200,500));
                GameManager.Entities.Add(sun);

            }
            if(GameManager.turn % 120 == 0)
            {
                ZombieEntity zombie = new ZombieEntity(GameManager.Random(0, 4), ZombieEntity.RandomZombie());
                GameManager.Entities.Add(zombie);
            }
        }
    }
}
