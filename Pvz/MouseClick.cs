using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pvz.Entities.Components;
using Pvz.Entities;

namespace Pvz
{
    class MouseClick
    {
        static public void Event(int x, int y)
        {
            int range = Floor.YtoRow(y);
            int col = Floor.XtoCol(x);

            List<GameObj> go = GameManager.Entities.FindAll(s => s.getComponent<>);
        }
    }
}
