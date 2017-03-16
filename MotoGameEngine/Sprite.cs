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
        public Sprite(Window win, string Path, int x, int y, int w, int h) 
            : base(win,Path,x,y,w,h)
        {}

        public void Animate(int currentRow,int AnimationCount)
        {
            SDL_Rect srcRect;

            srcRect.x = _W * _currentFrame;
            srcRect.y = _H * (currentRow - 1);
            srcRect.w = _destinationRectangle.w = _W;
            srcRect.h = _destinationRectangle.h = _H;

            _currentFrame = (int)((SDL_GetTicks() / 100) % AnimationCount);

            SDL_RenderCopyEx(_Renderer, _Texture, ref srcRect, ref _destinationRectangle, _Angle, ref _Center, _Flip);
            
        }       
    }
}
