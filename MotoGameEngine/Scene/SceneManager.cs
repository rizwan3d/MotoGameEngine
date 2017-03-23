using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGameEngine
{
    public class SceneManager : GameObject
    {
        List<Scene> _Scene;

        public SceneManager() 
            : base(IntPtr.Zero)
        {
            _Scene = new List<Scene>();
        }

        public void Add(Scene scene)
        {
            _Scene.Add(scene);
        }
        public void Remove(string name)
        {
            UnLoad(name);
            foreach (Scene s in _Scene)
            {
                if(s._Name == name)
                    _Scene.Remove(s);
            }            
        }
        public void UnLoad(string name)
        {
            _Scene.ForEach(
                 s =>
                 {
                     if (s._Name == name)
                     {
                         s._Objects.ForEach(
                                    o =>
                                    {
                                        o.Visible = false;
                                    });
                         s.status = 0;
                     }
                 });
        }

        public void LoadEverything()
        {
            _Scene.ForEach(
                s => 
                {
                    s.Load();
                });
        }

        public void Start()
        {
            LoadEverything();
        }

        public void LoadScene(string name)
        {
            _Scene.ForEach(
                 s => {
                     if (s._Name == name)
                     {
                             s._Objects.ForEach(
                                 o =>
                                 {
                                     o.Visible = true;
                                 });
                             s.status = 1;
                     }
                 });
        }

        public Scene GetScene(string name)
        {
            foreach(Scene s in _Scene)
            {
                if(s._Name == name)
                {
                    return s;
                }
            }
            return null;
        }


        public T GetGameObject<T>(string Scenename, string ObjectName) where T : GameObject
        {
            GameObject j = new GameObject(IntPtr.Zero);
            foreach (Scene s in _Scene)
            {
                if (s._Name == Scenename)
                {
                    foreach (GameObject o in s._Objects)
                    {
                        if (o._Name == ObjectName)
                        {
                            return (T)o;
                        }
                    }
                }
            }
            throw new Exception();
        }

        public override void Update(Window sender, Event e)
        {
            for (int i = 0; i < _Scene.Count; i++)
            {
                    _Scene[i].Update(sender, e);
            }
        }
    }
}
