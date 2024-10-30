using Pvz.Entities.Components;
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

        public override void DoSomething()
        {
            GameObj foundZombie = GameManager.Entities.FindAll(x => x.Tags.Contains("Zombie")).Find(zombie =>
            AssociatedGameObject.posX <= zombie.posX + zombie.GetComponent<CDrawable>().HitBox.Width && 
            AssociatedGameObject.posX + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Width >= zombie.posX &&
            AssociatedGameObject.CorrectedY <= zombie.CorrectedY + zombie.GetComponent<CDrawable>().HitBox.Height &&
            AssociatedGameObject.CorrectedY + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Height >= zombie.CorrectedY);

           if(foundZombie != null)
            {
                AssociatedGameObject.GetComponent<CHealth>().GetDmg(1);
                
                CMoveable zombieMove = foundZombie.GetComponent<CMoveable>();
                
                if(AssociatedGameObject.Tags.Contains("gelpea") && zombieMove.Speed == zombieMove.InitialSpeed)
                {
                    foundZombie.GetComponent<CDrawable>().Effect = "gel";
                    zombieMove.Speed = new Point(-5, 0);


                }
                foundZombie.GetComponent<CHealth>().GetDmg(10);
            }
        }
    }
}
