using Pvz.Entities.Components;
using Pvz.Entities.GameObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz.Entities
{
     class PlantEntity : GameObj
    {
        CDrawable drawable;
        CMoveable moveable;
        CHealth health;

        public PlantEntity(int col, int row, GameManager.Creature plantType)
        {
            Layer = 1;
            Tags.Add("Plant");
            Bot = new BotPlant(this);

            drawable = AddComponent(new CDrawable()) as CDrawable;
            moveable = AddComponent(new CMoveable()) as CMoveable;
            health = AddComponent(new CHealth()) as CHealth;

            drawable.HitBox = new System.Drawing.Size(56, 55);
            posX = Floor.ColToX(col);
            posY = Floor.RowtoY(row);

            switch (plantType)
            {
                case GameManager.Creature.SunFlower:
                    Bot = new BotSunFlower(this);
                    health.InitialHP = 100;
                    drawable.Sprites = new List<string> { "sunflower" };
                    break;
                case GameManager.Creature.Pea:
                    
                    health.InitialHP = 150;
                    drawable.Sprites = new List<string> { "pea"};
                    AddComponent(new CShootable());
                    GetComponent<CShootable>().ShootSpeed = 300;
                    GetComponent<CShootable>().ShootDmg = 15;
                    break;
                case GameManager.Creature.DoublePea:
                    health.InitialHP = 150;
                    drawable.Sprites = new List<string> { "doublepea" };
                    AddComponent(new CShootable());
                    GetComponent<CShootable>().ShootSpeed = 300;
                    GetComponent<CShootable>().ShootDmg = 15;
                    GetComponent<CShootable>().DoubleShoot = true;
                    break;
                case GameManager.Creature.GelPea:
                    Tags.Add("gelpea");
                    health.InitialHP = 150;
                    drawable.Sprites = new List<string> { "gelpea" };
                    AddComponent(new CShootable());
                    GetComponent<CShootable>().ShootSpeed = 300;
                    GetComponent<CShootable>().ShootDmg = 15;
                    break;
                case GameManager.Creature.Noix:
                    Bot = new BotNut(this);
                    drawable.Sprites = new List<string> { "noix_1", "noix_2", "noix_3" };
                    health.InitialHP = 2000;
                    break;
                
            }

            offsetX = 15;
            offsetY = 25;
        }
    }
}
