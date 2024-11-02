using Pvz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz
{
     class GameManager
    {
        static public SpriteManager Sprites;
        static public Graphics Monitor;
        static public int Height;
        static public int Sun = 1000;
        static public int Round;
        static public int Score;
        static public int turn;
        static public double DeltaTime;
        static public int zombieTotal = 2;
        static public Creature Button;
        static public GameState state;
        static public bool Debug;
        static public string Name;
        static public string Role;
        static public bool DrawHitBox { get; set; }
        static public bool DisplayHP { get; set; }
        public enum GameState { win, loose, playing};
        public enum Creature
        {
            Zombie, ZombieCone, ZombieSot, Pea, SunFlower, Noix, DoublePea,
            GelPea, Shovel
        }
        static public Dictionary<Creature, int> Cost = new Dictionary<Creature, int>()
        {
            { Creature.Pea,100},
            { Creature.SunFlower,50 },
            { Creature.Noix,50 },
            { Creature.DoublePea,200 },
            { Creature.GelPea,175}

        };
        static public Dictionary<Creature, int> Cooldowns = new Dictionary<Creature, int>()
        {
            { Creature.Pea,100},
            { Creature.SunFlower,50},
            { Creature.Noix,50},
            { Creature.DoublePea,100 },
            { Creature.GelPea,100}
        };
        static public List<GameObj> Entities = new List<GameObj>();
        static public Dictionary<GameManager.Creature, int> plantsCoolDowns = new Dictionary<GameManager.Creature, int>();
        static private Random randNum = new Random();
        public static int Random(int min, int max)
        {
            return randNum.Next(min, max+1);
        }
    }
}
