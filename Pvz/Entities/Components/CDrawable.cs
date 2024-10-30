
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz.Entities.Components
{
    class CDrawable : Component
    {
        public List<string> Sprites;
        public Size HitBox;
        public bool HitAnimation { get; set; }
        public bool Animated { get; set; }
        public string Accessory { get; set; }
        public string Effect { get; set; }
        private int count;
        public int stats;

        public override void Update()
        {
            count++;
        }
        public virtual void Draw()
        {
            if (!string.IsNullOrEmpty(Effect))
            {
                GameManager.Sprites.Get(Effect).DrawtoScreen(parent.posX + 10, parent.posY - 8);
            }
            if (Animated)
            {
                stats = count / 10 % Sprites.Count;
            }
            if (parent.GetComponent<CHealth>() != null && parent.GetComponent<CHealth>().HasBeenHit && HitAnimation)
            {
                GameManager.Sprites.Get(Sprites[stats] + "_touche").DrawtoScreen(parent.posX + parent.offsetX, parent.posY + parent.offsetY);
            }
            else
            {
                GameManager.Sprites.Get(Sprites[stats]).DrawtoScreen(parent.posX + parent.offsetX, parent.posY + parent.offsetY);
            }
            if (!string.IsNullOrEmpty(Accessory))
            {
                GameManager.Sprites.Get(Accessory).DrawtoScreen(parent.posX + 2, parent.posY + 80 + (stats % 2 == 0 ? 0 : 5));
            }
        }

    }
}
