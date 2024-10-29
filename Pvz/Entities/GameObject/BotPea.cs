using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz.Entities.GameObject
{
    class BotPea : BotBase
    {
        public BotPea(GameObj go) : base(go)
        {
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
