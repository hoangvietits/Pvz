using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pvz.Entities.Components;
using Pvz.Entities;
using System.Drawing;

namespace Pvz
{
    class MouseClick
    {
        static public void Event(int x, int y)
        {
            int range = Floor.YtoRow(y);
            int col = Floor.XtoCol(x);

            List<GameObj> go = GameManager.Entities.FindAll(s => s.GetComponent<Clickable>() != null &&
            x <= s.posX + s.GetComponent<CDrawable>().HitBox.Width && 
            x >= s.posX && 
            y <= s.posY + s.GetComponent<CDrawable>().HitBox.Height && 
            y >= s.posY);

            go.ForEach(sunClicked => sunClicked.GetComponent<Clickable>().IsClicked = true);

            if(go.Count!= 0)
            {

            }
            else if(GameManager.Button == GameManager.Creature.Zombie)
            {

            }
            else
            {
                if(range >= 0 && col >= 0 && range < 5 && col < 9)
                {
                    GameObj FoundPlant = GameManager.Entities.FindAll(p => p.Tags.Contains("Plant"))
                    .Find(p => Floor.YtoRow((int)p.posY) == range && Floor.XtoCol((int)p.posX) == col);

                    if (GameManager.Button == GameManager.Creature.Shovel && FoundPlant != null)
                    {
                        FoundPlant.Inactive = true;
                    }
                    else if (FoundPlant == null && GameManager.Cost[GameManager.Button] <= GameManager.Sun)
                    {
                        PlantEntity pe = new PlantEntity(col, range, GameManager.Button);
                        GameManager.Entities.Add(pe);
                        GameManager.Sun -= GameManager.Cost[GameManager.Button];
                    }
                }
                
            }
           
        }
    }
}
