using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGameEngine
{
    public delegate void Updatedelegate(Window sender);
    public delegate void OnExit(Window sender);

    public delegate void OnSceneLoad(Scene sender);
    public delegate void OnSceneUnload(Scene sender);
    public delegate void OnSceneCreated(Scene sender);
    public delegate void OnSceneUpdate(Scene sender);
    public delegate void OnObjectAdded(Scene sender,GameObject Object);
    public delegate void OnObjectRemoved(Scene sender, GameObject Object);
    public delegate void OnSceneAnimate(Scene sender);

    public delegate void OnClicked(GameObject sender);
    public delegate void OnHover(GameObject sender);


    public delegate void EventUpdatedelegate(Window sender, Event e);
}
