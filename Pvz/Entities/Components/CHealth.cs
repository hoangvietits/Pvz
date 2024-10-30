using Pvz.Entities.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz.Entities.Components
{
    class CHealth : Component
    {
        private int initialHP;
        public int HP { get; set; }

        public override void Update()
        {
            if (!isAlive)
            {
                parent.Inactive = true;
            }
            if (HasBeenHit)
            {
                HasBeenHit = false;
            }
        }
        public int InitialHP
        {
            get
            {
                return initialHP;
            }
            set
            {
                HP = value;
                initialHP = value;
            }
        }

        public void Die()
        {
            HP = 0;
        }
        public bool isAlive
        {
            get { return HP > 0; }
        }
        public bool HasBeenHit
        {
            get;
            internal set;
        }
        public void GetDmg(int dmg)
        {
            HP -= dmg;
            HasBeenHit = true;
        }
    }
}
