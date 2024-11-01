using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz.Entities.GameObject
{
    public class BotBase : ICloneable
    {
        public string botState { get; protected set; }
        public GameObj AssociatedGameObject { get; private set; }
        public BotBase(GameObj go)
        {
            botState = "None";
            this.AssociatedGameObject = go;
        }

 
        public virtual void DoSomething() { }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
