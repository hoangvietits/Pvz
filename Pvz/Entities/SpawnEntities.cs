using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pvz.Entities.GameObject;

namespace Pvz.Entities
{
     class SpawnEntities : GameObj
    {
        public SpawnEntities() 
        {
            Bot = new BotSpawn(this);
        }
    }
}
