using Pvz.Entities.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz.Entities
{
    public static class DebugMode
    {
        public static void Update()
        {
            if(GameManager.DrawHitBox)
            {
                DrawHitBox();
            }
            if(GameManager.DisplayHP)
            {
                DisplayHP();
            }
        }
        public static void DisplayHP()
        {
            foreach (GameObj go in GameManager.Entities)
            {
                CHealth health = go.GetComponent<CHealth>();
                if (health != null)
                {
                    GameManager.Monitor.FillRectangle(Brushes.Black, go.posX - 8, go.CorrectedY - 20, 100, 10);
                    GameManager.Monitor.FillRectangle(Brushes.Blue, go.posX - 8, go.CorrectedY - 20, (health.HP / health.InitialHP) * 100, 10);
                    GameManager.Monitor.DrawString(health.HP + "/" + health.InitialHP, SystemFonts.DefaultFont, Brushes.White, go.posX, go.CorrectedY - 22);
                }
            }
        }

        public static void DrawHitBox()
        {
            foreach(GameObj go in GameManager.Entities.FindAll(x => x.GetComponent<CDrawable>() != null))
            {
                GameManager.Monitor.FillRectangle(new SolidBrush(Color.FromArgb(128, 255, 0, 0)),
                    go.posX + go.offsetX,
                    go.CorrectedY,
                    go.GetComponent<CDrawable>().HitBox.Width,
                    go.GetComponent<CDrawable>().HitBox.Height);
            }
        }
    }
}
