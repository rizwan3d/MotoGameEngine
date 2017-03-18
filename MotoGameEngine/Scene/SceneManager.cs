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
            _Scene.Remove(scene);
        }
        public void UnLoad(Scene scene)
        {
            //_Scene.Remove(scene);
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

        public void LoadScene(Scene scene)
        {
            _Scene.ForEach(
                s => {
                    if (s == scene)
                        s.Load();
                    if (s.status == 0)
                    {
                        s._Objects.ForEach(
                            o => {
                                o.Visible = true;
                            });
                            s.status = 1;
                    }
                });
        }

        public void AnimateScene()
        {
            _Scene.ForEach(
                s => {
                    s._Objects.ForEach(
                        o => {
                            if (o is Sprite)
                            {
                                Sprite ss = (Sprite)o;
                                ss.Animate();
                            }
                        });
                });
        }

        public void Animate(Sprite sprite)
        {
           _Scene.ForEach(
               s => 
               {
                   s._Objects.ForEach(
                       o => {
                           if (o is Sprite)
                           {
                               Sprite ss = (Sprite)o;
                               if (ss == sprite)
                                   ss.Animate();
                           }
                       });
               });
        }
        public override void Update()
        {
            for (int i = 0; i < _Scene.Count; i++)
            {
                    _Scene[i].Update();
            }
        }
        public override void Dispose()
        {
            _Scene = null;
        }
        ~SceneManager()
        {
            Dispose();
        }
    }
}
