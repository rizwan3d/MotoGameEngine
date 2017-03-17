using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static SDL2.SDL;
using System.Threading.Tasks;

namespace MotoGameEngine
{
    public class Sprite : Image
    {
        int _currentFrame = 0;
        int _TotalFrames = 0;

        public Sprite(Window win, string Path,int TotalFrames, int x, int y, int w, int h) 
            : base(win,Path,x,y,w,h)
        { _TotalFrames = TotalFrames; }

        public Sprite(Window win, string Path, int TotalFrames, Vector2D position, Vector2D Size)
            : base(win, Path, position , Size)
        { _TotalFrames = TotalFrames; }

        public void Animate()
        {
            int currentRow = 1;
            SDL_Rect srcRect;

            srcRect.x = (int)Size.X * _currentFrame;
            srcRect.y = (int)Size.Y * (currentRow - 1);
            srcRect.w = _destinationRectangle.w = (int)Size.X;
            srcRect.h = _destinationRectangle.h = (int)Size.Y;

            _currentFrame = (int)((SDL_GetTicks() / 100) % _TotalFrames);

            SDL_RenderCopyEx(_Renderer, _Texture, ref srcRect, ref _destinationRectangle, _Angle, ref _Center, _Flip);            
        }       
    }
}
