using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGameEngine
{
    public class Scene : GameObject
    {
        public List<GameObject> _Objects;
        public event OnSceneLoad OnSceneLoad;
        public event OnSceneUnload OnSceneUnload;
        public event OnSceneCreated OnSceneCreated;
        public event OnSceneUpdate OnSceneUpdate;
        public event OnSceneAnimate OnSceneAnimate;
        public event OnObjectAdded OnObjectAdded;
        public event OnObjectRemoved OnObjectRemoved;

        public int status = 1;

        public string Name { get; set; }
        public Scene(Window w) 
            : base(w._Renderer)
        {
            _Objects = new List<GameObject>();
            _win = w;
            OnSceneCreated?.Invoke(this);
        }

        public void Add(GameObject Object)
        {
            _Objects.Add(Object);
            OnObjectAdded?.Invoke(this,Object);
        }

        public void Remove(GameObject Object)
        {
            _Objects.Remove(Object);
            OnObjectRemoved?.Invoke(this, Object);
        }
    
        public void Load()
        {
            OnSceneLoad?.Invoke(this);
            _Objects.ForEach(
                s=> 
                {
                    s.Draw();
                });
        }
                
        public void Animate()
        {
            OnSceneAnimate?.Invoke(this);
            _Objects.ForEach(
                s => 
                {
                    if (s is Sprite)
                    {
                        Sprite ss = (Sprite)s;
                        ss.StartAnimate();
                    }
                });
        }
        public override void Update()
        {
            OnSceneUpdate?.Invoke(this);
            _Objects.ForEach(
                s =>
                {
                    try
                    {
                        ((Image)s).Update();
                    } catch (Exception e) { }
                });
        }

        public void Destroy(string name)
        {
            GameObject j = new GameObject(IntPtr.Zero);
            _Objects.ForEach(
                s =>
                {
                   if(s._Name == name)
                    {
                        j = s;
                        s.Destroy();
                    }                   
                });
            j.Destroy();
        }
    }
}
