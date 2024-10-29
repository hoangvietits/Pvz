using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pvz.Components;
using Pvz.Entities.GameObject;

namespace Pvz.Entities;

public class GameObj
{
    public BotBase Bot;
    public List<Component> components = new List<Component>();

}
