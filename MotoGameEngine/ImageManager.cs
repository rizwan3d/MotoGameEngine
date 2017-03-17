using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGameEngine
{
    class ImageManager : GameObject
    {
        List<Image> _Images;

        public ImageManager() : base(IntPtr.Zero)
        {
            _Images = new List<Image>();
        }

        public void Add(Image sprite)
        {
            _Images.Add(sprite);
        }

        public void Remove(Image sprite)
        {
            _Images.Remove(sprite);
        }

        public override void Draw()
        {
            _Images.ForEach(s => { s.Draw(); });
        }

        public void Draw(Sprite sprite)
        {
            _Images.ForEach(s => { if (s == sprite) s.Draw(); });
        }
        

        public override void Dispose()
        {
            _Images.ForEach(s => { s.Dispose(); });
            for (int i = 0; i < _Images.Count; i++) { _Images.RemoveAt(i); }
            _Images = null;
        }
        ~ImageManager()
        {
            Dispose();
        }
    }
}
