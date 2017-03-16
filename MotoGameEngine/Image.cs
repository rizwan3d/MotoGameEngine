using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SDL2.SDL_image;
using static SDL2.SDL;

namespace MotoGameEngine
{
    public class Image : IDisposable
    {
        protected IntPtr _Texture; // the new SDL_Texture variable 
        protected SDL_Rect _sourceRectangle; // the first rectangle 
        protected SDL_Rect _destinationRectangle; // another rectangle 

        protected IntPtr _Renderer;

        protected SDL_RendererFlip _Flip;

        protected float _Angle;
        protected SDL_Point _Center;

        protected int _X, _Y, _H,_W;

        public void SetImage(string Path)
        {
            IntPtr _TempSurface = IMG_Load(Environment.CurrentDirectory + Path);

            if (_TempSurface == null || _TempSurface == IntPtr.Zero) { Console.WriteLine("Error"); return; }

            _Texture = SDL_CreateTextureFromSurface(_Renderer, _TempSurface);

            if (_Texture == null || _Texture == IntPtr.Zero) { Console.WriteLine("Error"); return; }           

            SDL_FreeSurface(_TempSurface);
        }

        public Image(Window win,string Path,int x,int y,int w,int h)
        {
            _X = x;
            _Y = y;
            _H = h;
            _W = w;

            _Renderer = win._Renderer;
            SetImage(Path);

            int a;
            uint b;

            SDL_QueryTexture(_Texture, out b, out a, out _sourceRectangle.w, out _sourceRectangle.h);

            _sourceRectangle.w = w;
            _sourceRectangle.h = h;

            _destinationRectangle.x = x;
            _destinationRectangle.y = y;

            _destinationRectangle.w = _sourceRectangle.w;
            _destinationRectangle.h = _sourceRectangle.h;

            _Flip = SDL_RendererFlip.SDL_FLIP_NONE;

            _Angle = 0;
            _Center.x = (_sourceRectangle.w) / 2;
            _Center.y = (_sourceRectangle.h) / 2;

        }

        public virtual void Render()
        {
            SDL_RenderCopyEx(_Renderer, _Texture, ref _sourceRectangle, ref _destinationRectangle, _Angle, ref _Center, _Flip);
        }

        public void Flip(int angle,int x ,int y,int a)
        {
            _Angle = angle;
            _Center.x = x;
            _Center.y = y;

            if(a == 0)
            {
                _Flip = SDL_RendererFlip.SDL_FLIP_NONE;
            }
            else if (a == 1)
            {
                _Flip = SDL_RendererFlip.SDL_FLIP_HORIZONTAL;
            }
            else if (a == 2)
            {
                _Flip = SDL_RendererFlip.SDL_FLIP_VERTICAL;
            }
        }

        public void Rotate(float angle)
        {
            _Angle = angle;
        }
        public void Dispose()
        {
            SDL_DestroyTexture(_Texture);
        }
        ~Image()
        {
            Dispose();
        }
    }    
}
