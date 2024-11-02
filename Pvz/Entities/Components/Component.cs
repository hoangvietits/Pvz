using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pvz.Entities;

namespace Pvz.Entities.Components
{
    public class Component : ICloneable
    {
        public GameObj parent { get; set; }

        public virtual void Update()
        { }

        public object Clone()   
        {
            return this.MemberwiseClone();
        }
    }
}
