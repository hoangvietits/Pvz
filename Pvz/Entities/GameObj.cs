using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Pvz.Entities.Components;
using Pvz.Entities.GameObject;

namespace Pvz.Entities;

public class GameObj
{
    public BotBase Bot;
    public List<Component> Components = new List<Component>();
    public List<String> Tags = new List<string>();
    public int Layer = 0;
    public bool Inactive;
    public float posX, posY, offsetX, offsetY;

    public float CorrectedY
    {
        get { return (GameManager.Height - posY - GetComponent<CDrawable>().HitBox.Height) - offsetY; }
    }

    public void Update()
    {
        if (Bot != null)
        {
            Bot.DoSomething();
        }
        foreach (Component component in Components)
        {
            component.Update();
        }
    }

    public Component AddComponent(Component c)
    {
        c.parent = this;
        Components.Add(c);
        return c;
    }
    public T GetComponent<T>()
    {
        if(Components.OfType<T>().Any())
        {
            return Components.OfType<T>().ToArray()[0];
        }
        return default(T);
    }

    public T Duplicate<T>() where T : GameObj, new()
    {
        T result = new T();
        result.Bot = Bot.Clone() as BotBase;
        result.posX = posX;
        result.offsetX = offsetX;
        result.offsetY = offsetY;
        foreach (Component c in Components)
        {
            result.AddComponent(c.Clone() as Component);
        }

        return result;
    }
}
