using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz
{
     class Sprite
    {
        float _zoom = 1;
        Bitmap _bitmap;
        
        public Sprite (Bitmap b, float zoom)
        {
            _bitmap = b;
            _zoom = zoom;
            _bitmap.MakeTransparent(Color.FromArgb(0,0,0));
        }

        public void DrawtoScreen(float x, float y)
        {
            int xx = (int)x;
            int yy = (int)(GameManager.Height - y - _bitmap.Height);

            int H = (int)(_bitmap.Height*_zoom );
            int W = (int)(_bitmap.Width*_zoom );

            GameManager.Monitor.DrawImage(_bitmap, xx, yy, W, H);

        }
    }
}
