using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGameEngine
{
    public class GameManager : GameObject
    {
        List<GameObject> _Objects;

        public GameManager() : base(IntPtr.Zero)
        {
            _Objects = new List<GameObject>();
        }

        public void Add(GameObject Object)
        {
            _Objects.Add(Object);
        }

        public void Remove(GameObject Object)
        {
            _Objects.Remove(Object);
        }

        public override void Draw()
        {
            _Objects.ForEach(s => { s.Draw(); });
        }

        public void Draw(GameObject Object)
        {
            _Objects.ForEach(
                s => 
                {
                    if (s == Object)
                        s.Draw();
                });
        }

        public void Animate()
        {
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

        public void Animate(Sprite sprite)
        {
            _Objects.ForEach(
                s => 
                {
                    if (s is Sprite)
                    {
                        Sprite ss = (Sprite)s;
                        if (ss == sprite)
                            ss.StartAnimate();
                    }
                });
        }
        public override void Update()
        {
            _Objects.ForEach(                
                s => 
                {
                    s.Update();
                });
        }
    }
}
