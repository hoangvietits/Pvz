using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pvz
{
     class SpriteManager
    {
        Dictionary<string, Sprite> SpriteList = new Dictionary<string, Sprite>();
        public SpriteManager() 
        {
            Load();
        }
        private void Load()
        {
            SpriteList.Add("cone_1", new Sprite(Properties.Resources.cone_1,1.0f));
            SpriteList.Add("cone_2", new Sprite(Properties.Resources.cone_2,1.0f));
            SpriteList.Add("cone_3", new Sprite(Properties.Resources.cone_3,1.0f));

            SpriteList.Add("sot_1", new Sprite(Properties.Resources.sot_1,1.0f));
            SpriteList.Add("sot_2", new Sprite(Properties.Resources.sot_2,1.0f));
            SpriteList.Add("sot_3", new Sprite(Properties.Resources.sot_3,1.0f));

            SpriteList.Add("zombie_1", new Sprite(Properties.Resources.zombie_1,1.0f));
            SpriteList.Add("zombie_2", new Sprite(Properties.Resources.zombie_2,1.0f));
            SpriteList.Add("zombie_3", new Sprite(Properties.Resources.zombie_3,1.0f));

            SpriteList.Add("zombie_1_hit", new Sprite(Properties.Resources.zombie_1_touche,1.0f));
            SpriteList.Add("zombie_2_hit", new Sprite(Properties.Resources.zombie_2_touche,1.0f));
            SpriteList.Add("zombie_3_hit", new Sprite(Properties.Resources.zombie_3_touche,1.0f));


            SpriteList.Add("pea", new Sprite(Properties.Resources.plante_pois,1.0f));
            SpriteList.Add("doublePea", new Sprite(Properties.Resources.plante_pois_double,1.0f));
            SpriteList.Add("noix_1", new Sprite(Properties.Resources.noix_1,1.0f));
            SpriteList.Add("noix_2", new Sprite(Properties.Resources.noix_2,1.0f));
            SpriteList.Add("noix_3", new Sprite(Properties.Resources.noix_3,1.0f));
            SpriteList.Add("gelpea", new Sprite(Properties.Resources.plante_gel,1.0f));
            SpriteList.Add("sunflower", new Sprite(Properties.Resources.plante_soleil,1.0f));
            
            SpriteList.Add("gel", new Sprite(Properties.Resources.gel,1.0f));
            SpriteList.Add("sun", new Sprite(Properties.Resources.soleil,1.0f));
            SpriteList.Add("gelbullet", new Sprite(Properties.Resources.tir_gel,1.0f));
            SpriteList.Add("bullet", new Sprite(Properties.Resources.tir_pois,1.0f));
            
            SpriteList.Add("decor", new Sprite(Properties.Resources.decor,1.0f));
            SpriteList.Add("dollar", new Sprite(Properties.Resources.dollar,1.0f));

            SpriteList.Add("loose", new Sprite(Properties.Resources.ZombiesWon,1.0f));
            SpriteList.Add("Win", new Sprite(Properties.Resources.win,1.0f)); 
            
        }
        public Sprite Get(string name)
        {
            return SpriteList[name];
        }
    }
}
