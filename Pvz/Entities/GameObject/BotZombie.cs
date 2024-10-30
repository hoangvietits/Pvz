using Pvz.Entities.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz.Entities.GameObject
{
    class BotZombie : BotBase
    {
        public BotZombie(GameObj go) : base(go)
        {
        }

        public override void DoSomething()
        {
            GameObj foundPlant = GameManager.Entities.FindAll(x => x.Tags.Contains("Plant")).Find(plant =>
            AssociatedGameObject.posX <= plant.posX + plant.GetComponent<CDrawable>().HitBox.Width &&
            AssociatedGameObject.posX + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Width >= plant.posX &&
            AssociatedGameObject.CorrectedY <= plant.CorrectedY + plant.GetComponent<CDrawable>().HitBox.Height &&
            AssociatedGameObject.CorrectedY + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Height >= plant.CorrectedY);

            if (foundPlant != null)
            {
                AssociatedGameObject.GetComponent<CMoveable>().Stop();
                foundPlant.GetComponent<CHealth>().GetDmg(2);

            }
            else
            {
                AssociatedGameObject.GetComponent<CMoveable>().Resume();
            }

            if(AssociatedGameObject.posX <= 120 + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Width)
            {
                GameManager.Entities.Clear();
                GameManager.state = GameManager.GameState.loose;
            }
        }
    }
}
