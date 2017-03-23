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

        public Scene(string Name, Window w) 
            : base(w._Renderer)
        {
            _Name = Name;
            _Objects = new List<GameObject>();
            _win = w;
            OnSceneCreated?.Invoke(this);
            w.SceneManager.Add(this);
        }

        public void Add(GameObject Object)
        {
            _Objects.Add(Object);
            OnObjectAdded?.Invoke(this,Object);
        }

        public void Remove(string name)
        {
            foreach (GameObject o in _Objects)
            {
                if (o._Name == name)
                {
                    OnObjectRemoved?.Invoke(this, o);
                    _Objects.Remove(o);
                }
            }         
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
                        ss.Animate();
                    }
                });
        }
        public override void Update(Window sender, Event e)
        {
            OnSceneUpdate?.Invoke(this);
            _Objects.ForEach(
                s =>
                {
                    try
                    {
                        ((Image)s).Update(sender, e);
                    } catch (Exception ee) { }
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

        public T GetGameObject<T>(string name) where T : GameObject
        {
            GameObject j = new GameObject(IntPtr.Zero);
            _Objects.ForEach(
                s =>
                {
                    if (s._Name == name)
                    {
                        j = s;
                    }
                });
            if(j._Name == name)
                return (T)j;
            throw new Exception();
        }
    }
}
