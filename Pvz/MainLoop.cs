using Pvz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz
{
    class MainLoop
    {
        public static void DoSomeThing()
        {
            GameManager.Entities.RemoveAll(x => x.Inactive);
            for (int i = 0; i < GameManager.Entities.ToArray().Length; i++)
            {
                GameManager.Entities[i].Update();
            }

        }
        public static void ShowObj()
        {
            foreach(GameObj go in GameManager.Entities.OrderBy(x => x.layer))
            {
                CDrawable drawable = go.GetComponents<CDrawable>();
                if(drawable != null) 
                {
                    drawable.Draw();
                }
            }
        }
    }
}
