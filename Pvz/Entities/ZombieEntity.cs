using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pvz.Entities.Components;
using Pvz.Entities.GameObject;
namespace Pvz.Entities
{
    class ZombieEntity : GameObj
    {
        CDrawable drawable;
        CMoveable moveable;
        CHealth health;
        public int score;

        public ZombieEntity() { }

        public ZombieEntity(int row, GameManager.Creature zombietype)
        {
            Layer = 3;
            Tags.Add("Zombie");
            Bot = new BotZombie(this);

            drawable = AddComponent(new CDrawable()) as CDrawable;
            moveable = AddComponent(new CMoveable()) as CMoveable;
            health = AddComponent(new CHealth()) as CHealth;

            moveable.InitialSpeed = new Point(-20, 0);
            drawable.HitBox = new Size(50, 40);
            drawable.Sprites = new List<string> { "zombie_1", "zombie_2", "zombie_3", "zombie_2" };
            drawable.Animated = true;
            drawable.HitAnimation = true;

            switch (zombietype)
            {
                case (GameManager.Creature.ZombieCone):
                    health.InitialHP = 250; // Sức khỏe cho ZombieCone
                    drawable.Accessory = "cone_1"; // Phụ kiện cho ZombieCone
                    score = 15;
                    break;
                case (GameManager.Creature.ZombieSot):
                    health.InitialHP = 500; // Sức khỏe cho ZombieSot
                    drawable.Accessory = "sot_1"; // Phụ kiện cho ZombieSot
                    score = 25;
                    break;
                default:
                    health.InitialHP = 150; // Sức khỏe mặc định cho zombie
                    score = 10;
                    break;
            }

            posX = Floor.GetScreenWidth();
            posY = Floor.RowtoY(row);
        }

        public static GameManager.Creature RandomZombie()
        {
            switch(GameManager.Random(0,2))
            {
                case 1:
                    return GameManager.Creature.ZombieSot;
                case 2:
                    return GameManager.Creature.ZombieCone;
                default:
                    return GameManager.Creature.Zombie;
            }
        }

    }
}
