using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGameEngine
{
    public class SpriteManager : GameObject
    {
        List<Sprite> _Sprties;

        public SpriteManager() : base(IntPtr.Zero)
        {
            _Sprties = new List<Sprite>();
        }

        public void Add(Sprite sprite)
        {
            _Sprties.Add(sprite);
        }
        
        public void Remove(Sprite sprite)
        {
            _Sprties.Remove(sprite);
        }

        public override void Draw()
        {
            _Sprties.ForEach(s => { s.Draw(); });
        }

        public void Draw(Sprite sprite)
        {
            _Sprties.ForEach(s => { if (s == sprite) s.Draw(); });
        }

        public void Animate()
        {
            _Sprties.ForEach(s => { s.Animate(); });
        }

        public void Animate(Sprite sprite)
        {
            _Sprties.ForEach(s => { if(s == sprite) s.Animate(); });
        }

        public override void Dispose()
        {
            _Sprties.ForEach(s => { s.Dispose(); });
            for(int i = 0; i < _Sprties.Count; i ++) { _Sprties.RemoveAt(i); }
            _Sprties = null;
        }
        ~SpriteManager()
        {
            Dispose();
        }

    }
}
