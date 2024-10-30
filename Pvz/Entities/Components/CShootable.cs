
using Pvz.Entities.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz.Entities.Components
{
    class CShootable : Component
    {
        public int ShootSpeed { get; set; }
        public int ShootDmg { get; set; }
        public bool DoubleShoot {  get; set; }
        public string PeaType { get; set; }

        public override void Update()
        {
            if(parent.Bot.botState == "shooting")
            {
                if(GameManager.turn % 20 == 0)
                {
                    Shoot();
                }
                if(GameManager.turn % 20 == 3 && DoubleShoot)
                {
                    Shoot();
                }
            }
        }

        public void Shoot()
        {
            int offsetX = 48;
            int offsetY;
            PeaEntity pea;
            if(parent.Tags.Contains("SnowPea"))
            {
                offsetY = 65;
                pea = new PeaEntity(parent.posX + offsetX, parent.posY + offsetY, ShootSpeed, ShootDmg);
                pea.Tags.Add("SnowPea");
                pea.GetComponent<CDrawable>().Sprites = new List<string> {"gelBullet" };

            }
            else
            {
                offsetY = 51;
                pea = new PeaEntity(parent.posX + offsetX, parent.posY + offsetY, ShootSpeed, ShootDmg);
                pea.GetComponent<CDrawable>().Sprites = new List<string> { "bullet" };

            }
            GameManager.Entities.Add(pea);
        }
    }
}
