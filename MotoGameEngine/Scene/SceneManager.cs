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
        public void Remove(Scene scene)
        {
            UnLoad(scene);
            _Scene.Remove(scene);
        }
        public void UnLoad(Scene scene)
        {
            scene._Objects.ForEach(
                o =>
                {
                    o.Visible = false;
                });
            scene.status = 0;
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

        public void LoadScene(Scene scene)
        {
            _Scene.ForEach(
                 s => {
                     if (s == scene)
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

        public override void Update(Window sender, Event e)
        {
            for (int i = 0; i < _Scene.Count; i++)
            {
                    _Scene[i].Update(sender, e);
            }
        }
    }
}
