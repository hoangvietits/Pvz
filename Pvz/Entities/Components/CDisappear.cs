using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz.Components
{
     class CDisappear : Component
    {
        public int StartRound;
        public int Delay;

        public CDisappear(int delay)
        {
            StartRound = GameManager.turn;
            Delay = delay;
        }
        public override void Update()
        {
            if(GameManager.turn == StartRound + Delay)
            {
                parent.Inactive = true;
            }
        }
    }
}
