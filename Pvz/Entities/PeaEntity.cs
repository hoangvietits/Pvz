using Pvz.Entities.Components;
using Pvz.Entities.GameObject;


namespace Pvz.Entities
{
    class PeaEntity : GameObj
    {
        private CHealth health;
        private CMoveable moveable;
        private CDrawable drawable;

        public PeaEntity(float posX, float posY, double shootSpeed, int dmg )
        {
            Bot = new BotPea(this);
            Layer = 3;

            drawable = AddComponent(new CDrawable()) as CDrawable;
            moveable = AddComponent(new CMoveable()) as CMoveable;
            health = AddComponent(new CHealth()) as CHealth;
            moveable.Speed = new System.Drawing.Point((int)shootSpeed, 0);
            health.InitialHP = 1;
            this.posX = posX;
            this.posY = posY;

            drawable.HitBox = new System.Drawing.Size(20, 30);
        }
    }
}
