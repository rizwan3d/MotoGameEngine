using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SDL2.SDL_image;
using static SDL2.SDL;

namespace MotoGameEngine
{
    public class Image : GameObject
    {        
        protected SDL_Rect _sourceRectangle; // the first rectangle 
        protected SDL_Rect _destinationRectangle; // another rectangle 

        protected SDL_RendererFlip _Flip;

        protected float _Angle;
        protected SDL_Point _Center;

    public void SetImage(string Path)
        {
            IntPtr _TempSurface = IMG_Load(SDL_GetBasePath() + Path);

            if (_TempSurface == null 
                || _TempSurface == IntPtr.Zero)
            {
                throw (new Loading_Image("Error occurred while loading image"));
            }

            _Texture = SDL_CreateTextureFromSurface(_Renderer, _TempSurface);

            if (_Texture == null 
                || _Texture == IntPtr.Zero)
            {
                throw (new Loading_Image("Error occurred while loading image"));
            }           

            SDL_FreeSurface(_TempSurface);
        }

        public Image(Scene s,string Path,int x,int y,int w,int h)
        : base(s._win._Renderer,x,y,w,h)
        {
            _S = s;
            SetImage(Path);
            init();
        }
        public Image(Scene s, string Path, Vector2D position, Vector2D Size)
        : base(s._win._Renderer, position, Size)
        {
            _S = s;
            SetImage(Path);
            init();
        }

        void init()
        {
            int a;
            uint b;

            SDL_QueryTexture(_Texture, out b, out a, out _sourceRectangle.w, out _sourceRectangle.h);

            _Flip = SDL_RendererFlip.SDL_FLIP_NONE;

            _Angle = 0;
            _Center.x = (_sourceRectangle.w) / 2;
            _Center.y = (_sourceRectangle.h) / 2;

            _S.Add(this);
            //_win.SceneManager.Add();

        }

        public override void Draw()
        {
            if (Visible)
            {
                _sourceRectangle.w = (int)Size.X;
                _sourceRectangle.h = (int)Size.Y;

                _destinationRectangle.x = (int)Position.X;
                _destinationRectangle.y = (int)Position.Y;

                _destinationRectangle.w = _sourceRectangle.w;
                _destinationRectangle.h = _sourceRectangle.h;
                SDL_RenderCopyEx(_Renderer, _Texture, ref _sourceRectangle, ref _destinationRectangle, _Angle, ref _Center, _Flip);
            }
        }

        public override void Update()
        {
            if (Velocity != null)
            {
                Position = Position + Velocity;
                _destinationRectangle.x = (int)Position.X;
                _destinationRectangle.y = (int)Position.Y;
            }
            if(Acceleration != null)
            {
                Velocity = Velocity + Acceleration;
            }
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
        public override void Dispose()
        {
            SDL_DestroyTexture(_Texture);
        }
        ~Image()
        {
            Dispose();
        }
    }    
}
